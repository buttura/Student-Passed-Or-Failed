using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoAprovadoOuReprovado
{
    public partial class Form1 : Form
    {
        double s = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void CalcularMedia_Click(object sender, EventArgs e)
        {
            s = Convert.ToDouble(Nota1.Text) + Convert.ToDouble(Nota2.Text) + Convert.ToDouble(Nota3.Text);
            if ((s/3) > 30)
            {
                s = 30;
            }
            lblMedia.Text = (s / 3).ToString("F");
            if ((s / 3) < 5) {
                lblSituacao.Text = "REPROVADO";
                lblSituacao.ForeColor = Color.Red;
            } else if ((s / 3) <= 6) {
                lblSituacao.Text = "RECUPERAÇÃO";
                lblSituacao.ForeColor = Color.YellowGreen;
            } else {
                lblSituacao.Text = "APROVADO";
                lblSituacao.ForeColor = Color.Green;
            }
        }
    }
}
