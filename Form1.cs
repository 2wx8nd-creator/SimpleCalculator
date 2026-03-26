using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // [추가된 부분 1] Designer.cs에서 요구하는 Load 이벤트 메서드
        private void Calculator_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 실행할 내용이 없다면 비워두셔도 됩니다.
        }

        // [추가된 부분 2] Designer.cs에서 요구하는 SelectedIndexChanged 이벤트 메서드
        private void Answerbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트 박스 항목을 선택할 때 실행할 내용이 없다면 비워두셔도 됩니다.
        }

        private void AddToInput(string value)
        {
            Inputbox.Text += value;
        }

        // 숫자 및 연산 버튼
        private void Num1btn_Click(object sender, EventArgs e) => AddToInput("1");
        private void Num2btn_Click(object sender, EventArgs e) => AddToInput("2");
        private void Num3btn_Click(object sender, EventArgs e) => AddToInput("3");
        private void Num4btn_Click(object sender, EventArgs e) => AddToInput("4");
        private void Num5btn_Click(object sender, EventArgs e) => AddToInput("5");
        private void Num6btn_Click(object sender, EventArgs e) => AddToInput("6");
        private void Num8btn_Click(object sender, EventArgs e) => AddToInput("8");
        private void Num9btn_Click(object sender, EventArgs e) => AddToInput("9");
        private void Num0btn_Click(object sender, EventArgs e) => AddToInput("0");
        private void button8_Click(object sender, EventArgs e) => AddToInput("7");
        private void button9_Click(object sender, EventArgs e) => AddToInput(".");
        private void Plusbtn_Click(object sender, EventArgs e) => AddToInput(" + ");
        private void Minusbtn_Click(object sender, EventArgs e) => AddToInput(" - ");
        private void Mulbtn_Click(object sender, EventArgs e) => AddToInput(" × ");
        private void Divbtn_Click(object sender, EventArgs e) => AddToInput(" ÷ ");

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Inputbox.Clear();
            Answerbox.Items.Clear();
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            string text = Inputbox.Text.TrimEnd();
            if (string.IsNullOrEmpty(text)) return;

            int lastSpace = text.LastIndexOf(' ');
            if (lastSpace != -1)
            {
                Inputbox.Text = text.Substring(0, lastSpace + 1);
            }
            else
            {
                Inputbox.Clear();
            }
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (Inputbox.Text.Length > 0)
            {
                Inputbox.Text = Inputbox.Text.Remove(Inputbox.Text.Length - 1);
            }
            Answerbox.Items.Clear();
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = Inputbox.Text;
                string internalExpression = expression.Replace("×", "*").Replace("÷", "/");

                DataTable dt = new DataTable();
                var result = dt.Compute(internalExpression, "");

                Inputbox.Text += " =";
                Answerbox.Items.Add(result.ToString());
            }
            catch
            {
                MessageBox.Show("수식이 올바르지 않습니다.");
            }
        }

        private void PlusMinusbtn_Click(object sender, EventArgs e) { }
        private void Inputbox_TextChanged(object sender, EventArgs e) { }
    }
}