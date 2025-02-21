using System;
using System.Windows.Forms;

namespace Tree
{
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            Program.ActionForm = this;
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            int value;
            if (!Int32.TryParse(ValuesTextBox.Text.Trim(), out value) || value == 0)
            {
                new ErrorBox().Show("Incorrect value entered");
                return;
            }
            
            if (ActionButton.Text == @"Insert")
            {
                if (Program.Tree.Contains(value))
                {
                    new ErrorBox().Show("This value already exists");
                    return;
                }
                Program.Tree.Insert(value);
                if (Program.Tree.GetDepth() >= BinarySearchTree<int>.MaxDepth)
                {
                    Program.Tree.Remove(value);
                    new ErrorBox().Show("Can't be bigger than max depth");
                    return;
                }
            }
            else
            {
                if (!Program.Tree.Contains(value))
                {
                    new ErrorBox().Show("This value already exists");
                    return;
                }
                Program.Tree.Remove(value);
            }
            
            Program.MainForm.TreePanel.Refresh();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ValuesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValuesTextBox.Text.Length == 0)
            {
                ActionButton.Enabled = false;
            }
            else
            {
                ActionButton.Enabled = true;
            }
        }

        private void ValuesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActionButton_Click(ActionButton, new EventArgs());
            }
        }
    }
}