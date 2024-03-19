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
            _Enter = new Button();
            _operation_add = new Button();
            _operation_sub = new Button();
            _operation_multi = new Button();
            _operation_div = new Button();
            _digit_decPoint = new Button();
            _digit_0 = new Button();
            _digit_9 = new Button();
            _digit_8 = new Button();
            _digit_7 = new Button();
            _digit_6 = new Button();
            _digit_5 = new Button();
            _digit_4 = new Button();
            _digit_3 = new Button();
            _digit_2 = new Button();
            _digit_1 = new Button();
            _control_ce = new Button();
            Input = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Output
            // 
            Output.BorderStyle = BorderStyle.None;
            Output.Font = new Font("Unispace", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Output.Location = new Point(86, 62);
            Output.Name = "Output";
            Output.Size = new Size(443, 55);
            Output.TabIndex = 0;
            Output.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(_Enter);
            panel1.Controls.Add(_operation_add);
            panel1.Controls.Add(_operation_sub);
            panel1.Controls.Add(_operation_multi);
            panel1.Controls.Add(_operation_div);
            panel1.Controls.Add(_digit_decPoint);
            panel1.Controls.Add(_digit_0);
            panel1.Controls.Add(_digit_9);
            panel1.Controls.Add(_digit_8);
            panel1.Controls.Add(_digit_7);
            panel1.Controls.Add(_digit_6);
            panel1.Controls.Add(_digit_5);
            panel1.Controls.Add(_digit_4);
            panel1.Controls.Add(_digit_3);
            panel1.Controls.Add(_digit_2);
            panel1.Controls.Add(_digit_1);
            panel1.Location = new Point(36, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 461);
            panel1.TabIndex = 1;
            // 
            // _Enter
            // 
            _Enter.Location = new Point(402, 362);
            _Enter.Name = "_Enter";
            _Enter.Size = new Size(127, 82);
            _Enter.TabIndex = 15;
            _Enter.Text = "ENTR";
            _Enter.UseVisualStyleBackColor = true;
            _Enter.Click += _Enter_Click;
            // 
            // _operation_add
            // 
            _operation_add.Location = new Point(402, 274);
            _operation_add.Name = "_operation_add";
            _operation_add.Size = new Size(127, 82);
            _operation_add.TabIndex = 14;
            _operation_add.Text = "+";
            _operation_add.UseVisualStyleBackColor = true;
            _operation_add.Click += _operation_add_Click;
            // 
            // _operation_sub
            // 
            _operation_sub.Location = new Point(402, 186);
            _operation_sub.Name = "_operation_sub";
            _operation_sub.Size = new Size(127, 82);
            _operation_sub.TabIndex = 12;
            _operation_sub.Text = "-";
            _operation_sub.UseVisualStyleBackColor = true;
            _operation_sub.Click += _operation_sub_Click;
            // 
            // _operation_multi
            // 
            _operation_multi.Location = new Point(402, 98);
            _operation_multi.Name = "_operation_multi";
            _operation_multi.Size = new Size(127, 82);
            _operation_multi.TabIndex = 13;
            _operation_multi.Text = "x";
            _operation_multi.UseVisualStyleBackColor = true;
            _operation_multi.Click += _operation_multi_Click;
            // 
            // _operation_div
            // 
            _operation_div.Location = new Point(402, 10);
            _operation_div.Name = "_operation_div";
            _operation_div.Size = new Size(127, 82);
            _operation_div.TabIndex = 12;
            _operation_div.Text = "/";
            _operation_div.UseVisualStyleBackColor = true;
            _operation_div.Click += _operation_div_Click;
            // 
            // _digit_decPoint
            // 
            _digit_decPoint.Location = new Point(269, 362);
            _digit_decPoint.Name = "_digit_decPoint";
            _digit_decPoint.Size = new Size(127, 82);
            _digit_decPoint.TabIndex = 10;
            _digit_decPoint.Text = ".";
            _digit_decPoint.UseVisualStyleBackColor = true;
            _digit_decPoint.Click += _digit_decPoint_Click;
            // 
            // _digit_0
            // 
            _digit_0.Location = new Point(136, 362);
            _digit_0.Name = "_digit_0";
            _digit_0.Size = new Size(127, 82);
            _digit_0.TabIndex = 9;
            _digit_0.Text = "0";
            _digit_0.UseVisualStyleBackColor = true;
            _digit_0.Click += _digit_0_Click;
            // 
            // _digit_9
            // 
            _digit_9.Location = new Point(269, 98);
            _digit_9.Name = "_digit_9";
            _digit_9.Size = new Size(127, 82);
            _digit_9.TabIndex = 8;
            _digit_9.Text = "9";
            _digit_9.UseVisualStyleBackColor = true;
            _digit_9.Click += _digit_9_Click;
            // 
            // _digit_8
            // 
            _digit_8.Location = new Point(136, 98);
            _digit_8.Name = "_digit_8";
            _digit_8.Size = new Size(127, 82);
            _digit_8.TabIndex = 7;
            _digit_8.Text = "8";
            _digit_8.UseVisualStyleBackColor = true;
            _digit_8.Click += _digit_8_Click;
            // 
            // _digit_7
            // 
            _digit_7.Location = new Point(3, 98);
            _digit_7.Name = "_digit_7";
            _digit_7.Size = new Size(127, 82);
            _digit_7.TabIndex = 6;
            _digit_7.Text = "7";
            _digit_7.UseVisualStyleBackColor = true;
            _digit_7.Click += _digit_7_Click;
            // 
            // _digit_6
            // 
            _digit_6.Location = new Point(269, 186);
            _digit_6.Name = "_digit_6";
            _digit_6.Size = new Size(127, 82);
            _digit_6.TabIndex = 5;
            _digit_6.Text = "6";
            _digit_6.UseVisualStyleBackColor = true;
            _digit_6.Click += _digit_6_Click;
            // 
            // _digit_5
            // 
            _digit_5.Location = new Point(136, 186);
            _digit_5.Name = "_digit_5";
            _digit_5.Size = new Size(127, 82);
            _digit_5.TabIndex = 4;
            _digit_5.Text = "5";
            _digit_5.UseVisualStyleBackColor = true;
            _digit_5.Click += _digit_5_Click;
            // 
            // _digit_4
            // 
            _digit_4.Location = new Point(3, 186);
            _digit_4.Name = "_digit_4";
            _digit_4.Size = new Size(127, 82);
            _digit_4.TabIndex = 3;
            _digit_4.Text = "4";
            _digit_4.UseVisualStyleBackColor = true;
            _digit_4.Click += _digit_4_Click;
            // 
            // _digit_3
            // 
            _digit_3.Location = new Point(269, 274);
            _digit_3.Name = "_digit_3";
            _digit_3.Size = new Size(127, 82);
            _digit_3.TabIndex = 2;
            _digit_3.Text = "3";
            _digit_3.UseVisualStyleBackColor = true;
            _digit_3.Click += _digit_3_Click;
            // 
            // _digit_2
            // 
            _digit_2.Location = new Point(136, 274);
            _digit_2.Name = "_digit_2";
            _digit_2.Size = new Size(127, 82);
            _digit_2.TabIndex = 1;
            _digit_2.Text = "2";
            _digit_2.UseVisualStyleBackColor = true;
            _digit_2.Click += _digit_2_Click;
            // 
            // _digit_1
            // 
            _digit_1.Location = new Point(3, 274);
            _digit_1.Name = "_digit_1";
            _digit_1.Size = new Size(127, 82);
            _digit_1.TabIndex = 0;
            _digit_1.Text = "1";
            _digit_1.UseVisualStyleBackColor = true;
            _digit_1.Click += _digit_1_Click;
            // 
            // _control_ce
            // 
            _control_ce.Location = new Point(551, 24);
            _control_ce.Name = "_control_ce";
            _control_ce.Size = new Size(127, 82);
            _control_ce.TabIndex = 11;
            _control_ce.Text = "CE";
            _control_ce.UseVisualStyleBackColor = true;
            _control_ce.Click += _control_ce_Click;
            // 
            // Input
            // 
            Input.BorderStyle = BorderStyle.None;
            Input.Font = new Font("Unispace", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Input.Location = new Point(86, 12);
            Input.Name = "Input";
            Input.Size = new Size(443, 54);
            Input.TabIndex = 12;
            Input.Text = "";
            Input.TextChanged += Input_TextChanged;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 609);
            Controls.Add(Input);
            Controls.Add(panel1);
            Controls.Add(_control_ce);
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
    }
}
