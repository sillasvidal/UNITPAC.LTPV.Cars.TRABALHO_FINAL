namespace UNITPAC.LTPV.Cars.Pages
{
    partial class FrmConsultaCarros
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
            this.LbTitle = new System.Windows.Forms.Label();
            this.GridCarros = new System.Windows.Forms.DataGridView();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(303, 21);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(174, 25);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Consultar Carros";
            // 
            // GridCarros
            // 
            this.GridCarros.AllowUserToAddRows = false;
            this.GridCarros.AllowUserToDeleteRows = false;
            this.GridCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Column1Modelo,
            this.Column1Marca,
            this.ColumnPreco,
            this.Column1Km,
            this.Column1Ano});
            this.GridCarros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridCarros.Location = new System.Drawing.Point(0, 152);
            this.GridCarros.MultiSelect = false;
            this.GridCarros.Name = "GridCarros";
            this.GridCarros.ReadOnly = true;
            this.GridCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCarros.Size = new System.Drawing.Size(800, 298);
            this.GridCarros.TabIndex = 1;
            this.GridCarros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCarros_CellContentClick);
            this.GridCarros.DoubleClick += new System.EventHandler(this.GridCarros_DoubleClick);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.Location = new System.Drawing.Point(12, 115);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(130, 31);
            this.BtnAtualizar.TabIndex = 2;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(158, 115);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(130, 31);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "ID";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 40;
            // 
            // Column1Modelo
            // 
            this.Column1Modelo.DataPropertyName = "Modelo";
            this.Column1Modelo.HeaderText = "Modelo";
            this.Column1Modelo.Name = "Column1Modelo";
            this.Column1Modelo.ReadOnly = true;
            this.Column1Modelo.Width = 150;
            // 
            // Column1Marca
            // 
            this.Column1Marca.DataPropertyName = "Marca";
            this.Column1Marca.HeaderText = "Marca";
            this.Column1Marca.Name = "Column1Marca";
            this.Column1Marca.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.DataPropertyName = "Preco";
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            this.ColumnPreco.Width = 50;
            // 
            // Column1Km
            // 
            this.Column1Km.DataPropertyName = "Km";
            this.Column1Km.HeaderText = "Km";
            this.Column1Km.Name = "Column1Km";
            this.Column1Km.ReadOnly = true;
            this.Column1Km.Width = 80;
            // 
            // Column1Ano
            // 
            this.Column1Ano.DataPropertyName = "Ano";
            this.Column1Ano.HeaderText = "Ano";
            this.Column1Ano.Name = "Column1Ano";
            this.Column1Ano.ReadOnly = true;
            this.Column1Ano.Width = 50;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(701, 122);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmConsultaCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.GridCarros);
            this.Controls.Add(this.LbTitle);
            this.Name = "FrmConsultaCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaCarros";
            ((System.ComponentModel.ISupportInitialize)(this.GridCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.DataGridView GridCarros;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Ano;
        private System.Windows.Forms.Button BtnSair;
    }
}