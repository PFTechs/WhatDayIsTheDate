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

            DateTime ValueToCheck = Convert.ToDateTime(result);

            string returnValue = Convert.ToString(ValueToCheck.DayOfWeek);

            DisplayResult.Text = $"It's {returnValue}!";


        }
    }
}