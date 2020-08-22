using System.Collections.Generic;
using System.Windows.Forms;

namespace buscaminas
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public List<List<System.Windows.Forms.Button>> GenerateButtons(int filas, int columnas)
        {
            this.SuspendLayout();
            var buttons = new List<List<System.Windows.Forms.Button>>();
            var size = 40;
            this.Size = new System.Drawing.Size(size * (filas + 1), size * (columnas + 1));
            for (int i = 0; i < filas; i++)
            {
                var button_list = new List<System.Windows.Forms.Button>();
                for (int j = 0; j < columnas; j++)
                {
                    var button = new System.Windows.Forms.Button();
                    button.Location = new System.Drawing.Point(i * 40, j * 40);
                    button.Size = new System.Drawing.Size(size, size);
                    button.UseVisualStyleBackColor = true;
                    var list = new List<int>();
                    list.Add(i);
                    list.Add(j);
                    button.Tag = list;
                    button.MouseUp += new MouseEventHandler(this.buttonClick);
                    button.Name = "button" + i + "_" + j;
                    this.Controls.Add(button);
                    button_list.Add(button);
                }
                buttons.Add(button_list);
            }
            this.ResumeLayout(true);
            return buttons;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}