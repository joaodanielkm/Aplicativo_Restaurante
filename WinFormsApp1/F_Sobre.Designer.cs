namespace WinFormsApp1
{
    partial class Sobre
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
            this.l_sobre = new System.Windows.Forms.Label();
            this.bt_ok_sobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_sobre
            // 
            this.l_sobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.l_sobre.Location = new System.Drawing.Point(59, 55);
            this.l_sobre.Name = "l_sobre";
            this.l_sobre.Size = new System.Drawing.Size(176, 142);
            this.l_sobre.TabIndex = 0;
            this.l_sobre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_sobre.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_ok_sobre
            // 
            this.bt_ok_sobre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ok_sobre.Location = new System.Drawing.Point(112, 223);
            this.bt_ok_sobre.Name = "bt_ok_sobre";
            this.bt_ok_sobre.Size = new System.Drawing.Size(75, 23);
            this.bt_ok_sobre.TabIndex = 0;
            this.bt_ok_sobre.Text = "Ok";
            this.bt_ok_sobre.UseVisualStyleBackColor = true;
            this.bt_ok_sobre.Click += new System.EventHandler(this.bt_ok_sobre_Click);
            this.bt_ok_sobre.Enter += new System.EventHandler(this.bt_ok_sobre_Enter);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 283);
            this.ControlBox = false;
            this.Controls.Add(this.bt_ok_sobre);
            this.Controls.Add(this.l_sobre);
            this.MaximizeBox = false;
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.Sobre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label l_sobre;
        private Button bt_ok_sobre;
    }
}