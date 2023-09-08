
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBxDni
            // 
            this.TxtBxDni.Location = new System.Drawing.Point(336, 163);
            this.TxtBxDni.Name = "TxtBxDni";
            this.TxtBxDni.Size = new System.Drawing.Size(122, 20);
            this.TxtBxDni.TabIndex = 1;
            this.TxtBxDni.Text = "DNI";
            
            // 
            // TxtBxContra
            // 
            this.TxtBxContra.Location = new System.Drawing.Point(336, 214);
            this.TxtBxContra.Name = "TxtBxContra";
            this.TxtBxContra.Size = new System.Drawing.Size(122, 20);
            this.TxtBxContra.TabIndex = 2;
            this.TxtBxContra.Text = "CONTRASEÑA";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(537, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Constraseña Correcta";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

