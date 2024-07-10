namespace SysVenda_MDI
{
	partial class Form_Vendas2
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
            button2 = new Button();
            Total = new Label();
            Txt_ProdutoID = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Produto = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Txt_Qtd = new TextBox();
            label4 = new Label();
            Txt_Cliente = new TextBox();
            Txt_ValorUnit = new TextBox();
            Txt_Troco = new TextBox();
            Txt_Total = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            Txt_DescReais = new TextBox();
            Txt_DescPorc = new TextBox();
            label8 = new Label();
            Txt_Produto = new TextBox();
            Txt_Descricao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(140, 135);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 1;
            button2.Text = "INSERIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Btn_INSERIR_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(537, 258);
            Total.Name = "Total";
            Total.Size = new Size(35, 15);
            Total.TabIndex = 3;
            Total.Text = "Total:";
            // 
            // Txt_ProdutoID
            // 
            Txt_ProdutoID.Location = new Point(43, 27);
            Txt_ProdutoID.Name = "Txt_ProdutoID";
            Txt_ProdutoID.Size = new Size(151, 23);
            Txt_ProdutoID.TabIndex = 12;
            Txt_ProdutoID.KeyPress += Txt_ProdutoID_KeyPress;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(537, 360);
            button3.Name = "button3";
            button3.Size = new Size(127, 43);
            button3.TabIndex = 16;
            button3.Text = "FINALIZAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Btn_FINALIZAR_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(458, 193);
            dataGridView1.TabIndex = 17;
            // 
            // Produto
            // 
            Produto.AutoSize = true;
            Produto.Location = new Point(43, 9);
            Produto.Name = "Produto";
            Produto.Size = new Size(67, 15);
            Produto.TabIndex = 18;
            Produto.Text = "Produto ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 64);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 19;
            label1.Text = "Unidade de medida:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 172);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 20;
            label2.Text = "Troco:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 122);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 21;
            label3.Text = "Quantidade:";
            // 
            // Txt_Qtd
            // 
            Txt_Qtd.Location = new Point(43, 140);
            Txt_Qtd.Name = "Txt_Qtd";
            Txt_Qtd.Size = new Size(72, 23);
            Txt_Qtd.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 9);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 23;
            label4.Text = "Cliente:";
            // 
            // Txt_Cliente
            // 
            Txt_Cliente.Location = new Point(423, 27);
            Txt_Cliente.Name = "Txt_Cliente";
            Txt_Cliente.Size = new Size(232, 23);
            Txt_Cliente.TabIndex = 24;
            // 
            // Txt_ValorUnit
            // 
            Txt_ValorUnit.Location = new Point(412, 82);
            Txt_ValorUnit.Name = "Txt_ValorUnit";
            Txt_ValorUnit.ReadOnly = true;
            Txt_ValorUnit.Size = new Size(64, 23);
            Txt_ValorUnit.TabIndex = 26;
            // 
            // Txt_Troco
            // 
            Txt_Troco.Location = new Point(246, 190);
            Txt_Troco.Name = "Txt_Troco";
            Txt_Troco.ReadOnly = true;
            Txt_Troco.Size = new Size(64, 23);
            Txt_Troco.TabIndex = 27;
            // 
            // Txt_Total
            // 
            Txt_Total.Location = new Point(537, 286);
            Txt_Total.Name = "Txt_Total";
            Txt_Total.ReadOnly = true;
            Txt_Total.Size = new Size(118, 23);
            Txt_Total.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 64);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 29;
            label6.Text = "Valor Unit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 172);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 30;
            label5.Text = "Desc. R$:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 172);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 31;
            label7.Text = "Desc. %:";
            // 
            // Txt_DescReais
            // 
            Txt_DescReais.Location = new Point(140, 190);
            Txt_DescReais.Name = "Txt_DescReais";
            Txt_DescReais.Size = new Size(64, 23);
            Txt_DescReais.TabIndex = 32;
            // 
            // Txt_DescPorc
            // 
            Txt_DescPorc.Location = new Point(43, 190);
            Txt_DescPorc.Name = "Txt_DescPorc";
            Txt_DescPorc.Size = new Size(64, 23);
            Txt_DescPorc.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 64);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 34;
            label8.Text = "Produto:";
            // 
            // Txt_Produto
            // 
            Txt_Produto.Location = new Point(43, 82);
            Txt_Produto.Name = "Txt_Produto";
            Txt_Produto.ReadOnly = true;
            Txt_Produto.Size = new Size(341, 23);
            Txt_Produto.TabIndex = 35;
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.Location = new Point(496, 82);
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.ReadOnly = true;
            Txt_Descricao.Size = new Size(110, 23);
            Txt_Descricao.TabIndex = 15;
            Txt_Descricao.TextChanged += Txt_Descricao_TextChanged;
            // 
            // Form_Vendas2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 436);
            Controls.Add(Txt_Produto);
            Controls.Add(label8);
            Controls.Add(Txt_DescPorc);
            Controls.Add(Txt_DescReais);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(Txt_Total);
            Controls.Add(Txt_Troco);
            Controls.Add(Txt_ValorUnit);
            Controls.Add(Txt_Cliente);
            Controls.Add(label4);
            Controls.Add(Txt_Qtd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Produto);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(Txt_Descricao);
            Controls.Add(Txt_ProdutoID);
            Controls.Add(Total);
            Controls.Add(button2);
            Name = "Form_Vendas2";
            Text = "Form_Vendas2";
            Load += Form_Vendas2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label Total;
        private TextBox Txt_ProdutoID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private DataGridView dataGridView1;
        private Label Produto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Txt_Qtd;
        private Label label4;
        private TextBox Txt_Cliente;
        private TextBox Txt_ValorUnit;
        private TextBox Txt_Troco;
        private TextBox Txt_Total;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox Txt_DescReais;
        private TextBox Txt_DescPorc;
        private Label label8;
        private TextBox Txt_Produto;
        private TextBox Txt_Descricao;
    }
}