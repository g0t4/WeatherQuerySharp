namespace WeatherQuerySharp
{
    partial class WeatherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QueryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.ResultsBox = new System.Windows.Forms.RichTextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.LinkLabel();
            this.UnitGroup = new System.Windows.Forms.GroupBox();
            this.CelsiusRadio = new System.Windows.Forms.RadioButton();
            this.FahrenheitRadio = new System.Windows.Forms.RadioButton();
            this.AboutButton = new System.Windows.Forms.Button();
            this.UnitGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(28, 314);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(2);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(82, 35);
            this.QueryButton.TabIndex = 0;
            this.QueryButton.Text = "Get Forecast";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(211, 314);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(82, 35);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // QueryLabel
            // 
            this.QueryLabel.Location = new System.Drawing.Point(20, 90);
            this.QueryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(50, 12);
            this.QueryLabel.TabIndex = 2;
            this.QueryLabel.Text = "City:";
            this.QueryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.Location = new System.Drawing.Point(20, 118);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(50, 12);
            this.ResultsLabel.TabIndex = 3;
            this.ResultsLabel.Text = "Results:";
            this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryBox
            // 
            this.QueryBox.Location = new System.Drawing.Point(82, 90);
            this.QueryBox.Margin = new System.Windows.Forms.Padding(2);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(211, 20);
            this.QueryBox.TabIndex = 4;
            // 
            // ResultsBox
            // 
            this.ResultsBox.Location = new System.Drawing.Point(82, 115);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(211, 128);
            this.ResultsBox.TabIndex = 6;
            this.ResultsBox.Text = "";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(23, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(270, 34);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Weather Query";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.SubtitleLabel.LinkColor = System.Drawing.Color.Black;
            this.SubtitleLabel.Location = new System.Drawing.Point(79, 55);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(211, 22);
            this.SubtitleLabel.TabIndex = 8;
            this.SubtitleLabel.TabStop = true;
            this.SubtitleLabel.Text = "Powered by OpenWeatherMap";
            this.SubtitleLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.SubtitleLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SubtitleLabel_LinkClicked);
            // 
            // UnitGroup
            // 
            this.UnitGroup.Controls.Add(this.FahrenheitRadio);
            this.UnitGroup.Controls.Add(this.CelsiusRadio);
            this.UnitGroup.Location = new System.Drawing.Point(82, 249);
            this.UnitGroup.Name = "UnitGroup";
            this.UnitGroup.Size = new System.Drawing.Size(211, 60);
            this.UnitGroup.TabIndex = 9;
            this.UnitGroup.TabStop = false;
            this.UnitGroup.Text = "Measurement";
            // 
            // CelsiusRadio
            // 
            this.CelsiusRadio.AutoSize = true;
            this.CelsiusRadio.Checked = true;
            this.CelsiusRadio.Location = new System.Drawing.Point(33, 25);
            this.CelsiusRadio.Name = "CelsiusRadio";
            this.CelsiusRadio.Size = new System.Drawing.Size(58, 17);
            this.CelsiusRadio.TabIndex = 0;
            this.CelsiusRadio.TabStop = true;
            this.CelsiusRadio.Text = "Celsius";
            this.CelsiusRadio.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRadio
            // 
            this.FahrenheitRadio.AutoSize = true;
            this.FahrenheitRadio.Location = new System.Drawing.Point(97, 25);
            this.FahrenheitRadio.Name = "FahrenheitRadio";
            this.FahrenheitRadio.Size = new System.Drawing.Size(75, 17);
            this.FahrenheitRadio.TabIndex = 1;
            this.FahrenheitRadio.Text = "Fahrenheit";
            this.FahrenheitRadio.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(120, 314);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(82, 35);
            this.AboutButton.TabIndex = 10;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 362);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.UnitGroup);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.QueryButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WeatherForm";
            this.Text = "Weather Query";
            this.UnitGroup.ResumeLayout(false);
            this.UnitGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.RichTextBox ResultsBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.LinkLabel SubtitleLabel;
        private System.Windows.Forms.GroupBox UnitGroup;
        private System.Windows.Forms.RadioButton FahrenheitRadio;
        private System.Windows.Forms.RadioButton CelsiusRadio;
        private System.Windows.Forms.Button AboutButton;
    }
}

