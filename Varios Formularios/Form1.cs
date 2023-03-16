using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varios_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (textBoxInserir.Text == "")
            {
                MessageBox.Show("Por favor insira um nome no campo!!!", "Aviso!", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                textBoxInserir.Focus();
                return;
            }
            //else é opicional por causa do Return

            textBoxMultiTexto.Text += textBoxInserir.Text + ", "; // += atribui ou acrescenta 
            textBoxInserir.Clear();
            textBoxInserir.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxMultiTexto.Clear();
            textBoxInserir.Clear();
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBoxMultiTexto.Text);
            form2.ShowDialog();
        }
    }
}
