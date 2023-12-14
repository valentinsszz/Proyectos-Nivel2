
namespace ejemplo1
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbTrolo = new System.Windows.Forms.RadioButton();
            this.gpElemento = new System.Windows.Forms.GroupBox();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdadPreferida = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gpElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(137, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(87, 323);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(200, 91);
            this.lwElementos.TabIndex = 1;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(87, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(87, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(87, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(190, 101);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(87, 29);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(156, 28);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil Persona";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 19);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 7;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbTrolo
            // 
            this.rbTrolo.AutoSize = true;
            this.rbTrolo.Location = new System.Drawing.Point(100, 19);
            this.rbTrolo.Name = "rbTrolo";
            this.rbTrolo.Size = new System.Drawing.Size(49, 17);
            this.rbTrolo.TabIndex = 8;
            this.rbTrolo.TabStop = true;
            this.rbTrolo.Text = "Trolo";
            this.rbTrolo.UseVisualStyleBackColor = true;
            // 
            // gpElemento
            // 
            this.gpElemento.Controls.Add(this.rbTrolo);
            this.gpElemento.Controls.Add(this.rbNormal);
            this.gpElemento.Location = new System.Drawing.Point(90, 144);
            this.gpElemento.Name = "gpElemento";
            this.gpElemento.Size = new System.Drawing.Size(200, 48);
            this.gpElemento.TabIndex = 9;
            this.gpElemento.TabStop = false;
            this.gpElemento.Text = "Tipo:";
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(167, 213);
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(120, 20);
            this.nupEdad.TabIndex = 10;
            // 
            // lblEdadPreferida
            // 
            this.lblEdadPreferida.AutoSize = true;
            this.lblEdadPreferida.Location = new System.Drawing.Point(84, 215);
            this.lblEdadPreferida.Name = "lblEdadPreferida";
            this.lblEdadPreferida.Size = new System.Drawing.Size(77, 13);
            this.lblEdadPreferida.TabIndex = 11;
            this.lblEdadPreferida.Text = "Edad Preferida";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(87, 250);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 12;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 461);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblEdadPreferida);
            this.Controls.Add(this.nupEdad);
            this.Controls.Add(this.gpElemento);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.txtNombre);
            this.MinimumSize = new System.Drawing.Size(528, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.gpElemento.ResumeLayout(false);
            this.gpElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbTrolo;
        private System.Windows.Forms.GroupBox gpElemento;
        private System.Windows.Forms.NumericUpDown nupEdad;
        private System.Windows.Forms.Label lblEdadPreferida;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

