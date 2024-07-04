namespace SysVenda_MDI
{
	partial class Form_Clientes2
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
			this.Txt_NOME_CLIENTES = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Txt_CPF = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Txt_RG = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Txt_NASCIMENTO = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Txt_ENDERECO = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Txt_FONE = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Txt_EMAIL = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Btn_INSERIR = new System.Windows.Forms.Button();
			this.Btn_Ataualizar = new System.Windows.Forms.Button();
			this.Btn_Excluir = new System.Windows.Forms.Button();
			this.DGV_ListaClientes = new System.Windows.Forms.DataGridView();
			this.ButtonClick = new System.Windows.Forms.Button();
			this.Txt_CEP = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.DGV_ListaClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// Txt_NOME_CLIENTES
			// 
			this.Txt_NOME_CLIENTES.Location = new System.Drawing.Point(111, 21);
			this.Txt_NOME_CLIENTES.Name = "Txt_NOME_CLIENTES";
			this.Txt_NOME_CLIENTES.Size = new System.Drawing.Size(630, 20);
			this.Txt_NOME_CLIENTES.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(63, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 60;
			this.label2.Text = "Nome:";
			// 
			// Txt_CPF
			// 
			this.Txt_CPF.Location = new System.Drawing.Point(111, 62);
			this.Txt_CPF.Name = "Txt_CPF";
			this.Txt_CPF.Size = new System.Drawing.Size(100, 20);
			this.Txt_CPF.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(62, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 61;
			this.label3.Text = "CPF:";
			// 
			// Txt_RG
			// 
			this.Txt_RG.Location = new System.Drawing.Point(330, 62);
			this.Txt_RG.Name = "Txt_RG";
			this.Txt_RG.Size = new System.Drawing.Size(128, 20);
			this.Txt_RG.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(272, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 62;
			this.label4.Text = "RG:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Txt_NASCIMENTO
			// 
			this.Txt_NASCIMENTO.Location = new System.Drawing.Point(580, 62);
			this.Txt_NASCIMENTO.Name = "Txt_NASCIMENTO";
			this.Txt_NASCIMENTO.Size = new System.Drawing.Size(161, 20);
			this.Txt_NASCIMENTO.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(481, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 63;
			this.label5.Text = "NASCIMENTO:";
			// 
			// Txt_ENDERECO
			// 
			this.Txt_ENDERECO.Location = new System.Drawing.Point(138, 102);
			this.Txt_ENDERECO.Name = "Txt_ENDERECO";
			this.Txt_ENDERECO.Size = new System.Drawing.Size(306, 20);
			this.Txt_ENDERECO.TabIndex = 5;
			this.Txt_ENDERECO.TextChanged += new System.EventHandler(this.Txt_ENDERECO_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(62, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 64;
			this.label6.Text = "ENDEREÇO:";
			// 
			// Txt_FONE
			// 
			this.Txt_FONE.Location = new System.Drawing.Point(107, 151);
			this.Txt_FONE.Name = "Txt_FONE";
			this.Txt_FONE.Size = new System.Drawing.Size(170, 20);
			this.Txt_FONE.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(62, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "FONE:";
			// 
			// Txt_EMAIL
			// 
			this.Txt_EMAIL.Location = new System.Drawing.Point(378, 151);
			this.Txt_EMAIL.Name = "Txt_EMAIL";
			this.Txt_EMAIL.Size = new System.Drawing.Size(363, 20);
			this.Txt_EMAIL.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(327, 154);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "E-MAIL:";
			// 
			// Btn_INSERIR
			// 
			this.Btn_INSERIR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Btn_INSERIR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Btn_INSERIR.Location = new System.Drawing.Point(394, 379);
			this.Btn_INSERIR.Name = "Btn_INSERIR";
			this.Btn_INSERIR.Size = new System.Drawing.Size(110, 41);
			this.Btn_INSERIR.TabIndex = 9;
			this.Btn_INSERIR.Text = "INSERIR";
			this.Btn_INSERIR.UseVisualStyleBackColor = false;
			this.Btn_INSERIR.Click += new System.EventHandler(this.Btn_INSERIR_Click);
			// 
			// Btn_Ataualizar
			// 
			this.Btn_Ataualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Btn_Ataualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Btn_Ataualizar.Location = new System.Drawing.Point(517, 379);
			this.Btn_Ataualizar.Name = "Btn_Ataualizar";
			this.Btn_Ataualizar.Size = new System.Drawing.Size(110, 41);
			this.Btn_Ataualizar.TabIndex = 10;
			this.Btn_Ataualizar.Text = "ATAULIZAR";
			this.Btn_Ataualizar.UseVisualStyleBackColor = false;
			this.Btn_Ataualizar.Click += new System.EventHandler(this.Btn_ATUALIZAR_Click);
			// 
			// Btn_Excluir
			// 
			this.Btn_Excluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Btn_Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Btn_Excluir.Location = new System.Drawing.Point(642, 379);
			this.Btn_Excluir.Name = "Btn_Excluir";
			this.Btn_Excluir.Size = new System.Drawing.Size(110, 41);
			this.Btn_Excluir.TabIndex = 11;
			this.Btn_Excluir.Text = "EXCLUIR";
			this.Btn_Excluir.UseVisualStyleBackColor = false;
			this.Btn_Excluir.Click += new System.EventHandler(this.Btn_EXCLUIR_Click);
			// 
			// DGV_ListaClientes
			// 
			this.DGV_ListaClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.DGV_ListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DGV_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_ListaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV_ListaClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.DGV_ListaClientes.Location = new System.Drawing.Point(65, 191);
			this.DGV_ListaClientes.Name = "DGV_ListaClientes";
			this.DGV_ListaClientes.ReadOnly = true;
			this.DGV_ListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_ListaClientes.Size = new System.Drawing.Size(676, 173);
			this.DGV_ListaClientes.TabIndex = 8;
			// 
			// ButtonClick
			// 
			this.ButtonClick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ButtonClick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ButtonClick.Location = new System.Drawing.Point(626, 95);
			this.ButtonClick.Name = "ButtonClick";
			this.ButtonClick.Size = new System.Drawing.Size(115, 32);
			this.ButtonClick.TabIndex = 65;
			this.ButtonClick.Text = "Buscar";
			this.ButtonClick.UseVisualStyleBackColor = false;
			this.ButtonClick.Click += new System.EventHandler(this.Txt_CEP_Click);
			// 
			// Txt_CEP
			// 
			this.Txt_CEP.Location = new System.Drawing.Point(477, 102);
			this.Txt_CEP.Name = "Txt_CEP";
			this.Txt_CEP.Size = new System.Drawing.Size(143, 20);
			this.Txt_CEP.TabIndex = 66;
			// 
			// Form_Clientes2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Txt_CEP);
			this.Controls.Add(this.ButtonClick);
			this.Controls.Add(this.DGV_ListaClientes);
			this.Controls.Add(this.Btn_Excluir);
			this.Controls.Add(this.Btn_Ataualizar);
			this.Controls.Add(this.Btn_INSERIR);
			this.Controls.Add(this.Txt_EMAIL);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Txt_FONE);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Txt_ENDERECO);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Txt_NASCIMENTO);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Txt_RG);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Txt_CPF);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Txt_NOME_CLIENTES);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_Clientes2";
			this.Text = "Cadastros de Clientes";
			((System.ComponentModel.ISupportInitialize)(this.DGV_ListaClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox Txt_NOME_CLIENTES;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Txt_CPF;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Txt_RG;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Txt_NASCIMENTO;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Txt_ENDERECO;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Txt_FONE;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Txt_EMAIL;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Btn_INSERIR;
		private System.Windows.Forms.Button Btn_Ataualizar;
		private System.Windows.Forms.Button Btn_Excluir;
		private System.Windows.Forms.DataGridView DGV_ListaClientes;
		private System.Windows.Forms.Button ButtonClick;
		private System.Windows.Forms.TextBox Txt_CEP;
	}
}