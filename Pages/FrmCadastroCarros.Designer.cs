namespace UNITPAC.LTPV.Cars.Pages
{
    partial class FrmCadastroCarros
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
            this.LbModelo = new System.Windows.Forms.Label();
            this.TxbModelo = new System.Windows.Forms.TextBox();
            this.TxbMarca = new System.Windows.Forms.TextBox();
            this.LbMarca = new System.Windows.Forms.Label();
            this.TxbAno = new System.Windows.Forms.TextBox();
            this.LbAno = new System.Windows.Forms.Label();
            this.TxbKm = new System.Windows.Forms.TextBox();
            this.LbKm = new System.Windows.Forms.Label();
            this.TxbPreco = new System.Windows.Forms.TextBox();
            this.LbPreco = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(126, 38);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(222, 29);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Cadastro de Carros";
            this.LbTitle.Click += new System.EventHandler(this.LbTitle_Click);
            // 
            // LbModelo
            // 
            this.LbModelo.AutoSize = true;
            this.LbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbModelo.Location = new System.Drawing.Point(37, 136);
            this.LbModelo.Name = "LbModelo";
            this.LbModelo.Size = new System.Drawing.Size(74, 24);
            this.LbModelo.TabIndex = 1;
            this.LbModelo.Text = "Modelo";
            // 
            // TxbModelo
            // 
            this.TxbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbModelo.Location = new System.Drawing.Point(117, 133);
            this.TxbModelo.MaxLength = 150;
            this.TxbModelo.Name = "TxbModelo";
            this.TxbModelo.Size = new System.Drawing.Size(263, 29);
            this.TxbModelo.TabIndex = 2;
            // 
            // TxbMarca
            // 
            this.TxbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbMarca.Location = new System.Drawing.Point(117, 188);
            this.TxbMarca.MaxLength = 150;
            this.TxbMarca.Name = "TxbMarca";
            this.TxbMarca.Size = new System.Drawing.Size(263, 29);
            this.TxbMarca.TabIndex = 4;
            // 
            // LbMarca
            // 
            this.LbMarca.AutoSize = true;
            this.LbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMarca.Location = new System.Drawing.Point(49, 191);
            this.LbMarca.Name = "LbMarca";
            this.LbMarca.Size = new System.Drawing.Size(62, 24);
            this.LbMarca.TabIndex = 3;
            this.LbMarca.Text = "Marca";
            // 
            // TxbAno
            // 
            this.TxbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbAno.Location = new System.Drawing.Point(117, 247);
            this.TxbAno.Name = "TxbAno";
            this.TxbAno.Size = new System.Drawing.Size(131, 29);
            this.TxbAno.TabIndex = 6;
            // 
            // LbAno
            // 
            this.LbAno.AutoSize = true;
            this.LbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAno.Location = new System.Drawing.Point(66, 250);
            this.LbAno.Name = "LbAno";
            this.LbAno.Size = new System.Drawing.Size(45, 24);
            this.LbAno.TabIndex = 5;
            this.LbAno.Text = "Ano";
            // 
            // TxbKm
            // 
            this.TxbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbKm.Location = new System.Drawing.Point(117, 307);
            this.TxbKm.Name = "TxbKm";
            this.TxbKm.Size = new System.Drawing.Size(131, 29);
            this.TxbKm.TabIndex = 8;
            // 
            // LbKm
            // 
            this.LbKm.AutoSize = true;
            this.LbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbKm.Location = new System.Drawing.Point(73, 310);
            this.LbKm.Name = "LbKm";
            this.LbKm.Size = new System.Drawing.Size(38, 24);
            this.LbKm.TabIndex = 7;
            this.LbKm.Text = "Km";
            // 
            // TxbPreco
            // 
            this.TxbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPreco.Location = new System.Drawing.Point(117, 367);
            this.TxbPreco.Name = "TxbPreco";
            this.TxbPreco.Size = new System.Drawing.Size(131, 29);
            this.TxbPreco.TabIndex = 10;
            // 
            // LbPreco
            // 
            this.LbPreco.AutoSize = true;
            this.LbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPreco.Location = new System.Drawing.Point(51, 370);
            this.LbPreco.Name = "LbPreco";
            this.LbPreco.Size = new System.Drawing.Size(60, 24);
            this.LbPreco.TabIndex = 9;
            this.LbPreco.Text = "Preço";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(117, 429);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(263, 30);
            this.BtnCadastrar.TabIndex = 11;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(388, 497);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 12;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmCadastroCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 557);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxbPreco);
            this.Controls.Add(this.LbPreco);
            this.Controls.Add(this.TxbKm);
            this.Controls.Add(this.LbKm);
            this.Controls.Add(this.TxbAno);
            this.Controls.Add(this.LbAno);
            this.Controls.Add(this.TxbMarca);
            this.Controls.Add(this.LbMarca);
            this.Controls.Add(this.TxbModelo);
            this.Controls.Add(this.LbModelo);
            this.Controls.Add(this.LbTitle);
            this.Name = "FrmCadastroCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label LbModelo;
        private System.Windows.Forms.TextBox TxbModelo;
        private System.Windows.Forms.TextBox TxbMarca;
        private System.Windows.Forms.Label LbMarca;
        private System.Windows.Forms.TextBox TxbAno;
        private System.Windows.Forms.Label LbAno;
        private System.Windows.Forms.TextBox TxbKm;
        private System.Windows.Forms.Label LbKm;
        private System.Windows.Forms.TextBox TxbPreco;
        private System.Windows.Forms.Label LbPreco;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnSair;
    }
}