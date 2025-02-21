namespace Autopark
{
    partial class MainForm
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
            CarsPanel = new Panel();
            TitleLabel = new Label();
            SuspendLayout();
            // 
            // CarsPanel
            // 
            CarsPanel.AutoScroll = true;
            CarsPanel.Dock = DockStyle.Bottom;
            CarsPanel.Location = new Point(0, 81);
            CarsPanel.Name = "CarsPanel";
            CarsPanel.Size = new Size(996, 402);
            CarsPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            TitleLabel.Location = new Point(417, 15);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(185, 50);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Autopark";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 483);
            Controls.Add(TitleLabel);
            Controls.Add(CarsPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autopark";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CarsPanel;
        private Label TitleLabel;
    }
}
