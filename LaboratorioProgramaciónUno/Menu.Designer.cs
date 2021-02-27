
namespace LaboratorioProgramaciónUno
{
    partial class Menu
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
            this.TxtNombreUsuario = new System.Windows.Forms.Button();
            this.TxtNoombreAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtNombreUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.Location = new System.Drawing.Point(94, 102);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(218, 106);
            this.TxtNombreUsuario.TabIndex = 0;
            this.TxtNombreUsuario.Text = "USUARIO";
            this.TxtNombreUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TxtNombreUsuario.UseVisualStyleBackColor = false;
            this.TxtNombreUsuario.Click += new System.EventHandler(this.TxtNombreUsuario_Click);
            // 
            // TxtNoombreAdministrador
            // 
            this.TxtNoombreAdministrador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtNoombreAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtNoombreAdministrador.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoombreAdministrador.Location = new System.Drawing.Point(507, 102);
            this.TxtNoombreAdministrador.Name = "TxtNoombreAdministrador";
            this.TxtNoombreAdministrador.Size = new System.Drawing.Size(218, 106);
            this.TxtNoombreAdministrador.TabIndex = 2;
            this.TxtNoombreAdministrador.Text = "ADMINISTRADOR";
            this.TxtNoombreAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TxtNoombreAdministrador.UseVisualStyleBackColor = false;
            this.TxtNoombreAdministrador.Click += new System.EventHandler(this.TxtNoombreAdministrador_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtNoombreAdministrador);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TxtNombreUsuario;
        private System.Windows.Forms.Button TxtNoombreAdministrador;
    }
}

