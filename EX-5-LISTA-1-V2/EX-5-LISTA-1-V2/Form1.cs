using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_5_LISTA_1_V2
{
    public partial class Form1 : Form
    {
        private Conversor conversor = new Conversor();
        public Form1()
        {
            InitializeComponent();
            txt_milha.Text = conversor.getMilha().ToString();
            txt_km.Text = conversor.getKm().ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            conversor.setMilha(double.Parse(txt_milha.Text));
            conversor.calcularKm();
            txt_km.Text = conversor.getKm().ToString();
        }
    }
}
