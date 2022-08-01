namespace WinFormsApp1
{
    partial class F_Historico
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosMesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_gasto_do_mes = new System.Windows.Forms.TextBox();
            this.l_gasto_do_mes = new System.Windows.Forms.Label();
            this.dgv_historico = new System.Windows.Forms.DataGridView();
            this.cb_meses = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.outrosMesesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // outrosMesesToolStripMenuItem
            // 
            this.outrosMesesToolStripMenuItem.Name = "outrosMesesToolStripMenuItem";
            this.outrosMesesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outrosMesesToolStripMenuItem.Text = "Outros Meses";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(100, 26);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem.Text = "teste";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem1,
            this.testeaaToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(112, 48);
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.testeToolStripMenuItem1.Text = "teste";
            // 
            // testeaaToolStripMenuItem
            // 
            this.testeaaToolStripMenuItem.Name = "testeaaToolStripMenuItem";
            this.testeaaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.testeaaToolStripMenuItem.Text = "testeaa";
            // 
            // tb_gasto_do_mes
            // 
            this.tb_gasto_do_mes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_gasto_do_mes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_gasto_do_mes.Location = new System.Drawing.Point(377, 383);
            this.tb_gasto_do_mes.Name = "tb_gasto_do_mes";
            this.tb_gasto_do_mes.ReadOnly = true;
            this.tb_gasto_do_mes.Size = new System.Drawing.Size(105, 23);
            this.tb_gasto_do_mes.TabIndex = 3;
            this.tb_gasto_do_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_gasto_do_mes
            // 
            this.l_gasto_do_mes.AutoSize = true;
            this.l_gasto_do_mes.Location = new System.Drawing.Point(311, 387);
            this.l_gasto_do_mes.Name = "l_gasto_do_mes";
            this.l_gasto_do_mes.Size = new System.Drawing.Size(60, 15);
            this.l_gasto_do_mes.TabIndex = 4;
            this.l_gasto_do_mes.Text = "Total Mês:";
            // 
            // dgv_historico
            // 
            this.dgv_historico.AllowUserToAddRows = false;
            this.dgv_historico.AllowUserToDeleteRows = false;
            this.dgv_historico.AllowUserToResizeColumns = false;
            this.dgv_historico.AllowUserToResizeRows = false;
            this.dgv_historico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_historico.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_historico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_historico.EnableHeadersVisualStyles = false;
            this.dgv_historico.Location = new System.Drawing.Point(3, 28);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.ReadOnly = true;
            this.dgv_historico.RowHeadersVisible = false;
            this.dgv_historico.RowTemplate.Height = 25;
            this.dgv_historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historico.Size = new System.Drawing.Size(498, 353);
            this.dgv_historico.TabIndex = 1;
            // 
            // cb_meses
            // 
            this.cb_meses.FormattingEnabled = true;
            this.cb_meses.Location = new System.Drawing.Point(12, 382);
            this.cb_meses.Name = "cb_meses";
            this.cb_meses.Size = new System.Drawing.Size(121, 23);
            this.cb_meses.TabIndex = 6;
            // 
            // F_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 411);
            this.ControlBox = false;
            this.Controls.Add(this.cb_meses);
            this.Controls.Add(this.l_gasto_do_mes);
            this.Controls.Add(this.tb_gasto_do_mes);
            this.Controls.Add(this.dgv_historico);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Historico";
            this.Load += new System.EventHandler(this.F_Historico_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem outrosMesesToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem testeToolStripMenuItem1;
        private ToolStripMenuItem testeaaToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private TextBox tb_gasto_do_mes;
        private Label l_gasto_do_mes;
        private DataGridView dgv_historico;
        private ComboBox cb_meses;
    }
}