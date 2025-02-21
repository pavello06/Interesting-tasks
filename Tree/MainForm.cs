using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Program.MainForm = this;
            InitializeComponent();
            MainForm_SizeChanged(null, null);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            Program.ActionForm.ActionButton.Text = @"Insert";
            Program.ActionForm.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            Program.ActionForm.ActionButton.Text = @"Remove";
            Program.ActionForm.ShowDialog();
        }
        
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ActionsPanel.Top = (this.ClientSize.Height - ActionsPanel.Height) / 2;
            
            TreePanel.Width = this.ClientSize.Width - ActionsPanel.Width - 20;
            TreePanel.Height = this.ClientSize.Height - 20;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Program.Tree.DrawBinarySearchTree(sender, e);
            if (Program.Tree.IsFirmware && !Program.Tree.IsEmpty())
            {
                BinarySearchTreeNode<int>[] inorderTraversal = Program.Tree.InOrderTraversal();
                for (int i = 0; i < inorderTraversal.Length - 1; i++)
                {
                    if (inorderTraversal[i].Right == null)
                    {
                        Program.Tree.DrawFirmware(sender, e, inorderTraversal[i].Value, inorderTraversal[i + 1].Value);
                    }
                }
                if (inorderTraversal[inorderTraversal.Length - 1].Right == null)
                {
                    Program.Tree.DrawFirmware(sender, e, inorderTraversal[inorderTraversal.Length - 1].Value, default(Int32));
                }
            }
        }

        private void FirmwareButton_Click(object sender, EventArgs e)
        {
            Program.Tree.IsFirmware = !Program.Tree.IsFirmware;
            panel1.Refresh();
        }

        private void ClickOrderButton(BinarySearchTree<int>.Order order)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            BinarySearchTreeNode<int>[] marinaorderTraversal = Program.Tree.MarinaOrderTraversal();
            for (int i = 0; i < marinaorderTraversal.Length; i++)
            {
                if (marinaorderTraversal[i].Value != 0)
                {
                    if (dictionary.ContainsKey(marinaorderTraversal[i].Value))
                    {
                        dictionary[marinaorderTraversal[i].Value]++;
                    }
                    else
                    {
                        dictionary.Add(marinaorderTraversal[i].Value, 1);
                    }
                
                    BinarySearchTreeNode<int>[] orderTraversal = Program.Tree.PreOrderTraversal();
                    for (int j = 0; j < orderTraversal.Length; j++)
                    {
                        if (orderTraversal[j].PenColor != Color.Green)
                        {
                            orderTraversal[j].PenColor = Color.Black;
                        }
                    }

                    if (dictionary[marinaorderTraversal[i].Value] == (int)order)
                    {
                        marinaorderTraversal[i].PenColor = Color.Green;
                    }
                    marinaorderTraversal[i].PenColor = Color.Red;
                }
                panel1.Refresh();
                System.Threading.Thread.Sleep(1000);
                if (marinaorderTraversal[i].Value != 0)
                {
                    if (dictionary[marinaorderTraversal[i].Value] >= (int)order)
                    {
                        marinaorderTraversal[i].PenColor = Color.Green;
                    }
                    else
                    {
                        marinaorderTraversal[i].PenColor = Color.Black;
                    }
                }
            }
        }        
        
        async private void PreOrderButton_Click(object sender, EventArgs e)
        {
            if (!Program.Tree.IsEmpty())
            {
                await Task.Run(() => ClickOrderButton(BinarySearchTree<int>.Order.Pre));
            }
        }

        async private void InOrderButton_Click(object sender, EventArgs e)
        {
            if (!Program.Tree.IsEmpty())
            {
                await Task.Run(() => ClickOrderButton(BinarySearchTree<int>.Order.In));
            }
        }

        async private void PostOrderButton_Click(object sender, EventArgs e)
        {
            if (!Program.Tree.IsEmpty())
            {
                await Task.Run(() => ClickOrderButton(BinarySearchTree<int>.Order.Post));
            }
        }

        private void ResetOrderButton_Click(object sender, EventArgs e)
        {
            if (!Program.Tree.IsEmpty())
            {
                BinarySearchTreeNode<int>[] orderTraversal = Program.Tree.PreOrderTraversal();
                for (int j = 0; j < orderTraversal.Length; j++)
                {
                    orderTraversal[j].PenColor = Color.Black;
                }

                panel1.Refresh();
            }
        }
    }
}