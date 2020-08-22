namespace buscaminas
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbDificil = new System.Windows.Forms.RadioButton();
            this.rbPersonalizado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtBombas = new System.Windows.Forms.TextBox();
            this.cmdJugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Location = new System.Drawing.Point(33, 12);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(47, 17);
            this.rbFacil.TabIndex = 0;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Facil";
            this.rbFacil.UseVisualStyleBackColor = true;
            this.rbFacil.CheckedChanged += new System.EventHandler(this.rbFacil_CheckedChanged);
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Location = new System.Drawing.Point(85, 12);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(74, 17);
            this.rbIntermedio.TabIndex = 1;
            this.rbIntermedio.TabStop = true;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            this.rbIntermedio.CheckedChanged += new System.EventHandler(this.rbIntermedio_CheckedChanged);
            // 
            // rbDificil
            // 
            this.rbDificil.AutoSize = true;
            this.rbDificil.Location = new System.Drawing.Point(164, 12);
            this.rbDificil.Name = "rbDificil";
            this.rbDificil.Size = new System.Drawing.Size(50, 17);
            this.rbDificil.TabIndex = 2;
            this.rbDificil.TabStop = true;
            this.rbDificil.Text = "Dificil";
            this.rbDificil.UseVisualStyleBackColor = true;
            this.rbDificil.CheckedChanged += new System.EventHandler(this.rbDificil_CheckedChanged);
            // 
            // rbPersonalizado
            // 
            this.rbPersonalizado.AutoSize = true;
            this.rbPersonalizado.Location = new System.Drawing.Point(219, 12);
            this.rbPersonalizado.Name = "rbPersonalizado";
            this.rbPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.rbPersonalizado.TabIndex = 3;
            this.rbPersonalizado.TabStop = true;
            this.rbPersonalizado.Text = "Personalizado";
            this.rbPersonalizado.UseVisualStyleBackColor = true;
            this.rbPersonalizado.CheckedChanged += new System.EventHandler(this.rbPersonalizado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bombas";
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(138, 49);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.ReadOnly = true;
            this.txtFilas.Size = new System.Drawing.Size(129, 20);
            this.txtFilas.TabIndex = 7;
            this.txtFilas.TextChanged += new System.EventHandler(this.txtFilas_TextChanged);
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(138, 78);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.ReadOnly = true;
            this.txtColumnas.Size = new System.Drawing.Size(129, 20);
            this.txtColumnas.TabIndex = 8;
            this.txtColumnas.TextChanged += new System.EventHandler(this.txtColumnas_TextChanged);
            // 
            // txtBombas
            // 
            this.txtBombas.Location = new System.Drawing.Point(138, 107);
            this.txtBombas.Name = "txtBombas";
            this.txtBombas.ReadOnly = true;
            this.txtBombas.Size = new System.Drawing.Size(129, 20);
            this.txtBombas.TabIndex = 9;
            this.txtBombas.TextChanged += new System.EventHandler(this.txtBombas_TextChanged);
            // 
            // cmdJugar
            // 
            this.cmdJugar.Enabled = false;
            this.cmdJugar.Location = new System.Drawing.Point(134, 136);
            this.cmdJugar.Name = "cmdJugar";
            this.cmdJugar.Size = new System.Drawing.Size(75, 28);
            this.cmdJugar.TabIndex = 10;
            this.cmdJugar.Text = "Jugar!";
            this.cmdJugar.UseVisualStyleBackColor = true;
            this.cmdJugar.Click += new System.EventHandler(this.cmdJugar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 173);
            this.Controls.Add(this.cmdJugar);
            this.Controls.Add(this.txtBombas);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPersonalizado);
            this.Controls.Add(this.rbDificil);
            this.Controls.Add(this.rbIntermedio);
            this.Controls.Add(this.rbFacil);
            this.Name = "frmInicio";
            this.Text = "Buscaminas - Seleccione dificultad";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.RadioButton rbDificil;
        private System.Windows.Forms.RadioButton rbPersonalizado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtBombas;
        private System.Windows.Forms.Button cmdJugar;
    }
}

