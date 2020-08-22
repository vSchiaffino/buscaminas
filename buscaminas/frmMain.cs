using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buscaminasModel;

namespace buscaminas
{
    public partial class frmMain : Form
    {
        public frmInicio papa;
        int filas, columnas, bombas;
        Model model;
        List<List<Button>> buttons;
        public frmMain(int filas, int columnas, int bombas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.bombas = bombas;
            InitializeComponent();
            buttons = GenerateButtons(filas, columnas);
            model = new Model(filas, columnas, bombas);
            UpdateButtons();
        }

        public void UpdateButtons()
        {
            foreach (List<Button> list_botones in buttons)
            {
                foreach (Button button in list_botones)
                {
                    var model_button = model.GetModelButton((List<int>)button.Tag);
                    if (model_button.isClicked())
                    {
                        button.BackColor = Color.Lime;
                        button.Text = Convert.ToString(model_button.getNumber());
                        if (button.Text == "0")
                        {
                            button.Text = "";
                            button.BackColor = Color.Aqua;
                        }
                    }
                    else if(model_button.isFlagged()){
                        button.BackColor = Color.Orange;
                        int f = model_button.getFlag();
                        if (f == 1 || f == 2)
                        {
                            button.Text = f == 1 ? "F" : "?";
                        }
                    }
                    else
                    {
                        button.BackColor = Color.White;
                        button.Text = "";
                    }
                }
            }
        }

        private void buttonClick(object sender, MouseEventArgs e)
        {
            var res = model.Click((List<int>)(((Button)sender).Tag), e.Button == MouseButtons.Left);
            UpdateButtons();
            DialogResult dr = DialogResult.None;
            if (res == "lose")
            {
                dr = MessageBox.Show("Perdiste! Queres intentar en la misma dificultad?", "Buscaminas - Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            }
            else if (res == "win")
            {
                dr = MessageBox.Show("Ganaste! Queres volver a jugar en la misma dificultad?", "Buscaminas - Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            if(dr == DialogResult.Yes)
            {
                var frm = new frmMain(filas, columnas, bombas);
                frm.papa = this.papa;
                frm.Show();
                Hide();
            }
            else if(dr == DialogResult.No)
            {
                Close();
                papa.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
