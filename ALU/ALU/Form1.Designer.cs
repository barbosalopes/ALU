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
            this.result = new System.Windows.Forms.TextBox();
            this.input_op_code = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tooltip_op_code = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_a
            // 
            this.input_a.Location = new System.Drawing.Point(56, 71);
            this.input_a.Mask = "00000000";
            this.input_a.Name = "input_a";
            this.input_a.Size = new System.Drawing.Size(386, 26);
            this.input_a.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "A (Binary)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B (Binary)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // input_b
            // 
            this.input_b.Location = new System.Drawing.Point(57, 136);
            this.input_b.Mask = "00000000";
            this.input_b.Name = "input_b";
            this.input_b.Size = new System.Drawing.Size(386, 26);
            this.input_b.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(56, 296);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(386, 26);
            this.result.TabIndex = 8;
            // 
            // input_op_code
            // 
            this.input_op_code.Location = new System.Drawing.Point(56, 207);
            this.input_op_code.Mask = "000";
            this.input_op_code.Name = "input_op_code";
            this.input_op_code.Size = new System.Drawing.Size(386, 26);
            this.input_op_code.TabIndex = 10;
            this.tooltip_op_code.SetToolTip(this.input_op_code, "F2 F1 F0 Exit\r\n0   0   0  A AND B\r\n0   0   1  A OR B\r\n0   1   0  A\'\r\n0   1   1  B" +
        "\'\r\n1   0   0  A + B\r\n1   0   1  A - B\r\n1   1   0  –\r\n1   1   1  –");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 184);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 376);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_op_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result);
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
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.MaskedTextBox input_op_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tooltip_op_code;
        private System.Windows.Forms.Label label5;
    }
}

