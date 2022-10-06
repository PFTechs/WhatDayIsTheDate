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
                string? returnValue = Convert.ToString(ValueToCheck.DayOfWeek);
                //DisplayResult.Location = new System.Drawing.Point(247, 427);
                DisplayResult.Text = $"It's {returnValue}!";
            }
             catch (Exception)
            {
               // DisplayResult.Location = new System.Drawing.Point(56, 427);
                DisplayResult.Text = "Invalid date format, try again!";
            }
        }
        public string returnValue;
        private void InputBox_OnTextChange(object sender, EventArgs e)
        {

            DisplayResult.Text = "";
            int x;
            int InputValue = InputBox.Text.Length;
            bool result = int.TryParse(InputBox.Text, out x);
            returnValue = InputBox.Text;


            if (result)
            {
                switch (InputValue)
                {
                    case 0:
                        InputBox.Text = "DD/MM/YYYY";
                        break;
                    case 1:
                        InputBox.Text = $"{returnValue}D/MM/YYYY";
                        InputBox.SelectionStart = 1;
                        break;
                    case 2:
                        InputBox.Text = $"{returnValue}/MM/YYYY";
                        InputBox.SelectionStart = 1;
                        break;
                    case 3:
                        InputBox.Text = $"{returnValue}MM/YYYY";
                        InputBox.SelectionStart = 1;
                        break;
                    case 4:
                        InputBox.Text = $"{returnValue}M/YYYY";
                        break;
                    case 5:
                        InputBox.Text = $"{returnValue}/YYYY";
                        break;
                    case 6:
                        InputBox.Text = $"{returnValue}YYYY";
                        break;
                    case 7:
                        InputBox.Text = $"{returnValue}YYY";
                        break;
                    case 8:
                        InputBox.Text = $"{returnValue}YY";
                        break;
                    case 9:
                        InputBox.Text = $"{returnValue}Y";
                        break;
                    case 10:
                        InputBox.Text = $"{returnValue}";
                        break;
                    default:
                        InputBox.Text = InputBox.Text.Remove(InputBox.Text.Length - 1, 1);
                        break;
                }
            }
            else
            {
                DisplayResult.Text = "Invalid Character";
                
            }


        }
    }
}