
namespace StudyOrt
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
            this.TxtBxDni = new System.Windows.Forms.TextBox();
            this.TxtBxContra = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.ImgLogo1 = new System.Windows.Forms.PictureBox();
            this.chkBoxMost1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBxDni
            // 
            this.TxtBxDni.Location = new System.Drawing.Point(336, 147);
            this.TxtBxDni.Name = "TxtBxDni";
            this.TxtBxDni.Size = new System.Drawing.Size(122, 20);
            this.TxtBxDni.TabIndex = 1;
            // 
            // TxtBxContra
            // 
            this.TxtBxContra.Location = new System.Drawing.Point(336, 196);
            this.TxtBxContra.Name = "TxtBxContra";
            this.TxtBxContra.PasswordChar = '•';
            this.TxtBxContra.Size = new System.Drawing.Size(122, 20);
            this.TxtBxContra.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(334, 275);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(126, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "INICIAR SESION";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(334, 346);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(126, 23);
            this.BtnCrearCuenta.TabIndex = 4;
            this.BtnCrearCuenta.Text = "CREAR CUENTA";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // ImgLogo1
            // 
            this.ImgLogo1.Location = new System.Drawing.Point(346, 61);
            this.ImgLogo1.Name = "ImgLogo1";
            this.ImgLogo1.Size = new System.Drawing.Size(100, 50);
            this.ImgLogo1.TabIndex = 5;
            this.ImgLogo1.TabStop = false;
            // 
            // chkBoxMost1
            // 
            this.chkBoxMost1.AutoSize = true;
            this.chkBoxMost1.Location = new System.Drawing.Point(341, 234);
            this.chkBoxMost1.Name = "chkBoxMost1";
            this.chkBoxMost1.Size = new System.Drawing.Size(117, 17);
            this.chkBoxMost1.TabIndex = 6;
            this.chkBoxMost1.Text = "Mostrar contraseña";
            this.chkBoxMost1.UseVisualStyleBackColor = true;
            this.chkBoxMost1.CheckedChanged += new System.EventHandler(this.chkBoxMost1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBoxMost1);
            this.Controls.Add(this.ImgLogo1);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBxContra);
            this.Controls.Add(this.TxtBxDni);
            this.Name = "Form1";
            this.Text = "    ";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBxDni;
        private System.Windows.Forms.TextBox TxtBxContra;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.PictureBox ImgLogo1;
        private System.Windows.Forms.CheckBox chkBoxMost1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

