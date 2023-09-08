
namespace StudyOrt
{
    partial class Form2
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
            this.LblRegist = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new System.Windows.Forms.TextBox();
            this.TxtBoxApellido = new System.Windows.Forms.TextBox();
            this.TxtBoxDni = new System.Windows.Forms.TextBox();
            this.TxtBoxContaseña = new System.Windows.Forms.TextBox();
            this.TxtBoxRepContraseña = new System.Windows.Forms.TextBox();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkBoxMostrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LblRegist
            // 
            this.LblRegist.AutoSize = true;
            this.LblRegist.Location = new System.Drawing.Point(61, 61);
            this.LblRegist.Name = "LblRegist";
            this.LblRegist.Size = new System.Drawing.Size(60, 13);
            this.LblRegist.TabIndex = 0;
            this.LblRegist.Text = "Registrarse";
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(60, 109);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxNombre.TabIndex = 1;
            this.TxtBoxNombre.Text = "Nombre";
            // 
            // TxtBoxApellido
            // 
            this.TxtBoxApellido.Location = new System.Drawing.Point(205, 109);
            this.TxtBoxApellido.Name = "TxtBoxApellido";
            this.TxtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxApellido.TabIndex = 2;
            this.TxtBoxApellido.Text = "Apellido";
            // 
            // TxtBoxDni
            // 
            this.TxtBoxDni.Location = new System.Drawing.Point(60, 155);
            this.TxtBoxDni.Name = "TxtBoxDni";
            this.TxtBoxDni.Size = new System.Drawing.Size(245, 20);
            this.TxtBoxDni.TabIndex = 3;
            this.TxtBoxDni.Text = "Dni";
            // 
            // TxtBoxContaseña
            // 
            this.TxtBoxContaseña.Location = new System.Drawing.Point(60, 198);
            this.TxtBoxContaseña.Name = "TxtBoxContaseña";
            this.TxtBoxContaseña.PasswordChar = '•';
            this.TxtBoxContaseña.Size = new System.Drawing.Size(245, 20);
            this.TxtBoxContaseña.TabIndex = 4;
            this.TxtBoxContaseña.Text = "Contraseña";
            // 
            // TxtBoxRepContraseña
            // 
            this.TxtBoxRepContraseña.Location = new System.Drawing.Point(60, 242);
            this.TxtBoxRepContraseña.Name = "TxtBoxRepContraseña";
            this.TxtBoxRepContraseña.PasswordChar = '•';
            this.TxtBoxRepContraseña.Size = new System.Drawing.Size(245, 20);
            this.TxtBoxRepContraseña.TabIndex = 5;
            this.TxtBoxRepContraseña.Text = "Repetir Contraseña";
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.Location = new System.Drawing.Point(60, 319);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrarse.TabIndex = 6;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.UseVisualStyleBackColor = true;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkBoxMostrar
            // 
            this.chkBoxMostrar.AutoSize = true;
            this.chkBoxMostrar.Location = new System.Drawing.Point(60, 284);
            this.chkBoxMostrar.Name = "chkBoxMostrar";
            this.chkBoxMostrar.Size = new System.Drawing.Size(118, 17);
            this.chkBoxMostrar.TabIndex = 8;
            this.chkBoxMostrar.Text = "Mostrar Contraseña";
            this.chkBoxMostrar.UseVisualStyleBackColor = true;
            this.chkBoxMostrar.CheckedChanged += new System.EventHandler(this.chkBoxMostrar_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkBoxMostrar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.TxtBoxRepContraseña);
            this.Controls.Add(this.TxtBoxContaseña);
            this.Controls.Add(this.TxtBoxDni);
            this.Controls.Add(this.TxtBoxApellido);
            this.Controls.Add(this.TxtBoxNombre);
            this.Controls.Add(this.LblRegist);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegist;
        private System.Windows.Forms.TextBox TxtBoxNombre;
        private System.Windows.Forms.TextBox TxtBoxApellido;
        private System.Windows.Forms.TextBox TxtBoxDni;
        private System.Windows.Forms.TextBox TxtBoxContaseña;
        private System.Windows.Forms.TextBox TxtBoxRepContraseña;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkBoxMostrar;
    }
}