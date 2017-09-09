namespace MantenedorVentasCsharp
{
    partial class ventanaAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblNomAD = new System.Windows.Forms.Label();
            this.lblUsA = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(414, 218);
            this.btnSalir.Size = new System.Drawing.Size(133, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Contenedor Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Administrar Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cambiar contraseña";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cerrar sesion";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblNomAD
            // 
            this.lblNomAD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNomAD.Location = new System.Drawing.Point(156, 91);
            this.lblNomAD.Name = "lblNomAD";
            this.lblNomAD.Size = new System.Drawing.Size(100, 23);
            this.lblNomAD.TabIndex = 11;
            this.lblNomAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsA
            // 
            this.lblUsA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsA.Location = new System.Drawing.Point(156, 160);
            this.lblUsA.Name = "lblUsA";
            this.lblUsA.Size = new System.Drawing.Size(100, 23);
            this.lblUsA.TabIndex = 12;
            this.lblUsA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCod.Location = new System.Drawing.Point(156, 218);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(100, 23);
            this.lblCod.TabIndex = 13;
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCod.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ventanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 359);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblUsA);
            this.Controls.Add(this.lblNomAD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ventanaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ventanaAdmin_FormClosed);
            this.Load += new System.EventHandler(this.ventanaAdmin_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblNomAD, 0);
            this.Controls.SetChildIndex(this.lblUsA, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomAD;
        private System.Windows.Forms.Label lblUsA;
        private System.Windows.Forms.Label lblCod;
    }
}