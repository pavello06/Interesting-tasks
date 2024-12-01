namespace Tree
{
    partial class MainForm
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
            this.TreePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.ResetOrderButton = new System.Windows.Forms.Button();
            this.PostOrderButton = new System.Windows.Forms.Button();
            this.InOrderButton = new System.Windows.Forms.Button();
            this.PreOrderButton = new System.Windows.Forms.Button();
            this.FirmwareButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.TreePanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreePanel
            // 
            this.TreePanel.AutoScroll = true;
            this.TreePanel.Controls.Add(this.panel1);
            this.TreePanel.Location = new System.Drawing.Point(155, 12);
            this.TreePanel.Name = "TreePanel";
            this.TreePanel.Size = new System.Drawing.Size(619, 503);
            this.TreePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 548);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.ResetOrderButton);
            this.ActionsPanel.Controls.Add(this.PostOrderButton);
            this.ActionsPanel.Controls.Add(this.InOrderButton);
            this.ActionsPanel.Controls.Add(this.PreOrderButton);
            this.ActionsPanel.Controls.Add(this.FirmwareButton);
            this.ActionsPanel.Controls.Add(this.RemoveButton);
            this.ActionsPanel.Controls.Add(this.InsertButton);
            this.ActionsPanel.Location = new System.Drawing.Point(0, 15);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(155, 548);
            this.ActionsPanel.TabIndex = 4;
            // 
            // ResetOrderButton
            // 
            this.ResetOrderButton.Location = new System.Drawing.Point(12, 486);
            this.ResetOrderButton.Name = "ResetOrderButton";
            this.ResetOrderButton.Size = new System.Drawing.Size(129, 59);
            this.ResetOrderButton.TabIndex = 10;
            this.ResetOrderButton.Text = " Reset Order";
            this.ResetOrderButton.UseVisualStyleBackColor = true;
            this.ResetOrderButton.Click += new System.EventHandler(this.ResetOrderButton_Click);
            // 
            // PostOrderButton
            // 
            this.PostOrderButton.Location = new System.Drawing.Point(12, 407);
            this.PostOrderButton.Name = "PostOrderButton";
            this.PostOrderButton.Size = new System.Drawing.Size(129, 59);
            this.PostOrderButton.TabIndex = 9;
            this.PostOrderButton.Text = "PostOrder";
            this.PostOrderButton.UseVisualStyleBackColor = true;
            this.PostOrderButton.Click += new System.EventHandler(this.PostOrderButton_Click);
            // 
            // InOrderButton
            // 
            this.InOrderButton.Location = new System.Drawing.Point(12, 327);
            this.InOrderButton.Name = "InOrderButton";
            this.InOrderButton.Size = new System.Drawing.Size(129, 59);
            this.InOrderButton.TabIndex = 8;
            this.InOrderButton.Text = "InOrder";
            this.InOrderButton.UseVisualStyleBackColor = true;
            this.InOrderButton.Click += new System.EventHandler(this.InOrderButton_Click);
            // 
            // PreOrderButton
            // 
            this.PreOrderButton.Location = new System.Drawing.Point(12, 250);
            this.PreOrderButton.Name = "PreOrderButton";
            this.PreOrderButton.Size = new System.Drawing.Size(129, 59);
            this.PreOrderButton.TabIndex = 7;
            this.PreOrderButton.Text = "PreOrder";
            this.PreOrderButton.UseVisualStyleBackColor = true;
            this.PreOrderButton.Click += new System.EventHandler(this.PreOrderButton_Click);
            // 
            // FirmwareButton
            // 
            this.FirmwareButton.Location = new System.Drawing.Point(12, 171);
            this.FirmwareButton.Name = "FirmwareButton";
            this.FirmwareButton.Size = new System.Drawing.Size(129, 59);
            this.FirmwareButton.TabIndex = 6;
            this.FirmwareButton.Text = "Firmware";
            this.FirmwareButton.UseVisualStyleBackColor = true;
            this.FirmwareButton.Click += new System.EventHandler(this.FirmwareButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 90);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(129, 59);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(12, 10);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(129, 59);
            this.InsertButton.TabIndex = 4;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.ActionsPanel);
            this.Controls.Add(this.TreePanel);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.TreePanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ResetOrderButton;

        private System.Windows.Forms.Button PreOrderButton;
        private System.Windows.Forms.Button InOrderButton;
        private System.Windows.Forms.Button PostOrderButton;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel ActionsPanel;

        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button FirmwareButton;

        public System.Windows.Forms.Panel TreePanel;

        #endregion
    }
}