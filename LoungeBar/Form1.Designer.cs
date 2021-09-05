
namespace LoungeBar
{
    partial class Form1LoungeBar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBebida = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblBebida = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dgBebida = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBebida
            // 
            this.txtBebida.Location = new System.Drawing.Point(169, 13);
            this.txtBebida.Name = "txtBebida";
            this.txtBebida.Size = new System.Drawing.Size(444, 20);
            this.txtBebida.TabIndex = 0;
            this.txtBebida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(169, 39);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(444, 20);
            this.txtCategoria.TabIndex = 1;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(169, 65);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(444, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(169, 91);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(444, 93);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Location = new System.Drawing.Point(16, 20);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(43, 13);
            this.lblBebida.TabIndex = 4;
            this.lblBebida.Text = "Bebida:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(16, 46);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(16, 72);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(16, 125);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descricao:";
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btLimpar.Location = new System.Drawing.Point(660, 12);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(108, 30);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAlterar.Location = new System.Drawing.Point(660, 59);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(108, 30);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAdicionar.Location = new System.Drawing.Point(660, 108);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(108, 30);
            this.btAdicionar.TabIndex = 10;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExcluir.Location = new System.Drawing.Point(660, 154);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(108, 30);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // dgBebida
            // 
            this.dgBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colBebida,
            this.colCategoria,
            this.colDescricao,
            this.colValor});
            this.dgBebida.Location = new System.Drawing.Point(19, 232);
            this.dgBebida.Name = "dgBebida";
            this.dgBebida.Size = new System.Drawing.Size(749, 298);
            this.dgBebida.TabIndex = 12;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colBebida
            // 
            this.colBebida.HeaderText = "Bebida";
            this.colBebida.Name = "colBebida";
            this.colBebida.Width = 170;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 150;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 300;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 60;
            // 
            // Form1LoungeBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 542);
            this.Controls.Add(this.dgBebida);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblBebida);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtBebida);
            this.Name = "Form1LoungeBar";
            this.Text = "Lounge Bar";
            this.Load += new System.EventHandler(this.Form1LoungeBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBebida;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dgBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}

