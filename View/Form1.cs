using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controle;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {   ControleProduto controleProduto;
        
        public Form1()
        {

            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                controleProduto = new ControleProduto(txtNome.Text, txtPreco.Text, txtQuant.Text);

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

                return;
            }


        }

        private void btnDispo_Click(object sender, EventArgs e)
        {
           txtDispo.Text= controleProduto.BuscarProduto();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
           txtTotalEstoque.Text = controleProduto.TotalEstoque();
        }
    }
}
