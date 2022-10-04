namespace WhatDayIsTheDate
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnTellMe_Click(object sender, EventArgs e)
        {
            string result = InputBox.Text;
            try
            {
                DateTime ValueToCheck = Convert.ToDateTime(result);
                string returnValue = Convert.ToString(ValueToCheck.DayOfWeek);
                //DisplayResult.Location = new System.Drawing.Point(247, 427);
                DisplayResult.Text = $"It's {returnValue}!";
            }
             catch (Exception)
            {
               // DisplayResult.Location = new System.Drawing.Point(56, 427);
                DisplayResult.Text = "Invalid date format, try again!";
            }
        }
    }
}