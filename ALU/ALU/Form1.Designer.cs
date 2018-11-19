namespace ALU
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input_a = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_b = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result_binary = new System.Windows.Forms.TextBox();
            this.input_op_code = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tooltip_op_code = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.a_binary = new System.Windows.Forms.TextBox();
            this.b_binary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.result_decimal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_a
            // 
            this.input_a.Location = new System.Drawing.Point(54, 28);
            this.input_a.Mask = "0000000000";
            this.input_a.Name = "input_a";
            this.input_a.Size = new System.Drawing.Size(386, 26);
            this.input_a.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "A (Decimal)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B (Decimal)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result (Binary)";
            // 
            // input_b
            // 
            this.input_b.Location = new System.Drawing.Point(55, 151);
            this.input_b.Mask = "00000000";
            this.input_b.Name = "input_b";
            this.input_b.Size = new System.Drawing.Size(386, 26);
            this.input_b.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result_binary
            // 
            this.result_binary.Enabled = false;
            this.result_binary.Location = new System.Drawing.Point(53, 422);
            this.result_binary.Name = "result_binary";
            this.result_binary.Size = new System.Drawing.Size(386, 26);
            this.result_binary.TabIndex = 8;
            // 
            // input_op_code
            // 
            this.input_op_code.Location = new System.Drawing.Point(54, 271);
            this.input_op_code.Mask = "000";
            this.input_op_code.Name = "input_op_code";
            this.input_op_code.Size = new System.Drawing.Size(386, 26);
            this.input_op_code.TabIndex = 9;
            this.tooltip_op_code.SetToolTip(this.input_op_code, "F2 F1 F0 Exit\r\n0   0   0  A AND B\r\n0   0   1  A OR B\r\n0   1   0  A\'\r\n0   1   1  B" +
        "\'\r\n1   0   0  A + B\r\n1   0   1  A - B\r\n1   1   0  –\r\n1   1   1  –");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "OP Code (F2, F1, F0)";
            // 
            // tooltip_op_code
            // 
            this.tooltip_op_code.AutomaticDelay = 0;
            this.tooltip_op_code.AutoPopDelay = 100000;
            this.tooltip_op_code.InitialDelay = 500;
            this.tooltip_op_code.ReshowDelay = 100;
            this.tooltip_op_code.ToolTipTitle = "OP Codes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 200);
            this.label5.TabIndex = 11;
            this.label5.Text = "OP Codes\r\nF2 F1 F0 Exit\r\n0   0   0     A AND B\r\n0   0   1     A OR B\r\n0   1   0  " +
    "   A\'\r\n0   1   1     B\'\r\n1   0   0     A + B\r\n1   0   1     A - B\r\n1   1   0    " +
    " –\r\n1   1   1     –";
            // 
            // a_binary
            // 
            this.a_binary.Enabled = false;
            this.a_binary.Location = new System.Drawing.Point(57, 89);
            this.a_binary.Name = "a_binary";
            this.a_binary.Size = new System.Drawing.Size(386, 26);
            this.a_binary.TabIndex = 12;
            // 
            // b_binary
            // 
            this.b_binary.Enabled = false;
            this.b_binary.Location = new System.Drawing.Point(56, 214);
            this.b_binary.Name = "b_binary";
            this.b_binary.Size = new System.Drawing.Size(386, 26);
            this.b_binary.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "B (Binary)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "A (Binary)";
            // 
            // result_decimal
            // 
            this.result_decimal.Enabled = false;
            this.result_decimal.Location = new System.Drawing.Point(53, 370);
            this.result_decimal.Name = "result_decimal";
            this.result_decimal.Size = new System.Drawing.Size(386, 26);
            this.result_decimal.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Result (Decimal)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 460);
            this.Controls.Add(this.result_decimal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.b_binary);
            this.Controls.Add(this.a_binary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_op_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result_binary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_a);
            this.Name = "Form1";
            this.Text = "ALU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox input_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox input_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result_binary;
        private System.Windows.Forms.MaskedTextBox input_op_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tooltip_op_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox a_binary;
        private System.Windows.Forms.TextBox b_binary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox result_decimal;
        private System.Windows.Forms.Label label8;
    }
}

