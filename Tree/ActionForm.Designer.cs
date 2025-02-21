using System.ComponentModel;

namespace Tree
{
    partial class ActionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Location = new System.Drawing.Point(50, 53);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(345, 22);
            this.ValuesTextBox.TabIndex = 0;
            this.ValuesTextBox.TextChanged += new System.EventHandler(this.ValuesTextBox_TextChanged);
            this.ValuesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValuesTextBox_KeyDown);
            // 
            // ActionButton
            // 
            this.ActionButton.Enabled = false;
            this.ActionButton.Location = new System.Drawing.Point(50, 94);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(131, 45);
            this.ActionButton.TabIndex = 1;
            this.ActionButton.Text = "Action";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(264, 94);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(131, 45);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 159);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.ValuesTextBox);
            this.Name = "ActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActionForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Button CancelButton;

        private System.Windows.Forms.TextBox ValuesTextBox;

        #endregion
    }
}