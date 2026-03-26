using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void AddToInput(string value)
        {
            Inputbox.Text += value;
        }

        // 숫자 버튼들
        private void Num1btn_Click(object sender, EventArgs e) => AddToInput("1");
        private void Num2btn_Click(object sender, EventArgs e) => AddToInput("2");
        private void Num3btn_Click(object sender, EventArgs e) => AddToInput("3");
        private void Num4btn_Click(object sender, EventArgs e) => AddToInput("4");
        private void Num5btn_Click(object sender, EventArgs e) => AddToInput("5");
        private void Num6btn_Click(object sender, EventArgs e) => AddToInput("6");
        private void Num8btn_Click(object sender, EventArgs e) => AddToInput("8");
        private void Num9btn_Click(object sender, EventArgs e) => AddToInput("9");
        private void Num0btn_Click(object sender, EventArgs e) => AddToInput("0");

        private void button8_Click(object sender, EventArgs e) => AddToInput("7"); // 7번
        private void button9_Click(object sender, EventArgs e) => AddToInput("."); // 점

        // 연산 기호
        private void Plusbtn_Click(object sender, EventArgs e) => AddToInput(" + ");
        private void Minusbtn_Click(object sender, EventArgs e) => AddToInput(" - ");
        private void Mulbtn_Click(object sender, EventArgs e) => AddToInput(" × ");
        private void Divbtn_Click(object sender, EventArgs e) => AddToInput(" ÷ ");

        // 기능 버튼
        private void Cbtn_Click(object sender, EventArgs e) => Inputbox.Clear();
        private void CEbtn_Click(object sender, EventArgs e) => Inputbox.Clear();

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (Inputbox.Text.Length > 0)
            {
                // 공백이 있다면 공백까지 포함해서 지우기 위해 TrimEnd 후 Substring 사용
                string currentText = Inputbox.Text.TrimEnd();
                if (currentText.Length > 0)
                {
                    Inputbox.Text = currentText.Substring(0, currentText.Length - 1);
                }
            }
        }

        // 등호 버튼: 요구사항 반영
        private void Equalbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = Inputbox.Text;

                // 1. 계산을 위해 기호 변환
                string internalExpression = expression.Replace("×", "*").Replace("÷", "/");

                // 2. 실제 연산 수행
                DataTable dt = new DataTable();
                var result = dt.Compute(internalExpression, "");

                // 3. [요구사항] 텍스트 박스에는 등호까지만 표시
                Inputbox.Text += " =";

                // 4. [요구사항] 리스트 박스에는 결과값만 출력
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