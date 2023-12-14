
namespace MiPrimerAplicacion
{
    partial class FormPrincipal
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Image = global::MiPrimerAplicacion.Properties.Resources.IconHappy;
            this.btnSaludar.Location = new System.Drawing.Point(195, 212);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(57, 65);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblPrimero
            // 
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimero.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPrimero.Location = new System.Drawing.Point(195, 93);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(69, 27);
            this.lblPrimero.TabIndex = 1;
            this.lblPrimero.Text = "Hola!";
            this.lblPrimero.MouseLeave += new System.EventHandler(this.lblPrimero_MouseLeave);
            this.lblPrimero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPrimero_MouseMove);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(174, 151);
            this.txtApellido.MaxLength = 32768;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtBNuevo
            // 
            this.txtBNuevo.Location = new System.Drawing.Point(174, 307);
            this.txtBNuevo.Multiline = true;
            this.txtBNuevo.Name = "txtBNuevo";
            this.txtBNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtBNuevo.TabIndex = 4;
            this.txtBNuevo.Leave += new System.EventHandler(this.txtBNuevo_Leave);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(466, 386);
            this.Controls.Add(this.txtBNuevo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblPrimero);
            this.Controls.Add(this.btnSaludar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primera Aplicacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Click += new System.EventHandler(this.FormPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label lblPrimero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBNuevo;
    }
}

