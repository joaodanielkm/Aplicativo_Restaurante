namespace WinFormsApp1
{
    partial class F_Configuracoes
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
            this.tb_vlrkg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_vlrkg
            // 
            this.tb_vlrkg.Location = new System.Drawing.Point(92, 64);
            this.tb_vlrkg.Name = "tb_vlrkg";
            this.tb_vlrkg.Size = new System.Drawing.Size(117, 23);
            this.tb_vlrkg.TabIndex = 0;
            this.tb_vlrkg.Text = "37,50";
            this.tb_vlrkg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // F_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 411);
            this.Controls.Add(this.tb_vlrkg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Configuracoes";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox tb_vlrkg;
    }
}