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
        protected ALU1bit alu;

        public Form1(ALU1bit alu)
        {
            this.alu = alu;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool[] a = Conversor.ConvertSringToBool(input_a.Text);
            bool[] b = Conversor.ConvertSringToBool(input_b.Text);
            bool[] f = Conversor.ConvertSringToBool(input_op_code.Text);

            bool cO;

            bool[] res = new bool[1];
            res[0] = alu.Run(a[0], b[0], f[0], f[1], f[2], false, out cO);

            result.Text = Conversor.ConvertBoolToString(res);
        }

    }
}
