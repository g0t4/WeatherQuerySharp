using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherQuerySharp
{
    /// <summary>
    /// Weather Query about form
    /// </summary>
    partial class WeatherAbout : Form
    {
        //Web URI constant
        public const string AUTHOR_URI = @"http://jukesfordays.com/";

        /// <summary>
        /// Constructor
        /// </summary>
        public WeatherAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// OK Button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Author click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAuthor_Click(object sender, EventArgs e)
        {
            WeatherForm.browseTo(AUTHOR_URI);
        }
    }
}
