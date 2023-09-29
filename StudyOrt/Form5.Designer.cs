
namespace StudyOrt
{
    partial class Form5
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCoins = new System.Windows.Forms.Button();
            this.BtnSubir = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.LblAño = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.BtnLogOut);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.BtnCoins);
            this.PanelMenu.Controls.Add(this.BtnSubir);
            this.PanelMenu.Controls.Add(this.BtnInicio);
            this.PanelMenu.Location = new System.Drawing.Point(9, 10);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(119, 342);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(12, 307);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(92, 21);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "Cerrar Cesion";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre y Apellido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnCoins
            // 
            this.BtnCoins.Location = new System.Drawing.Point(17, 209);
            this.BtnCoins.Name = "BtnCoins";
            this.BtnCoins.Size = new System.Drawing.Size(75, 23);
            this.BtnCoins.TabIndex = 2;
            this.BtnCoins.Text = "StudyCoins";
            this.BtnCoins.UseVisualStyleBackColor = true;
            // 
            // BtnSubir
            // 
            this.BtnSubir.Location = new System.Drawing.Point(17, 142);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(75, 23);
            this.BtnSubir.TabIndex = 1;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.UseVisualStyleBackColor = true;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Location = new System.Drawing.Point(17, 81);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(75, 23);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Location = new System.Drawing.Point(279, 45);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(35, 13);
            this.LblAño.TabIndex = 1;
            this.LblAño.Text = "label3";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAño);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCoins;
        private System.Windows.Forms.Button BtnSubir;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAño;
    }
}