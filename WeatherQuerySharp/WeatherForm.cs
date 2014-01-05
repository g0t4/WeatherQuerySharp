using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace WeatherQuerySharp
{
    /// <summary>
    /// Weather Query main form
    /// </summary>
    public partial class WeatherForm : Form
    {
        //API address constants
        private const string LINK_URI = @"http://openweathermap.org/";
        private const string URI = @"http://api.openweathermap.org/data/2.5/";
        private const string QUERY = @"weather?q=";

        /// <summary>
        /// WeatherQuery object structure
        /// </summary>
        private struct WeatherQuery
        {
            public string city;
            public string country;
            public string weather;
            public string weatherDesc;
            public decimal latitude;
            public decimal longitude;
            public decimal temperature;
            public decimal pressure;
            public decimal humidity;

            /// <summary>
            /// Formats each attribute of the struct as a string
            /// </summary>
            /// <returns>Formatted attribute string</returns>
            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(String.Format("{0}, {1}\n", city, country));
                builder.Append(String.Format("Latitude: {0}\n", latitude));
                builder.Append(String.Format("Longitude: {0}\n\n", longitude));
                builder.Append(String.Format("{0}: {1}\n", weather, weatherDesc));
                builder.Append(String.Format("Temperature: {0}\n", temperature));
                builder.Append(String.Format("Pressure: {0}\n", pressure));
                builder.Append(String.Format("Humidity: {0}\n", humidity));

                return builder.ToString();
            }
        }

        WeatherQuery query;
        WebClient client;
        JavaScriptSerializer parser;

        /// <summary>
        /// Constructor
        /// </summary>
        public WeatherForm()
        {
            InitializeComponent();
            ActiveControl = QueryBox;

            client = new WebClient();
            parser = new JavaScriptSerializer();
            query = new WeatherQuery();
        }

        /// <summary>
        /// Exit Button click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Query Button click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryButton_Click(object sender, EventArgs e)
        {
            var queryUri = new Uri(String
                .Format("{0}{1}{2}&units={3}", URI, QUERY, QueryBox.Text, CelsiusRadio.Checked ? "metric" : "imperial"));
            client.DownloadStringCompleted += QueryCompleted;
            client.DownloadStringAsync(queryUri);
        }

        /// <summary>
        /// Query string download completed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            ResultsBox.Focus();

            try
            {
                var resultObj = parser.Deserialize<dynamic>(e.Result);
                
                query.city = resultObj["name"];
                query.country = resultObj["sys"]["country"];
                query.weather = resultObj["weather"][0]["main"];
                query.weatherDesc = resultObj["weather"][0]["description"];
                query.latitude = resultObj["coord"]["lat"];
                query.longitude = resultObj["coord"]["lon"];
                query.temperature = resultObj["main"]["temp"];
                query.pressure = resultObj["main"]["pressure"];
                query.humidity = resultObj["main"]["humidity"];

                if (query.country.Equals("CA"))
                {
                    query.country = "Canada";
                }
                else if (query.country.Equals("US"))
                {
                    query.country = "United States";
                }

                ResultsBox.Text = query.ToString();
            }
            catch
            {
                ResultsBox.Text = "An error occured obtaining city information, please double check name and try again!";
            }
        }

        /// <summary>
        /// Subtitle link click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtitleLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            browseTo(LINK_URI);
        }

        /// <summary>
        /// About button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutButton_Click(object sender, EventArgs e)
        {
            new WeatherAbout().Show();
            
        }

        /// <summary>
        /// Opens a web address in the host default browser
        /// </summary>
        /// <param name="uri">web address string</param>
        public static void browseTo(string uri)
        {
            Process.Start(uri);
        }
    }
}
