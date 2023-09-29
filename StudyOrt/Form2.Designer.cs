
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
            this.chkBoxMostrar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
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
            // 
            // TxtBoxApellido
            // 
            this.TxtBoxApellido.Location = new System.Drawing.Point(205, 109);
            this.TxtBoxApellido.Name = "TxtBoxApellido";
            this.TxtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxApellido.TabIndex = 2;
            // 
            // TxtBoxDni
            // 
            this.TxtBoxDni.Location = new System.Drawing.Point(60, 155);
            this.TxtBoxDni.Name = "TxtBoxDni";
            this.TxtBoxDni.Size = new System.Drawing.Size(245, 20);
            this.TxtBoxDni.TabIndex = 3;
            // 
            // TxtBoxContaseña
            // 
            this.TxtBoxContaseña.Location = new System.Drawing.Point(60, 198);
            this.TxtBoxContaseña.Name = "TxtBoxContaseña";
            this.TxtBoxContaseña.PasswordChar = '•';
            this.TxtBoxContaseña.Size = new System.Drawing.Size(245, 20);
            this.TxtBoxContaseña.TabIndex = 4;
            // 
            // TxtBoxRepContraseña
            // 
            this.TxtBoxRepContraseña.Location = new System.Drawing.Point(60, 242);
            this.TxtBoxRepContraseña.Name = "TxtBoxRepContraseña";
            this.TxtBoxRepContraseña.PasswordChar = '•';
            this.TxtBoxRepContraseña.Size = new System.Drawing.Size(245, 20);
            this.TxtBoxRepContraseña.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Repetir Contraseña";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(60, 358);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 58);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver al Login";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBoxMostrar);
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
        private System.Windows.Forms.CheckBox chkBoxMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolver;
    }
}