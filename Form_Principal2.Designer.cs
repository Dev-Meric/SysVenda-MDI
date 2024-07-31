namespace SysVenda_MDI
{
	partial class Form_Principal2
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cADASTROToolStripMenuItem = new ToolStripMenuItem();
            cLIENTEToolStripMenuItem = new ToolStripMenuItem();
            pRODUTOSToolStripMenuItem = new ToolStripMenuItem();
            vENDASToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTROToolStripMenuItem, vENDASToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            cADASTROToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cLIENTEToolStripMenuItem, pRODUTOSToolStripMenuItem });
            cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            cADASTROToolStripMenuItem.Size = new Size(79, 20);
            cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // cLIENTEToolStripMenuItem
            // 
            cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            cLIENTEToolStripMenuItem.Size = new Size(180, 22);
            cLIENTEToolStripMenuItem.Text = "CLIENTE";
            cLIENTEToolStripMenuItem.Click += cLIENTEToolStripMenuItem_Click_1;
            // 
            // pRODUTOSToolStripMenuItem
            // 
            pRODUTOSToolStripMenuItem.Name = "pRODUTOSToolStripMenuItem";
            pRODUTOSToolStripMenuItem.Size = new Size(180, 22);
            pRODUTOSToolStripMenuItem.Text = "PRODUTOS";
            // 
            // vENDASToolStripMenuItem
            // 
            vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            vENDASToolStripMenuItem.Size = new Size(63, 20);
            vENDASToolStripMenuItem.Text = "VENDAS";
            // 
            // Form_Principal2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Principal2";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
		private ToolStripMenuItem cADASTROToolStripMenuItem;
		private ToolStripMenuItem cLIENTEToolStripMenuItem;
		private ToolStripMenuItem pRODUTOSToolStripMenuItem;
		private ToolStripMenuItem vENDASToolStripMenuItem;
	}
}
