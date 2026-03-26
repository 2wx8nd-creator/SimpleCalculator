namespace SimpleCalculator
{
    partial class Calculator
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
            Titlelbl = new Label();
            Num1btn = new Button();
            Num3btn = new Button();
            Num2btn = new Button();
            Num4btn = new Button();
            Num5btn = new Button();
            Num6btn = new Button();
            Num9btn = new Button();
            Num8btn = new Button();
            Num7btn = new Button();
            Dotbtn = new Button();
            Num0btn = new Button();
            PlusMinusbtn = new Button();
            Equalbtn = new Button();
            Plusbtn = new Button();
            Minusbtn = new Button();
            Mulbtn = new Button();
            button5 = new Button();
            CEbtn = new Button();
            Cbtn = new Button();
            Delbtn = new Button();
            Answerbox = new ListBox();
            Inputbox = new TextBox();
            SuspendLayout();
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Gray;
            Titlelbl.Font = new Font("맑은 고딕", 28F);
            Titlelbl.ForeColor = SystemColors.ButtonFace;
            Titlelbl.Location = new Point(41, 26);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Padding = new Padding(0, 0, 0, 3);
            Titlelbl.Size = new Size(321, 54);
            Titlelbl.TabIndex = 0;
            Titlelbl.Text = "Simple Calculator";
            // 
            // Num1btn
            // 
            Num1btn.Location = new Point(41, 311);
            Num1btn.Name = "Num1btn";
            Num1btn.Size = new Size(77, 54);
            Num1btn.TabIndex = 1;
            Num1btn.Text = "1";
            Num1btn.UseVisualStyleBackColor = true;
            // 
            // Num3btn
            // 
            Num3btn.Location = new Point(207, 311);
            Num3btn.Name = "Num3btn";
            Num3btn.Size = new Size(77, 54);
            Num3btn.TabIndex = 2;
            Num3btn.Text = "3";
            Num3btn.UseVisualStyleBackColor = true;
            Num3btn.Click += button1_Click;
            // 
            // Num2btn
            // 
            Num2btn.Location = new Point(124, 311);
            Num2btn.Name = "Num2btn";
            Num2btn.Size = new Size(77, 54);
            Num2btn.TabIndex = 3;
            Num2btn.Text = "2";
            Num2btn.UseVisualStyleBackColor = true;
            // 
            // Num4btn
            // 
            Num4btn.Location = new Point(41, 371);
            Num4btn.Name = "Num4btn";
            Num4btn.Size = new Size(77, 54);
            Num4btn.TabIndex = 4;
            Num4btn.Text = "4";
            Num4btn.UseVisualStyleBackColor = true;
            // 
            // Num5btn
            // 
            Num5btn.Location = new Point(124, 371);
            Num5btn.Name = "Num5btn";
            Num5btn.Size = new Size(77, 54);
            Num5btn.TabIndex = 5;
            Num5btn.Text = "5";
            Num5btn.UseVisualStyleBackColor = true;
            Num5btn.Click += Num5btn_Click;
            // 
            // Num6btn
            // 
            Num6btn.Location = new Point(207, 371);
            Num6btn.Name = "Num6btn";
            Num6btn.Size = new Size(77, 54);
            Num6btn.TabIndex = 6;
            Num6btn.Text = "6";
            Num6btn.UseVisualStyleBackColor = true;
            Num6btn.Click += Num6btn_Click;
            // 
            // Num9btn
            // 
            Num9btn.Location = new Point(207, 431);
            Num9btn.Name = "Num9btn";
            Num9btn.Size = new Size(77, 54);
            Num9btn.TabIndex = 7;
            Num9btn.Text = "9";
            Num9btn.UseVisualStyleBackColor = true;
            // 
            // Num8btn
            // 
            Num8btn.Location = new Point(124, 431);
            Num8btn.Name = "Num8btn";
            Num8btn.Size = new Size(77, 54);
            Num8btn.TabIndex = 8;
            Num8btn.Text = "8";
            Num8btn.UseVisualStyleBackColor = true;
            // 
            // Num7btn
            // 
            Num7btn.Location = new Point(41, 431);
            Num7btn.Name = "Num7btn";
            Num7btn.Size = new Size(77, 54);
            Num7btn.TabIndex = 9;
            Num7btn.Text = "7";
            Num7btn.UseVisualStyleBackColor = true;
            Num7btn.Click += button8_Click;
            // 
            // Dotbtn
            // 
            Dotbtn.Font = new Font("맑은 고딕", 18F);
            Dotbtn.Location = new Point(207, 491);
            Dotbtn.Name = "Dotbtn";
            Dotbtn.Size = new Size(77, 54);
            Dotbtn.TabIndex = 10;
            Dotbtn.Text = ".";
            Dotbtn.UseVisualStyleBackColor = true;
            Dotbtn.Click += button9_Click;
            // 
            // Num0btn
            // 
            Num0btn.Location = new Point(124, 491);
            Num0btn.Name = "Num0btn";
            Num0btn.Size = new Size(77, 54);
            Num0btn.TabIndex = 11;
            Num0btn.Text = "0";
            Num0btn.UseVisualStyleBackColor = true;
            // 
            // PlusMinusbtn
            // 
            PlusMinusbtn.Location = new Point(41, 491);
            PlusMinusbtn.Name = "PlusMinusbtn";
            PlusMinusbtn.Size = new Size(77, 54);
            PlusMinusbtn.TabIndex = 12;
            PlusMinusbtn.Text = "+/-";
            PlusMinusbtn.UseVisualStyleBackColor = true;
            // 
            // Equalbtn
            // 
            Equalbtn.Location = new Point(290, 491);
            Equalbtn.Name = "Equalbtn";
            Equalbtn.Size = new Size(77, 54);
            Equalbtn.TabIndex = 16;
            Equalbtn.Text = "=";
            Equalbtn.UseVisualStyleBackColor = true;
            // 
            // Plusbtn
            // 
            Plusbtn.Location = new Point(290, 431);
            Plusbtn.Name = "Plusbtn";
            Plusbtn.Size = new Size(77, 54);
            Plusbtn.TabIndex = 15;
            Plusbtn.Text = "+";
            Plusbtn.UseVisualStyleBackColor = true;
            // 
            // Minusbtn
            // 
            Minusbtn.Location = new Point(290, 371);
            Minusbtn.Name = "Minusbtn";
            Minusbtn.Size = new Size(77, 54);
            Minusbtn.TabIndex = 14;
            Minusbtn.Text = "-";
            Minusbtn.UseVisualStyleBackColor = true;
            // 
            // Mulbtn
            // 
            Mulbtn.Location = new Point(290, 311);
            Mulbtn.Name = "Mulbtn";
            Mulbtn.Size = new Size(77, 54);
            Mulbtn.TabIndex = 13;
            Mulbtn.Text = "×";
            Mulbtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(290, 251);
            button5.Name = "button5";
            button5.Size = new Size(77, 54);
            button5.TabIndex = 20;
            button5.Text = "÷";
            button5.UseVisualStyleBackColor = true;
            // 
            // CEbtn
            // 
            CEbtn.Location = new Point(41, 251);
            CEbtn.Name = "CEbtn";
            CEbtn.Size = new Size(77, 54);
            CEbtn.TabIndex = 19;
            CEbtn.Text = "CE";
            CEbtn.UseVisualStyleBackColor = true;
            // 
            // Cbtn
            // 
            Cbtn.Location = new Point(124, 251);
            Cbtn.Name = "Cbtn";
            Cbtn.Size = new Size(77, 54);
            Cbtn.TabIndex = 18;
            Cbtn.Text = "C";
            Cbtn.UseVisualStyleBackColor = true;
            // 
            // Delbtn
            // 
            Delbtn.Location = new Point(207, 251);
            Delbtn.Name = "Delbtn";
            Delbtn.Size = new Size(77, 54);
            Delbtn.TabIndex = 17;
            Delbtn.Text = "del";
            Delbtn.UseVisualStyleBackColor = true;
            // 
            // Answerbox
            // 
            Answerbox.FormattingEnabled = true;
            Answerbox.Location = new Point(41, 165);
            Answerbox.Name = "Answerbox";
            Answerbox.Size = new Size(321, 49);
            Answerbox.TabIndex = 21;
            // 
            // Inputbox
            // 
            Inputbox.Location = new Point(41, 110);
            Inputbox.Multiline = true;
            Inputbox.Name = "Inputbox";
            Inputbox.Size = new Size(321, 49);
            Inputbox.TabIndex = 22;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(406, 627);
            Controls.Add(Inputbox);
            Controls.Add(Answerbox);
            Controls.Add(button5);
            Controls.Add(CEbtn);
            Controls.Add(Cbtn);
            Controls.Add(Delbtn);
            Controls.Add(Equalbtn);
            Controls.Add(Plusbtn);
            Controls.Add(Minusbtn);
            Controls.Add(Mulbtn);
            Controls.Add(PlusMinusbtn);
            Controls.Add(Num0btn);
            Controls.Add(Dotbtn);
            Controls.Add(Num7btn);
            Controls.Add(Num8btn);
            Controls.Add(Num9btn);
            Controls.Add(Num6btn);
            Controls.Add(Num5btn);
            Controls.Add(Num4btn);
            Controls.Add(Num2btn);
            Controls.Add(Num3btn);
            Controls.Add(Num1btn);
            Controls.Add(Titlelbl);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titlelbl;
        private Button Num1btn;
        private Button Num3btn;
        private Button Num2btn;
        private Button Num4btn;
        private Button Num5btn;
        private Button Num6btn;
        private Button Num9btn;
        private Button Num8btn;
        private Button Num7btn;
        private Button Dotbtn;
        private Button Num0btn;
        private Button PlusMinusbtn;
        private Button Equalbtn;
        private Button Plusbtn;
        private Button Minusbtn;
        private Button Mulbtn;
        private Button button5;
        private Button CEbtn;
        private Button Cbtn;
        private Button Delbtn;
        private ListBox Answerbox;
        private TextBox Inputbox;
    }
}
