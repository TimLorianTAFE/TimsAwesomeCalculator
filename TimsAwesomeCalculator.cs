namespace TimsAwesomeCalculator
{
    public partial class TimsAwesomeCalculator : Form
    {
        public TimsAwesomeCalculator()
        {
            InitializeComponent();
            CalculatorTextBox.ReadOnly = true;
            PreviousValueBox.ReadOnly = true;
            OperatorTextBox.ReadOnly = true;
        }
        #region Variable List
        bool decimalPresent = false;
        bool weAreAddingNow = false;
        bool weAreSubtractingNow = false;
        bool weAreMultiplyingNow = false;
        bool weAreDividingNow = false;
        bool operationInProgress = false;
        bool justComputed = false;
        #endregion
        #region Number Inputs
        /// <summary>
        /// 1 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("1");
        }
        /// <summary>
        /// 2 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("2");
        }
        /// <summary>
        /// 3 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("3");
        }
        /// <summary>
        /// 4 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("4");
        }
        /// <summary>
        /// 5 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("5");
        }
        /// <summary>
        /// 6 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("6");
        }
        /// <summary>
        /// 7 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button7_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("7");
        }
        /// <summary>
        /// 8 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("8");
        }
        /// <summary>
        /// 9 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button9_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            CalculatorTextBox.AppendText("9");
        }
        /// <summary>
        /// 0 Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button0_Click(object sender, EventArgs e)
        {
            CheckIfNewCalculation();
            if (CalculatorTextBox.Text != "" || operationInProgress)
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
            CheckIfNewCalculation();
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
        #endregion
        #region Operators and Other Methods
        /// <summary>
        /// Clear Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }
        /// <summary>
        /// Add Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text != "")
            {
                if (operationInProgress)
                {
                    ComputeOperation();
                }
                ResetOperators();
                double savedNumber = ConvertCalculatorTextToDouble();
                PreviousValueBox.Text = savedNumber.ToString();
                OperatorTextBox.Text = "+";
                weAreAddingNow = true;
                operationInProgress = true;
            }
        }
        /// <summary>
        /// Subtract Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text != "")
            {
                if (operationInProgress)
                {
                    ComputeOperation();
                }
                ResetOperators();
                double savedNumber = ConvertCalculatorTextToDouble();
                PreviousValueBox.Text = savedNumber.ToString();
                OperatorTextBox.Text = "-";
                weAreSubtractingNow = true;
                operationInProgress = true;
            }
        }
        /// <summary>
        /// Multiply Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text != "")
            {
                if (operationInProgress)
                {
                    ComputeOperation();
                }
                ResetOperators();
                double savedNumber = ConvertCalculatorTextToDouble();
                PreviousValueBox.Text = savedNumber.ToString();
                OperatorTextBox.Text = "x";
                weAreMultiplyingNow = true;
                operationInProgress = true;
            }
        }
        /// <summary>
        /// Divide Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text != "")
            {
                if (operationInProgress)
                {
                    ComputeOperation();
                }
                ResetOperators();
                double savedNumber = ConvertCalculatorTextToDouble();
                PreviousValueBox.Text = savedNumber.ToString();
                OperatorTextBox.Text = "/";
                weAreDividingNow = true;
                operationInProgress = true;
            }
        }
        /// <summary>
        /// Reset Operators Method
        /// </summary>
        private void ResetOperators()
        {
            decimalPresent = false;
            weAreAddingNow = false;
            weAreSubtractingNow = false;
            weAreMultiplyingNow = false;
            weAreDividingNow = false;
            operationInProgress = false;
            justComputed = false;
        }
        /// <summary>
        /// Clear Method
        /// </summary>
        private void ClearAllText()
        {
            CalculatorTextBox.Clear();
            OperatorTextBox.Clear();
            PreviousValueBox.Clear();
            decimalPresent = false;
            operationInProgress = false;
        }
        /// <summary>
        /// Convert String to Int Method
        /// </summary>
        /// <returns></returns>
        private double ConvertCalculatorTextToDouble()
        {
            string calculatorText = CalculatorTextBox.Text;
            ClearAllText();
            return Convert.ToDouble(calculatorText);
        }
        /// <summary>
        /// Equals Button Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            ComputeOperation();
        }
        /// <summary>
        /// Compute Operation Method
        /// </summary>
        private void ComputeOperation()
        {
            if ((PreviousValueBox.Text != "") && (CalculatorTextBox.Text != ""))
            {
                double firstNumber = Convert.ToDouble(PreviousValueBox.Text);
                double secondNumber = Convert.ToDouble(CalculatorTextBox.Text);
                if (weAreAddingNow)
                {
                    double result = firstNumber + secondNumber;
                    ClearAllText();
                    PreviousValueBox.Clear();
                    OperatorTextBox.Clear();
                    CalculatorTextBox.Text = result.ToString();
                }
                else if (weAreSubtractingNow)
                {
                    double result = firstNumber - secondNumber;
                    ClearAllText();
                    PreviousValueBox.Clear();
                    OperatorTextBox.Clear();
                    CalculatorTextBox.Text = result.ToString();
                }
                else if (weAreMultiplyingNow)
                {
                    double result = firstNumber * secondNumber;
                    ClearAllText();
                    PreviousValueBox.Clear();
                    OperatorTextBox.Clear();
                    CalculatorTextBox.Text = result.ToString();
                }
                else if (weAreDividingNow)
                {
                    double result = firstNumber / secondNumber;
                    ClearAllText();
                    PreviousValueBox.Clear();
                    OperatorTextBox.Clear();
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Undefined");
                    }
                    else
                    {
                        CalculatorTextBox.Text = result.ToString();
                    }
                }
                justComputed = true;
            }
        }
        /// <summary>
        /// Begin New Calculation Method
        /// </summary>
        private void CheckIfNewCalculation()
        {
            if (justComputed)
            {
                ClearAllText();
                justComputed = false;
            }
        }
        #endregion
    }
}
