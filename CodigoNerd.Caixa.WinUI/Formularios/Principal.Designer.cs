namespace CodigoNerd.Caixa.WinUI.Formularios
{
    partial class Principal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.caixaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.administracaoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.usuarioLogadoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaMenu,
            this.administracaoMenu,
            this.sairMenu});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(666, 29);
            this.menuPrincipal.TabIndex = 1;
            // 
            // caixaMenu
            // 
            this.caixaMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.caixaMenu.Name = "caixaMenu";
            this.caixaMenu.Size = new System.Drawing.Size(59, 25);
            this.caixaMenu.Text = "&Caixa";
            this.caixaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caixaMenu.Click += new System.EventHandler(this.caixaMenu_Click);
            // 
            // administracaoMenu
            // 
            this.administracaoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosMenu});
            this.administracaoMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.administracaoMenu.Name = "administracaoMenu";
            this.administracaoMenu.Size = new System.Drawing.Size(122, 25);
            this.administracaoMenu.Text = "&Administração";
            this.administracaoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // produtosMenu
            // 
            this.produtosMenu.BackColor = System.Drawing.SystemColors.Control;
            this.produtosMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.produtosMenu.Name = "produtosMenu";
            this.produtosMenu.Size = new System.Drawing.Size(143, 26);
            this.produtosMenu.Text = "&Produtos";
            this.produtosMenu.Click += new System.EventHandler(this.produtosMenu_Click);
            // 
            // sairMenu
            // 
            this.sairMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sairMenu.Name = "sairMenu";
            this.sairMenu.Size = new System.Drawing.Size(49, 25);
            this.sairMenu.Text = "&Sair";
            this.sairMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairMenu.Click += new System.EventHandler(this.sairMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioLogadoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(666, 26);
            this.statusStrip1.TabIndex = 3;
            // 
            // usuarioLogadoLabel
            // 
            this.usuarioLogadoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.usuarioLogadoLabel.Name = "usuarioLogadoLabel";
            this.usuarioLogadoLabel.Size = new System.Drawing.Size(148, 21);
            this.usuarioLogadoLabel.Text = "<UsuarioLogado>";
            this.usuarioLogadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 302);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Código Nerd - Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem caixaMenu;
        private System.Windows.Forms.ToolStripMenuItem administracaoMenu;
        private System.Windows.Forms.ToolStripMenuItem produtosMenu;
        private System.Windows.Forms.ToolStripMenuItem sairMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel usuarioLogadoLabel;
    }
}