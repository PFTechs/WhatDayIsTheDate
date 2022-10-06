namespace WhatDayIsTheDate
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.InputBox = new System.Windows.Forms.TextBox();
            this.UserPrompt = new System.Windows.Forms.Label();
            this.BtnTellMe = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.Disclaimer = new System.Windows.Forms.Label();
            this.DisplayResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputBox.Location = new System.Drawing.Point(294, 264);
            this.InputBox.Margin = new System.Windows.Forms.Padding(5);
            this.InputBox.MinimumSize = new System.Drawing.Size(200, 50);
            this.InputBox.Name = "InputBox";
            this.InputBox.PlaceholderText = "DD/MM/YYYY";
            this.InputBox.Size = new System.Drawing.Size(200, 50);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_OnTextChange);
            // 
            // UserPrompt
            // 
            this.UserPrompt.AutoSize = true;
            this.UserPrompt.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserPrompt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserPrompt.Location = new System.Drawing.Point(194, 201);
            this.UserPrompt.Name = "UserPrompt";
            this.UserPrompt.Size = new System.Drawing.Size(439, 36);
            this.UserPrompt.TabIndex = 1;
            this.UserPrompt.Text = "Please enter the date (DD/MM/YYYY)";
            // 
            // BtnTellMe
            // 
            this.BtnTellMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTellMe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTellMe.ForeColor = System.Drawing.Color.White;
            this.BtnTellMe.Location = new System.Drawing.Point(313, 338);
            this.BtnTellMe.Name = "BtnTellMe";
            this.BtnTellMe.Size = new System.Drawing.Size(161, 54);
            this.BtnTellMe.TabIndex = 2;
            this.BtnTellMe.Text = "Tell Me!";
            this.BtnTellMe.UseVisualStyleBackColor = true;
            this.BtnTellMe.Click += new System.EventHandler(this.BtnTellMe_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(37, 31);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(120, 120);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppName.Location = new System.Drawing.Point(167, 47);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(512, 68);
            this.AppName.TabIndex = 4;
            this.AppName.Text = "What Day Is This Date?";
            // 
            // Disclaimer
            // 
            this.Disclaimer.AutoSize = true;
            this.Disclaimer.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disclaimer.ForeColor = System.Drawing.SystemColors.Control;
            this.Disclaimer.Location = new System.Drawing.Point(372, 106);
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Size = new System.Drawing.Size(295, 17);
            this.Disclaimer.TabIndex = 5;
            this.Disclaimer.Text = "Developed by PF Techs© in 2022. All Rights Reserved.";
            // 
            // DisplayResult
            // 
            this.DisplayResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayResult.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayResult.Location = new System.Drawing.Point(40, 427);
            this.DisplayResult.Name = "DisplayResult";
            this.DisplayResult.Size = new System.Drawing.Size(700, 68);
            this.DisplayResult.TabIndex = 6;
            this.DisplayResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DisplayResult);
            this.Controls.Add(this.Disclaimer);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.BtnTellMe);
            this.Controls.Add(this.UserPrompt);
            this.Controls.Add(this.InputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "What Day Is This Date? - PF Techs©";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UserPrompt;
        private Button BtnTellMe;
        private PictureBox Logo;
        private Label AppName;
        private Label Disclaimer;
        private Label DisplayResult;
        public TextBox InputBox;
    }
}