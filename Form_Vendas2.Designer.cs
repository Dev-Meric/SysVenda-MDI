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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vendas2));
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			textBox2 = new TextBox();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			textBox6 = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(28, 111);
			label1.Name = "label1";
			label1.Size = new Size(75, 15);
			label1.TabIndex = 0;
			label1.Text = "ID Produto";
			label1.Click += label1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(132, 105);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 21);
			textBox1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			label2.Location = new Point(132, 146);
			label2.Name = "label2";
			label2.Size = new Size(47, 15);
			label2.TabIndex = 2;
			label2.Text = "Status";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			label3.Location = new Point(28, 30);
			label3.Name = "label3";
			label3.Size = new Size(68, 15);
			label3.TabIndex = 5;
			label3.Text = "CLIENTE:";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(270, 111);
			label4.Name = "label4";
			label4.Size = new Size(78, 15);
			label4.TabIndex = 7;
			label4.Text = "PRODUTO:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			label5.Location = new Point(498, 108);
			label5.Name = "label5";
			label5.Size = new Size(25, 15);
			label5.TabIndex = 9;
			label5.Text = "R$";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			label6.Location = new Point(270, 30);
			label6.Name = "label6";
			label6.Size = new Size(45, 15);
			label6.TabIndex = 10;
			label6.Text = "Nome";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			label7.Location = new Point(270, 173);
			label7.Name = "label7";
			label7.Size = new Size(98, 15);
			label7.TabIndex = 11;
			label7.Text = "QUANTIDADE:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(392, 170);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 21);
			textBox2.TabIndex = 12;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(21, 335);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(820, 155);
			dataGridView1.TabIndex = 13;
			// 
			// button1
			// 
			button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			button1.ForeColor = SystemColors.ControlLightLight;
			button1.Image = Properties.Resources.anime_natural_light_landscape_forest_studio_ghibli_hd_wallpaper_preview;
			button1.Location = new Point(392, 210);
			button1.Name = "button1";
			button1.Size = new Size(93, 29);
			button1.TabIndex = 14;
			button1.Text = "INSERIR";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			button2.ForeColor = SystemColors.ControlLightLight;
			button2.Image = Properties.Resources.anime_natural_light_landscape_forest_studio_ghibli_hd_wallpaper_preview;
			button2.Location = new Point(41, 522);
			button2.Name = "button2";
			button2.Size = new Size(93, 29);
			button2.TabIndex = 15;
			button2.Text = "ATUALIZAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			button3.ForeColor = SystemColors.ControlLightLight;
			button3.Image = Properties.Resources.anime_natural_light_landscape_forest_studio_ghibli_hd_wallpaper_preview;
			button3.Location = new Point(222, 522);
			button3.Name = "button3";
			button3.Size = new Size(93, 29);
			button3.TabIndex = 16;
			button3.Text = "EXCLUIR";
			button3.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(536, 105);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 21);
			textBox3.TabIndex = 17;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(366, 105);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 21);
			textBox4.TabIndex = 18;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(132, 30);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(87, 21);
			textBox5.TabIndex = 19;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(346, 24);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(290, 21);
			textBox6.TabIndex = 20;
			// 
			// Form_Vendas2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkOliveGreen;
			ClientSize = new Size(937, 592);
			Controls.Add(textBox6);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(textBox2);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = SystemColors.ControlLightLight;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form_Vendas2";
			SizeGripStyle = SizeGripStyle.Hide;
			Text = "Cadastro de Vendas";
			TransparencyKey = SystemColors.ActiveCaptionText;
			Load += Form_Vendas2_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox2;
		private DataGridView dataGridView1;
		private Button button1;
		private Button button2;
		private Button button3;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
	}
}