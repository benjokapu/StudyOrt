
namespace StudyOrt
{
    partial class Form3
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
            this.BtnPrimerAño = new System.Windows.Forms.Button();
            this.BtnSegundoAño = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrimerAño
            // 
            this.BtnPrimerAño.Location = new System.Drawing.Point(327, 108);
            this.BtnPrimerAño.Name = "BtnPrimerAño";
            this.BtnPrimerAño.Size = new System.Drawing.Size(137, 42);
            this.BtnPrimerAño.TabIndex = 0;
            this.BtnPrimerAño.Text = "Primer Año";
            this.BtnPrimerAño.UseVisualStyleBackColor = true;
            this.BtnPrimerAño.Click += new System.EventHandler(this.BtnPrimerAño_Click);
            // 
            // BtnSegundoAño
            // 
            this.BtnSegundoAño.Location = new System.Drawing.Point(327, 194);
            this.BtnSegundoAño.Name = "BtnSegundoAño";
            this.BtnSegundoAño.Size = new System.Drawing.Size(137, 45);
            this.BtnSegundoAño.TabIndex = 1;
            this.BtnSegundoAño.Text = "Segundo Año";
            this.BtnSegundoAño.UseVisualStyleBackColor = true;
            this.BtnSegundoAño.Click += new System.EventHandler(this.BtnSegundoAño_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSegundoAño);
            this.Controls.Add(this.BtnPrimerAño);
            this.Name = "Form3";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrimerAño;
        private System.Windows.Forms.Button BtnSegundoAño;
    }
}