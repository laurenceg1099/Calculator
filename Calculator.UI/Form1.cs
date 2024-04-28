using System.Text;

namespace Calculator.UI
{
    public partial class Calculator : Form
    {
        private StringBuilder _CalcSting = new StringBuilder();
        private bool ShiftClick = false;
        public string _answer;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void _digit_1_Click(object sender, EventArgs e)
        {
            Input.Text += "1";
            _CalcSting.Append("1");
        }

        private void _digit_2_Click(object sender, EventArgs e)
        {
            Input.Text += "2";
            _CalcSting.Append("2");
        }

        private void _digit_3_Click(object sender, EventArgs e)
        {
            Input.Text += "3";
            _CalcSting.Append("3");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void _digit_4_Click(object sender, EventArgs e)
        {
            Input.Text += "4";
            _CalcSting.Append("4");
        }

        private void _digit_5_Click(object sender, EventArgs e)
        {
            Input.Text += "5";
            _CalcSting.Append("5");
        }

        private void _digit_6_Click(object sender, EventArgs e)
        {
            Input.Text += "6";
            _CalcSting.Append("6");
        }

        private void _digit_7_Click(object sender, EventArgs e)
        {
            Input.Text += "7";
            _CalcSting.Append("7");
        }

        private void _digit_8_Click(object sender, EventArgs e)
        {
            Input.Text += "8";
            _CalcSting.Append("8");
        }

        private void _digit_9_Click(object sender, EventArgs e)
        {
            Input.Text += "9";
            _CalcSting.Append("9");
        }

        private void _digit_0_Click(object sender, EventArgs e)
        {
            Input.Text += "0";
            _CalcSting.Append("0");
        }

        private void _digit_decPoint_Click(object sender, EventArgs e)
        {
            Input.Text += ".";
            _CalcSting.Append(".");
        }

        private void _operation_sub_Click(object sender, EventArgs e)
        {
            Input.Text += "-";
            _CalcSting.Append("-");
        }

        private void _operation_div_Click(object sender, EventArgs e)
        {
            Input.Text += "/";
            _CalcSting.Append("/");
        }

        private void _operation_multi_Click(object sender, EventArgs e)
        {
            Input.Text += "x";
            _CalcSting.Append("*");
        }

        private void _operation_add_Click(object sender, EventArgs e)
        {
            Input.Text += "+";
            _CalcSting.Append("+");
        }

        private void _Enter_Click(object sender, EventArgs e)
        {
            try
            {
                var outputCalculate = global::Calculator.Calculator.Calculate(_CalcSting.ToString()).ToString();
                Output.Text = outputCalculate;
                _CalcSting.Clear();
                _CalcSting.Append(outputCalculate);
                _answer = Output.Text;
            }

            catch
            {
                Output.Text = "ERROR";
                _CalcSting.Clear();
            }

        }



        private void _control_ce_Click(object sender, EventArgs e)
        {

            Output.Text = "";
            Input.Text = "";
            _CalcSting.Clear();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shift_Click(object sender, EventArgs e)
        {
            if (ShiftClick == true)
                ShiftClick = false;
            else ShiftClick = true;
        }

        private void Left_bracket_Click(object sender, EventArgs e)
        {
            Input.Text += "(";
            _CalcSting.Append("(");
        }

        private void Right_bracket_Click(object sender, EventArgs e)
        {
            Input.Text += ")";
            _CalcSting.Append(")");
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            Input.Text += "Ans";
            ; _CalcSting.Append(_answer);
        }

        private void Power_Click(object sender, EventArgs e)
        {
            Input.Text += "^";
            _CalcSting.Append("^");
        }

        private void pi_Click(object sender, EventArgs e)
        {
            Input.Text += "pi";
            _CalcSting.Append(Math.PI.ToString());
        }

        private void e_Click(object sender, EventArgs e)
        {
            Input.Text += "e";
            _CalcSting.Append(Math.E.ToString());
        }
    }
}
