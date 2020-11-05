using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaCafe
{
    public partial class frmPrincipal : Form
    {
        Maquina obj = new Maquina();

        public frmPrincipal()
        {
            InitializeComponent();       
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            
            txtSaldo.Text = obj.InsereMoeda(0.00).ToString();
            MessageBox.Show("Moeda rejeitada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = obj.InsereMoeda(0.00).ToString();
            MessageBox.Show("Moeda rejeitada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDez_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = obj.InsereMoeda(0.10).ToString();
        }

        private void btnVinteCinco_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = obj.InsereMoeda(0.25).ToString();
        }

        private void btnCinquenta_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = obj.InsereMoeda(0.50).ToString();
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = obj.InsereMoeda(1.00).ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnCappuccino.Checked)
            {
                if (obj.Saldo >= obj.Cappuccino)
                {
                    txtTroco.Text = obj.Troco(obj.Cappuccino).ToString();
                    txtSaida.Text = "Cappuccino";
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (btnMocha.Checked)
            {
                if (obj.Saldo >= obj.Mocha)
                {
                    txtTroco.Text = obj.Troco(obj.Mocha).ToString();
                    txtSaida.Text = "Mocha";
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (btnLatte.Checked)
            {
                if (obj.Saldo >= obj.Latte)
                {
                    txtTroco.Text = obj.Troco(obj.Latte).ToString();
                    txtSaida.Text = "Café com leite";
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            txtSaldo.Text = obj.Saldo.ToString();            
        }
    }
}
