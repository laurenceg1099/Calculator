namespace Calculator.UI
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
            Output = new RichTextBox();
            panel1 = new Panel();
            Left_bracket = new Button();
            Right_bracket = new Button();
            Shift = new Button();
            _Enter = new Button();
            _control_ce = new Button();
            _digit_7 = new Button();
            _operation_add = new Button();
            _operation_sub = new Button();
            _operation_multi = new Button();
            _operation_div = new Button();
            _digit_decPoint = new Button();
            _digit_0 = new Button();
            _digit_9 = new Button();
            _digit_8 = new Button();
            _digit_6 = new Button();
            _digit_5 = new Button();
            _digit_4 = new Button();
            _digit_3 = new Button();
            _digit_2 = new Button();
            _digit_1 = new Button();
            Input = new RichTextBox();
            Ans = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Output
            // 
            Output.BackColor = Color.White;
            Output.BorderStyle = BorderStyle.FixedSingle;
            Output.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Output.ForeColor = SystemColors.ControlText;
            Output.Location = new Point(4, 53);
            Output.Name = "Output";
            Output.ReadOnly = true;
            Output.RightToLeft = RightToLeft.No;
            Output.Size = new Size(532, 74);
            Output.TabIndex = 0;
            Output.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(Ans);
            panel1.Controls.Add(Left_bracket);
            panel1.Controls.Add(Right_bracket);
            panel1.Controls.Add(Shift);
            panel1.Controls.Add(_Enter);
            panel1.Controls.Add(_control_ce);
            panel1.Controls.Add(_digit_7);
            panel1.Controls.Add(_operation_add);
            panel1.Controls.Add(_operation_sub);
            panel1.Controls.Add(_operation_multi);
            panel1.Controls.Add(_operation_div);
            panel1.Controls.Add(_digit_decPoint);
            panel1.Controls.Add(_digit_0);
            panel1.Controls.Add(_digit_9);
            panel1.Controls.Add(_digit_8);
            panel1.Controls.Add(_digit_6);
            panel1.Controls.Add(_digit_5);
            panel1.Controls.Add(_digit_4);
            panel1.Controls.Add(_digit_3);
            panel1.Controls.Add(_digit_2);
            panel1.Controls.Add(_digit_1);
            panel1.Location = new Point(4, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 650);
            panel1.TabIndex = 1;
            // 
            // Left_bracket
            // 
            Left_bracket.BackColor = Color.DimGray;
            Left_bracket.Font = new Font("Segoe UI", 18F);
            Left_bracket.ForeColor = Color.Gold;
            Left_bracket.Location = new Point(0, 430);
            Left_bracket.Margin = new Padding(2);
            Left_bracket.Name = "Left_bracket";
            Left_bracket.Size = new Size(127, 82);
            Left_bracket.TabIndex = 19;
            Left_bracket.Text = "(";
            Left_bracket.UseVisualStyleBackColor = false;
            Left_bracket.Click += Left_bracket_Click;
            // 
            // Right_bracket
            // 
            Right_bracket.BackColor = Color.DimGray;
            Right_bracket.Font = new Font("Segoe UI", 18F);
            Right_bracket.ForeColor = Color.Gold;
            Right_bracket.Location = new Point(131, 430);
            Right_bracket.Margin = new Padding(2);
            Right_bracket.Name = "Right_bracket";
            Right_bracket.Size = new Size(127, 82);
            Right_bracket.TabIndex = 18;
            Right_bracket.Text = ")";
            Right_bracket.UseVisualStyleBackColor = false;
            Right_bracket.Click += Right_bracket_Click;
            // 
            // Shift
            // 
            Shift.BackColor = Color.Gold;
            Shift.Location = new Point(0, 0);
            Shift.Margin = new Padding(2);
            Shift.Name = "Shift";
            Shift.Size = new Size(127, 82);
            Shift.TabIndex = 16;
            Shift.Text = "Shift";
            Shift.UseVisualStyleBackColor = false;
            Shift.Click += Shift_Click;
            // 
            // _Enter
            // 
            _Enter.BackColor = Color.DimGray;
            _Enter.Font = new Font("Segoe UI", 18F);
            _Enter.ForeColor = Color.Gold;
            _Enter.Location = new Point(262, 344);
            _Enter.Margin = new Padding(2);
            _Enter.Name = "_Enter";
            _Enter.Size = new Size(127, 82);
            _Enter.TabIndex = 15;
            _Enter.Text = "ENTR";
            _Enter.UseVisualStyleBackColor = false;
            _Enter.Click += _Enter_Click;
            // 
            // _control_ce
            // 
            _control_ce.BackColor = Color.Gold;
            _control_ce.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _control_ce.Location = new Point(393, -1);
            _control_ce.Margin = new Padding(2);
            _control_ce.Name = "_control_ce";
            _control_ce.Size = new Size(127, 82);
            _control_ce.TabIndex = 11;
            _control_ce.Text = "CE";
            _control_ce.UseVisualStyleBackColor = false;
            _control_ce.Click += _control_ce_Click;
            // 
            // _digit_7
            // 
            _digit_7.BackColor = Color.White;
            _digit_7.Font = new Font("Segoe UI", 18F);
            _digit_7.Location = new Point(0, 258);
            _digit_7.Margin = new Padding(2);
            _digit_7.Name = "_digit_7";
            _digit_7.Size = new Size(127, 82);
            _digit_7.TabIndex = 6;
            _digit_7.Text = "7";
            _digit_7.UseVisualStyleBackColor = false;
            _digit_7.Click += _digit_7_Click;
            // 
            // _operation_add
            // 
            _operation_add.BackColor = Color.DimGray;
            _operation_add.Font = new Font("Segoe UI", 18F);
            _operation_add.ForeColor = Color.Gold;
            _operation_add.Location = new Point(393, 86);
            _operation_add.Margin = new Padding(2);
            _operation_add.Name = "_operation_add";
            _operation_add.Size = new Size(127, 82);
            _operation_add.TabIndex = 14;
            _operation_add.Text = "+";
            _operation_add.UseVisualStyleBackColor = false;
            _operation_add.Click += _operation_add_Click;
            // 
            // _operation_sub
            // 
            _operation_sub.BackColor = Color.DimGray;
            _operation_sub.Font = new Font("Segoe UI", 18F);
            _operation_sub.ForeColor = Color.Gold;
            _operation_sub.Location = new Point(393, 172);
            _operation_sub.Margin = new Padding(2);
            _operation_sub.Name = "_operation_sub";
            _operation_sub.Size = new Size(127, 82);
            _operation_sub.TabIndex = 12;
            _operation_sub.Text = "-";
            _operation_sub.UseVisualStyleBackColor = false;
            _operation_sub.Click += _operation_sub_Click;
            // 
            // _operation_multi
            // 
            _operation_multi.BackColor = Color.DimGray;
            _operation_multi.Font = new Font("Segoe UI", 18F);
            _operation_multi.ForeColor = Color.Gold;
            _operation_multi.Location = new Point(393, 258);
            _operation_multi.Margin = new Padding(2);
            _operation_multi.Name = "_operation_multi";
            _operation_multi.Size = new Size(127, 82);
            _operation_multi.TabIndex = 13;
            _operation_multi.Text = "x";
            _operation_multi.UseVisualStyleBackColor = false;
            _operation_multi.Click += _operation_multi_Click;
            // 
            // _operation_div
            // 
            _operation_div.BackColor = Color.DimGray;
            _operation_div.Font = new Font("Segoe UI", 18F);
            _operation_div.ForeColor = Color.Gold;
            _operation_div.Location = new Point(393, 344);
            _operation_div.Margin = new Padding(2);
            _operation_div.Name = "_operation_div";
            _operation_div.Size = new Size(127, 82);
            _operation_div.TabIndex = 12;
            _operation_div.Text = "/";
            _operation_div.UseVisualStyleBackColor = false;
            _operation_div.Click += _operation_div_Click;
            // 
            // _digit_decPoint
            // 
            _digit_decPoint.BackColor = Color.DimGray;
            _digit_decPoint.Font = new Font("Segoe UI", 18F);
            _digit_decPoint.ForeColor = Color.Gold;
            _digit_decPoint.Location = new Point(0, 344);
            _digit_decPoint.Margin = new Padding(2);
            _digit_decPoint.Name = "_digit_decPoint";
            _digit_decPoint.Size = new Size(127, 82);
            _digit_decPoint.TabIndex = 10;
            _digit_decPoint.Text = ".";
            _digit_decPoint.UseVisualStyleBackColor = false;
            _digit_decPoint.Click += _digit_decPoint_Click;
            // 
            // _digit_0
            // 
            _digit_0.BackColor = Color.White;
            _digit_0.Font = new Font("Segoe UI", 18F);
            _digit_0.Location = new Point(131, 344);
            _digit_0.Margin = new Padding(2);
            _digit_0.Name = "_digit_0";
            _digit_0.Size = new Size(127, 82);
            _digit_0.TabIndex = 9;
            _digit_0.Text = "0";
            _digit_0.UseVisualStyleBackColor = false;
            _digit_0.Click += _digit_0_Click;
            // 
            // _digit_9
            // 
            _digit_9.BackColor = Color.White;
            _digit_9.Font = new Font("Segoe UI", 18F);
            _digit_9.Location = new Point(262, 258);
            _digit_9.Margin = new Padding(2);
            _digit_9.Name = "_digit_9";
            _digit_9.Size = new Size(127, 82);
            _digit_9.TabIndex = 8;
            _digit_9.Text = "9";
            _digit_9.UseVisualStyleBackColor = false;
            _digit_9.Click += _digit_9_Click;
            // 
            // _digit_8
            // 
            _digit_8.BackColor = Color.White;
            _digit_8.Font = new Font("Segoe UI", 18F);
            _digit_8.Location = new Point(131, 258);
            _digit_8.Margin = new Padding(2);
            _digit_8.Name = "_digit_8";
            _digit_8.Size = new Size(127, 82);
            _digit_8.TabIndex = 7;
            _digit_8.Text = "8";
            _digit_8.UseVisualStyleBackColor = false;
            _digit_8.Click += _digit_8_Click;
            // 
            // _digit_6
            // 
            _digit_6.BackColor = Color.White;
            _digit_6.Font = new Font("Segoe UI", 18F);
            _digit_6.Location = new Point(262, 172);
            _digit_6.Margin = new Padding(2);
            _digit_6.Name = "_digit_6";
            _digit_6.Size = new Size(127, 82);
            _digit_6.TabIndex = 5;
            _digit_6.Text = "6";
            _digit_6.UseVisualStyleBackColor = false;
            _digit_6.Click += _digit_6_Click;
            // 
            // _digit_5
            // 
            _digit_5.BackColor = Color.White;
            _digit_5.Font = new Font("Segoe UI", 18F);
            _digit_5.Location = new Point(131, 172);
            _digit_5.Margin = new Padding(2);
            _digit_5.Name = "_digit_5";
            _digit_5.Size = new Size(127, 82);
            _digit_5.TabIndex = 4;
            _digit_5.Text = "5";
            _digit_5.UseVisualStyleBackColor = false;
            _digit_5.Click += _digit_5_Click;
            // 
            // _digit_4
            // 
            _digit_4.BackColor = Color.White;
            _digit_4.Font = new Font("Segoe UI", 18F);
            _digit_4.Location = new Point(0, 172);
            _digit_4.Margin = new Padding(2);
            _digit_4.Name = "_digit_4";
            _digit_4.Size = new Size(127, 82);
            _digit_4.TabIndex = 3;
            _digit_4.Text = "4";
            _digit_4.UseVisualStyleBackColor = false;
            _digit_4.Click += _digit_4_Click;
            // 
            // _digit_3
            // 
            _digit_3.BackColor = Color.White;
            _digit_3.Font = new Font("Segoe UI", 18F);
            _digit_3.Location = new Point(262, 86);
            _digit_3.Margin = new Padding(2);
            _digit_3.Name = "_digit_3";
            _digit_3.Size = new Size(127, 82);
            _digit_3.TabIndex = 2;
            _digit_3.Text = "3";
            _digit_3.UseVisualStyleBackColor = false;
            _digit_3.Click += _digit_3_Click;
            // 
            // _digit_2
            // 
            _digit_2.BackColor = Color.White;
            _digit_2.Font = new Font("Segoe UI", 18F);
            _digit_2.Location = new Point(131, 86);
            _digit_2.Margin = new Padding(2);
            _digit_2.Name = "_digit_2";
            _digit_2.Size = new Size(127, 82);
            _digit_2.TabIndex = 1;
            _digit_2.Text = "2";
            _digit_2.UseVisualStyleBackColor = false;
            _digit_2.Click += _digit_2_Click;
            // 
            // _digit_1
            // 
            _digit_1.BackColor = Color.White;
            _digit_1.Font = new Font("Segoe UI", 18F);
            _digit_1.Location = new Point(0, 86);
            _digit_1.Margin = new Padding(2);
            _digit_1.Name = "_digit_1";
            _digit_1.Size = new Size(127, 82);
            _digit_1.TabIndex = 0;
            _digit_1.Text = "1";
            _digit_1.UseVisualStyleBackColor = false;
            _digit_1.Click += _digit_1_Click;
            // 
            // Input
            // 
            Input.BackColor = Color.White;
            Input.BorderStyle = BorderStyle.FixedSingle;
            Input.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input.ForeColor = SystemColors.ControlText;
            Input.Location = new Point(4, 12);
            Input.Name = "Input";
            Input.ReadOnly = true;
            Input.Size = new Size(532, 43);
            Input.TabIndex = 12;
            Input.Text = "";
            // 
            // Ans
            // 
            Ans.BackColor = Color.DimGray;
            Ans.Font = new Font("Segoe UI", 18F);
            Ans.ForeColor = Color.Gold;
            Ans.Location = new Point(262, 430);
            Ans.Margin = new Padding(2);
            Ans.Name = "Ans";
            Ans.Size = new Size(127, 82);
            Ans.TabIndex = 20;
            Ans.Text = "Ans";
            Ans.UseVisualStyleBackColor = false;
            Ans.Click += Ans_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(529, 816);
            Controls.Add(Input);
            Controls.Add(panel1);
            Controls.Add(Output);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox Output;
        private Panel panel1;
        private Button _digit_1;
        private Button _digit_2;
        private Button _digit_3;
        private Button _digit_4;
        private Button _digit_5;
        private Button _digit_6;
        private Button _digit_7;
        private Button _digit_8;
        private Button _digit_0;
        private Button _digit_9;
        private Button _digit_decPoint;
        private Button _control_ce;
        private Button _operation_multi;
        private Button _operation_div;
        private Button _operation_sub;
        private Button _Enter;
        private Button _operation_add;
        private RichTextBox Input;
        private Button Shift;
        private Button Left_bracket;
        private Button Right_bracket;
        private Button Ans;
    }
}
