namespace SysVenda_MDI
{
    partial class impressora
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
            ButtonClick = new Button();
            SuspendLayout();
            // 
            // ButtonClick
            // 
            ButtonClick.BackColor = SystemColors.ActiveCaptionText;
            ButtonClick.ForeColor = SystemColors.HighlightText;
            ButtonClick.Location = new Point(46, 28);
            ButtonClick.Name = "ButtonClick";
            ButtonClick.Size = new Size(94, 33);
            ButtonClick.TabIndex = 17;
            ButtonClick.Text = "imprimir";
            ButtonClick.UseVisualStyleBackColor = false;
            ButtonClick.Click += ButtonImpressora_Click;
            // 
            // impressora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonClick);
            Name = "impressora";
            Text = "impressora";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonClick;
    }
}