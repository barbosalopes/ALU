using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALU
{
    public partial class Form1 : Form
    {
        protected ALU23bits alu;

        public Form1(ALU23bits alu)
        {
            this.alu = alu;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int bitsAmount = 23;
            bool[] a = Conversor.ConvertSringToBool(Conversor.ConvertDecimalTo(input_a.Text, 2), bitsAmount);
            bool[] b = Conversor.ConvertSringToBool(Conversor.ConvertDecimalTo(input_b.Text, 2), bitsAmount);
            bool[] f = Conversor.ConvertSringToBool(input_op_code.Text, 3);

            bool cO;

            bool[] res = new bool[bitsAmount];
            res = alu.Run(a, b, f[0], f[1], f[2], false, out cO);

            a_binary.Text = Conversor.ConvertBoolToString(a);
            b_binary.Text = Conversor.ConvertBoolToString(b);
            result_binary.Text = Conversor.ConvertBoolToString(res);
            result_decimal.Text = Conversor.ConvertBaseToDecimal(result_binary.Text, 2);
        }
        
    }
}
