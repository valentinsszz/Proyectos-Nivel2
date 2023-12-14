
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
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.Location = new System.Drawing.Point(193, 118);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(153, 60);
            this.buttonSaludar.TabIndex = 0;
            this.buttonSaludar.Text = "Saludar";
            this.buttonSaludar.UseVisualStyleBackColor = true;
            this.buttonSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(200, 198);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AccessibleName = "";
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(190, 82);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(246, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 318);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.buttonSaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

