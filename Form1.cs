namespace TimsAwesomeCalculator
{
    public partial class TimsAwesomeCalculator : Form
    {
        public TimsAwesomeCalculator()
        {
            InitializeComponent();
            CalculatorTextBox.ReadOnly = true;
        }
        #region Variable List
        bool decimalPresent = false;
        bool weAreAddingNow = false;
        #endregion
        /// <summary>
        /// 1 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("1");
        }
        /// <summary>
        /// Clear Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearTextCalculatorText();
            OperatorTextBox.Clear();
            PreviousValueBox.Clear();
        }
        /// <summary>
        /// 2 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("2");
        }
        /// <summary>
        /// 3 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("3");
        }
        /// <summary>
        /// 4 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("4");
        }
        /// <summary>
        /// 5 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("5");
        }
        /// <summary>
        /// 6 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("6");
        }
        /// <summary>
        /// 7 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button7_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("7");
        }
        /// <summary>
        /// 8 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("8");
        }
        /// <summary>
        /// 9 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button9_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.AppendText("9");
        }
        /// <summary>
        /// 0 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button0_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text != "")
            {
                CalculatorTextBox.AppendText("0");
            }
        }
        /// <summary>
        /// Decimal Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            if (!decimalPresent)
            {
                if (CalculatorTextBox.Text == "")
                {
                    CalculatorTextBox.AppendText("0.");
                }
                else
                {
                    CalculatorTextBox.AppendText(".");
                }
                decimalPresent = true;
            }
        }
        /// <summary>
        /// Add Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            double savedNumber = ConvertCalculatorTextToDouble();
            PreviousValueBox.Text = savedNumber.ToString();
            OperatorTextBox.Text = "+";
            weAreAddingNow = true;
        }
        /// <summary>
        /// Clear Method
        /// </summary>
        private void ClearTextCalculatorText()
        {
            CalculatorTextBox.Clear();
            decimalPresent = false;
        }
        /// <summary>
        /// Convert String to Int Method
        /// </summary>
        /// <returns></returns>
        private double ConvertCalculatorTextToDouble()
        {
            string calculatorText = CalculatorTextBox.Text;
            ClearTextCalculatorText();
            return Convert.ToDouble(calculatorText);
        }
        /// <summary>
        /// Equals Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            int firstNumber = Int32.Parse(PreviousValueBox.Text);
            int secondNumber = Int32.Parse(CalculatorTextBox.Text);
            if (weAreAddingNow)
            {
                int result = firstNumber + secondNumber;
                ClearTextCalculatorText();
                PreviousValueBox.Clear();
                OperatorTextBox.Clear();
                CalculatorTextBox.Text = result.ToString();
            }
        }
    }
}
