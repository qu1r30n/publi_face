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
            this.txt_url_de_imagen_o_video = new System.Windows.Forms.TextBox();
            this.cmb_a_publicar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_pagina = new System.Windows.Forms.TextBox();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_empezar
            // 
            this.btn_empezar.Location = new System.Drawing.Point(12, 77);
            this.btn_empezar.Name = "btn_empezar";
            this.btn_empezar.Size = new System.Drawing.Size(75, 23);
            this.btn_empezar.TabIndex = 0;
            this.btn_empezar.Text = "publicar";
            this.btn_empezar.UseVisualStyleBackColor = true;
            this.btn_empezar.Click += new System.EventHandler(this.btn_empezar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.Location = new System.Drawing.Point(220, 80);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(100, 20);
            this.txt_mensaje.TabIndex = 1;
            // 
            // txt_url_de_imagen_o_video
            // 
            this.txt_url_de_imagen_o_video.Location = new System.Drawing.Point(326, 80);
            this.txt_url_de_imagen_o_video.Name = "txt_url_de_imagen_o_video";
            this.txt_url_de_imagen_o_video.Size = new System.Drawing.Size(100, 20);
            this.txt_url_de_imagen_o_video.TabIndex = 2;
            this.txt_url_de_imagen_o_video.Visible = false;
            // 
            // cmb_a_publicar
            // 
            this.cmb_a_publicar.FormattingEnabled = true;
            this.cmb_a_publicar.Items.AddRange(new object[] {
            "texto",
            "imajen",
            "video"});
            this.cmb_a_publicar.Location = new System.Drawing.Point(93, 77);
            this.cmb_a_publicar.Name = "cmb_a_publicar";
            this.cmb_a_publicar.Size = new System.Drawing.Size(121, 21);
            this.cmb_a_publicar.TabIndex = 3;
            this.cmb_a_publicar.SelectedIndexChanged += new System.EventHandler(this.cmb_a_publicar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "a publicar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "url";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "mensaje";
            // 
            // txt_id_pagina
            // 
            this.txt_id_pagina.Location = new System.Drawing.Point(90, 25);
            this.txt_id_pagina.Name = "txt_id_pagina";
            this.txt_id_pagina.Size = new System.Drawing.Size(100, 20);
            this.txt_id_pagina.TabIndex = 7;
            // 
            // txt_token
            // 
            this.txt_token.Location = new System.Drawing.Point(196, 25);
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(100, 20);
            this.txt_token.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "id pagina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "token";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.txt_id_pagina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_a_publicar);
            this.Controls.Add(this.txt_url_de_imagen_o_video);
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
        private System.Windows.Forms.TextBox txt_url_de_imagen_o_video;
        private System.Windows.Forms.ComboBox cmb_a_publicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_pagina;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

