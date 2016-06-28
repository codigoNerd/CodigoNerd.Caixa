namespace CodigoNerd.Caixa.WinUI.Formularios
{
    partial class Caixa
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblSubtotalDescricao = new System.Windows.Forms.Label();
            this.lblSubtotalValor = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboImpostos = new System.Windows.Forms.ComboBox();
            this.lblImpostos = new System.Windows.Forms.Label();
            this.lblPesoValor = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblValorImpostosValor = new System.Windows.Forms.Label();
            this.lblValorImpostosDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtCodigo.Location = new System.Drawing.Point(259, 21);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(336, 32);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Peso,
            this.Preço,
            this.Quantidade});
            this.dgvItens.Location = new System.Drawing.Point(62, 80);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(6);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(907, 325);
            this.dgvItens.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 106;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 96;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 87;
            // 
            // Preço
            // 
            this.Preço.DataPropertyName = "Preco";
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Width = 94;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 149;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(57, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(193, 26);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Produto";
            // 
            // lblSubtotalDescricao
            // 
            this.lblSubtotalDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalDescricao.AutoSize = true;
            this.lblSubtotalDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalDescricao.Location = new System.Drawing.Point(566, 412);
            this.lblSubtotalDescricao.Name = "lblSubtotalDescricao";
            this.lblSubtotalDescricao.Size = new System.Drawing.Size(108, 26);
            this.lblSubtotalDescricao.TabIndex = 5;
            this.lblSubtotalDescricao.Text = "Sub-total";
            // 
            // lblSubtotalValor
            // 
            this.lblSubtotalValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalValor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSubtotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalValor.Location = new System.Drawing.Point(680, 411);
            this.lblSubtotalValor.Name = "lblSubtotalValor";
            this.lblSubtotalValor.Size = new System.Drawing.Size(289, 26);
            this.lblSubtotalValor.TabIndex = 6;
            this.lblSubtotalValor.Text = "R$ 0,00";
            this.lblSubtotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(762, 472);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(209, 37);
            this.btnFinalizarCompra.TabIndex = 13;
            this.btnFinalizarCompra.Text = "&Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.Location = new System.Drawing.Point(680, 443);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(289, 26);
            this.lblTotalValor.TabIndex = 10;
            this.lblTotalValor.Text = "R$ 0,00";
            this.lblTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(611, 444);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 26);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // cboImpostos
            // 
            this.cboImpostos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboImpostos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpostos.FormattingEnabled = true;
            this.cboImpostos.Location = new System.Drawing.Point(256, 441);
            this.cboImpostos.Name = "cboImpostos";
            this.cboImpostos.Size = new System.Drawing.Size(290, 33);
            this.cboImpostos.TabIndex = 8;
            this.cboImpostos.SelectedIndexChanged += new System.EventHandler(this.cboImpostos_SelectedIndexChanged);
            // 
            // lblImpostos
            // 
            this.lblImpostos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpostos.AutoSize = true;
            this.lblImpostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblImpostos.Location = new System.Drawing.Point(142, 444);
            this.lblImpostos.Name = "lblImpostos";
            this.lblImpostos.Size = new System.Drawing.Size(109, 26);
            this.lblImpostos.TabIndex = 7;
            this.lblImpostos.Text = "Impostos";
            // 
            // lblPesoValor
            // 
            this.lblPesoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesoValor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPesoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblPesoValor.Location = new System.Drawing.Point(257, 412);
            this.lblPesoValor.Name = "lblPesoValor";
            this.lblPesoValor.Size = new System.Drawing.Size(289, 26);
            this.lblPesoValor.TabIndex = 4;
            this.lblPesoValor.Text = "0,00 Kg";
            this.lblPesoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblPeso.Location = new System.Drawing.Point(126, 411);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(125, 26);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso Total";
            // 
            // lblValorImpostosValor
            // 
            this.lblValorImpostosValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorImpostosValor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValorImpostosValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblValorImpostosValor.Location = new System.Drawing.Point(257, 477);
            this.lblValorImpostosValor.Name = "lblValorImpostosValor";
            this.lblValorImpostosValor.Size = new System.Drawing.Size(289, 26);
            this.lblValorImpostosValor.TabIndex = 12;
            this.lblValorImpostosValor.Text = "R$ 0,00";
            this.lblValorImpostosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorImpostosDescricao
            // 
            this.lblValorImpostosDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorImpostosDescricao.AutoSize = true;
            this.lblValorImpostosDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblValorImpostosDescricao.Location = new System.Drawing.Point(79, 477);
            this.lblValorImpostosDescricao.Name = "lblValorImpostosDescricao";
            this.lblValorImpostosDescricao.Size = new System.Drawing.Size(172, 26);
            this.lblValorImpostosDescricao.TabIndex = 11;
            this.lblValorImpostosDescricao.Text = "Valor Impostos";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 542);
            this.Controls.Add(this.lblValorImpostosValor);
            this.Controls.Add(this.lblValorImpostosDescricao);
            this.Controls.Add(this.lblPesoValor);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblImpostos);
            this.Controls.Add(this.cboImpostos);
            this.Controls.Add(this.lblTotalValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.lblSubtotalValor);
            this.Controls.Add(this.lblSubtotalDescricao);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.txtCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Caixa";
            this.ShowIcon = false;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSubtotalDescricao;
        private System.Windows.Forms.Label lblSubtotalValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboImpostos;
        private System.Windows.Forms.Label lblImpostos;
        private System.Windows.Forms.Label lblPesoValor;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblValorImpostosValor;
        private System.Windows.Forms.Label lblValorImpostosDescricao;
    }
}