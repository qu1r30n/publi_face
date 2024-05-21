namespace publicaciones
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
            this.btn_empezar = new System.Windows.Forms.Button();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_empezar
            // 
            this.btn_empezar.Location = new System.Drawing.Point(12, 9);
            this.btn_empezar.Name = "btn_empezar";
            this.btn_empezar.Size = new System.Drawing.Size(75, 23);
            this.btn_empezar.TabIndex = 0;
            this.btn_empezar.Text = "empezar";
            this.btn_empezar.UseVisualStyleBackColor = true;
            this.btn_empezar.Click += new System.EventHandler(this.btn_empezar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.Location = new System.Drawing.Point(93, 12);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(100, 20);
            this.txt_mensaje.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.btn_empezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_empezar;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}

