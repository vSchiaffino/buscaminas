using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscaminas
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void EstadoTB(bool estado)
        {
            estado = !estado;
            txtBombas.ReadOnly = estado;
            txtColumnas.ReadOnly = estado;
            txtFilas.ReadOnly = estado;
        }

        private void LlenarTB(string tipo)
        {
            cmdJugar.Enabled = tipo != "personalizado";
            if(tipo == "facil")
            {
                txtColumnas.Text = 8.ToString();
                txtFilas.Text = 8.ToString();
                txtBombas.Text = 10.ToString();
            }
            else if(tipo == "intermedio")
            {
                txtColumnas.Text = 16.ToString();
                txtFilas.Text = 16.ToString();
                txtBombas.Text = 40.ToString();
            }
            else if(tipo == "avanzado")
            {
                txtColumnas.Text = 16.ToString();
                txtFilas.Text = 30.ToString();
                txtBombas.Text = 99.ToString();
            }
            else if (tipo == "personalizado")
            {
                txtColumnas.Text = "";
                txtFilas.Text = "";
                txtBombas.Text = "";
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void rbFacil_CheckedChanged(object sender, EventArgs e)
        {
            EstadoTB(false);
            LlenarTB("facil");
        }

        private void rbIntermedio_CheckedChanged(object sender, EventArgs e)
        {
            EstadoTB(false);
            LlenarTB("intermedio");
        }

        private void rbDificil_CheckedChanged(object sender, EventArgs e)
        {
            EstadoTB(false);
            LlenarTB("avanzado");
        }

        private void rbPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            EstadoTB(true);
            LlenarTB("personalizado");
        }

        private void cmdJugar_Click(object sender, EventArgs e)
        {
            var frm = new frmMain(Convert.ToInt32(txtFilas.Text), Convert.ToInt32(txtColumnas.Text), Convert.ToInt32(txtBombas.Text));
            frm.Show();
            frm.papa = this;
            this.Hide();
        }

        private void txtColumnas_TextChanged(object sender, EventArgs e)
        {
            cmdJugar.Enabled = !(txtColumnas.Text == "" || txtFilas.Text == "" || txtBombas.Text == "");
        }

        private void txtBombas_TextChanged(object sender, EventArgs e)
        {
            cmdJugar.Enabled = !(txtColumnas.Text == "" || txtFilas.Text == "" || txtBombas.Text == "");
        }

        private void txtFilas_TextChanged(object sender, EventArgs e)
        {
            cmdJugar.Enabled = !(txtColumnas.Text == "" || txtFilas.Text == "" || txtBombas.Text == "");
        }
    }
}
