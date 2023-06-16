using CompraIngresso.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraIngresso.View
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }
        Ingresso ingresso = new Ingresso();

        private void button1_Click(object sender, EventArgs e)
        {
            int v = Convert.ToInt32(txt_valor.Text);
            int q = Convert.ToInt32(txt_qtd.Text);
            lbl_resultado.Text = ingresso.Calcular(v, q).ToString();
        }
    }
}
