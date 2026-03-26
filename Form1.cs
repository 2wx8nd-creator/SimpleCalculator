using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

            this.ActiveControl = Inputbox;
            Inputbox.Focus();

            Inputbox.KeyDown += Inputbox_KeyDown;
            Inputbox.KeyPress += Inputbox_KeyPress;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            SetDefaultAnswer();
            Inputbox.Focus();
        }

        private void SetDefaultAnswer()
        {
            Answerbox.Items.Clear();
            Answerbox.Items.Add("0");
        }

        private void Inputbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            bool isValid = char.IsDigit(c) ||
                           "+-*/.()[]{}".Contains(c) ||
                           c == (char)Keys.Back ||
                           c == (char)Keys.Enter;

            if (!isValid)
            {
                e.Handled = true;
            }
        }

        private void Inputbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Equalbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(Inputbox.Text))
            {
                Delbtn.PerformClick();
            }
        }

        private void Answerbox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void AddToInput(string value)
        {
            Inputbox.Text += value;
            Inputbox.SelectionStart = Inputbox.Text.Length;
            Inputbox.Focus();
        }

        private void Num1btn_Click(object sender, EventArgs e) => AddToInput("1");
        private void Num2btn_Click(object sender, EventArgs e) => AddToInput("2");
        private void Num3btn_Click(object sender, EventArgs e) => AddToInput("3");
        private void Num4btn_Click(object sender, EventArgs e) => AddToInput("4");
        private void Num5btn_Click(object sender, EventArgs e) => AddToInput("5");
        private void Num6btn_Click(object sender, EventArgs e) => AddToInput("6");
        private void Num7btn_Click(object sender, EventArgs e) => AddToInput("7");
        private void Num8btn_Click(object sender, EventArgs e) => AddToInput("8");
        private void Num9btn_Click(object sender, EventArgs e) => AddToInput("9");
        private void Num0btn_Click(object sender, EventArgs e) => AddToInput("0");
        private void Dotbtn_Click(object sender, EventArgs e) => AddToInput(".");
        private void Plusbtn_Click(object sender, EventArgs e) => AddToInput(" + ");
        private void Minusbtn_Click(object sender, EventArgs e) => AddToInput(" - ");
        private void Mulbtn_Click(object sender, EventArgs e) => AddToInput(" × ");
        private void Divbtn_Click(object sender, EventArgs e) => AddToInput(" ÷ ");

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Inputbox.Clear();
            SetDefaultAnswer();
            Inputbox.Focus();
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            string text = Inputbox.Text.TrimEnd();
            if (string.IsNullOrEmpty(text)) return;

            int lastSpace = text.LastIndexOf(' ');
            Inputbox.Text = lastSpace != -1 ? text.Substring(0, lastSpace + 1) : "";
            Inputbox.Focus();
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (Inputbox.Text.Length > 0)
                Inputbox.Text = Inputbox.Text.Remove(Inputbox.Text.Length - 1);

            if (Answerbox.Items.Count > 0) SetDefaultAnswer();
            Inputbox.Focus();
        }

        private void PlusMinusbtn_Click(object sender, EventArgs e)
        {
            string text = Inputbox.Text;
            if (string.IsNullOrWhiteSpace(text)) return;

            var match = Regex.Match(text, @"(\s[+\-×÷]\s)?(\(?\-?\d+\.?\d*\)?)$");
            if (!match.Success) return;

            string op = match.Groups[1].Value.Trim();
            string number = match.Groups[2].Value;
            string baseText = text.Substring(0, match.Index);

            if (op == "+")
                Inputbox.Text = baseText + " - " + number;
            else if (op == "-")
                Inputbox.Text = baseText + " + " + number;
            else if (op == "×" || op == "÷" || string.IsNullOrEmpty(op))
            {
                if (number.StartsWith("(-") && number.EndsWith(")"))
                    Inputbox.Text = baseText + (string.IsNullOrEmpty(op) ? "" : $" {op} ") + number.Substring(2, number.Length - 3);
                else
                    Inputbox.Text = baseText + (string.IsNullOrEmpty(op) ? "" : $" {op} ") + $"(-{number})";
            }
            Inputbox.Focus();
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = Inputbox.Text;
                string internalExpression = expression.Replace("×", "*").Replace("÷", "/");

                DataTable dt = new DataTable();
                var result = dt.Compute(internalExpression, "");

                Inputbox.Text = $"{expression} = {result}";
                Answerbox.Items.Clear();
                Answerbox.Items.Add(result.ToString());
            }
            catch { MessageBox.Show("수식이 올바르지 않습니다."); }
            Inputbox.Focus();
        }

        private void Inputbox_TextChanged(object sender, EventArgs e) { }
    }
}