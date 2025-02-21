using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tree
{
    public class BinarySearchTreeNode<T>
    {
        public const int Diameter = 30;

        public Color PenColor = Color.Black;
        public T Value;
        public BinarySearchTreeNode<T> Left;
        public BinarySearchTreeNode<T> Right;

        public BinarySearchTreeNode(T value, BinarySearchTreeNode<T> left = null, BinarySearchTreeNode<T> right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public void DrawBinarySearchTreeNode(Graphics graphics, BinarySearchTreeNode<T> node, int x, int y)
        {
            graphics.FillEllipse(Brushes.White, x, y, Diameter, Diameter);
            graphics.DrawEllipse(new Pen(PenColor, 2), x, y, Diameter, Diameter);
            
            string text = node.Value.ToString();
            SizeF textSize = graphics.MeasureString(text, new Font("Arial",14));
            
            int textX = x + (int)Math.Round((Diameter - textSize.Width) / 2);
            int textY = y + (int)Math.Round((Diameter - textSize.Height) / 2);
            
            graphics.DrawString(text, new Font("Arial",14), Brushes.Black, textX, textY);
        }
    }
    
    public class BinarySearchTree<T> where T : IComparable
    {
        public enum Order
        {
            Pre = 1,
            In,
            Post,
            Marina
        }
        
        public const int MaxDepth = 7;
        
        private BinarySearchTreeNode<T> _root;
        public bool IsFirmware = false;
        
        private T GetMinValue(BinarySearchTreeNode<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Value;
        }
        public T GetMinValue()
        {
            if (_root == null)
            {
                throw new Exception("The tree is empty");
            }
            
            return GetMinValue(_root);
        }
        
        private T GetMaxValue(BinarySearchTreeNode<T> node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node.Value;
        }
        public T GetMaxValue()
        {
            if (_root == null)
            {
                throw new Exception("The tree is empty");
            }
            
            return GetMaxValue(_root);
        }

        private BinarySearchTreeNode<T> Insert(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new BinarySearchTreeNode<T>(value);
            }
            
            int compare = value.CompareTo(node.Value);
            if (compare == 1)
            {
                node.Right = Insert(node.Right, value);
            }
            else if (compare == -1)
            {
                node.Left = Insert(node.Left, value);
            }
            else
            {
                throw new Exception("This value already exists");
            }

            return node;
        }
        public void Insert(T value)
        {
            _root = Insert(_root, value);
        }
        
        private BinarySearchTreeNode<T> Remove(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null)
            {
                throw new Exception("This value doesn't exist");
            }
            
            int compare = value.CompareTo(node.Value);
            if (compare == 1)
            {
                node.Right = Remove(node.Right, value);
            }
            else if (compare == -1)
            {
                node.Left = Remove(node.Left, value);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                if (node.Right == null)
                {
                    return node.Left;
                }

                T leftMaxValue = GetMaxValue(node.Left);
                node.Value = leftMaxValue;
                node.Left = Remove(node.Left, leftMaxValue);
            }

            return node;
        }
        public void Remove(T value)
        {
            _root = Remove(_root, value);
        }

        private bool Contains(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return false;
            }
            
            int compare = value.CompareTo(node.Value);
            if (compare == 1)
            {
                return Contains(node.Right, value);
            }
            else if (compare == -1)
            {
                return Contains(node.Left, value);
            }
            else
            {
                return true;
            }
        }
        public bool Contains(T value)
        {
            return Contains(_root, value);
        }

        public bool IsEmpty()
        {
            return _root == null;
        }

        private BinarySearchTreeNode<T>[] OrderTraversal(Order order)
        {
            List<BinarySearchTreeNode<T>> list;
            switch (order)
            {
                case Order.Pre:
                    list = PreOrderTraversal(_root);
                    break;
                case Order.In:
                    list = InOrderTraversal(_root);
                    break;
                case Order.Post:
                    list = PostOrderTraversal(_root);
                    break;
                case Order.Marina:
                    list = MarinaOrderTraversal(_root);
                    break;
                default:
                    list = new List<BinarySearchTreeNode<T>>();
                    break;
            }
            BinarySearchTreeNode<T>[] result = new BinarySearchTreeNode<T>[list.Count];
            list.CopyTo(result);
            return result;
        }
        
        private List<BinarySearchTreeNode<T>> PreOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node == null)
            {
                return new List<BinarySearchTreeNode<T>>() { };
            }
            
            List<BinarySearchTreeNode<T>> list = new List<BinarySearchTreeNode<T>>();
            list.Add(node);
            list.AddRange(PreOrderTraversal(node.Left));
            list.AddRange(PreOrderTraversal(node.Right));

            return list;
        }
        public BinarySearchTreeNode<T>[] PreOrderTraversal()
        {
            return OrderTraversal(Order.Pre);
        }
        
        private List<BinarySearchTreeNode<T>> InOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node == null)
            {
                return new List<BinarySearchTreeNode<T>>() { };
            }
            
            List<BinarySearchTreeNode<T>> list = new List<BinarySearchTreeNode<T>>();
            list.AddRange(InOrderTraversal(node.Left));
            list.Add(node);
            list.AddRange(InOrderTraversal(node.Right));

            return list;
        }
        public BinarySearchTreeNode<T>[] InOrderTraversal()
        {
            return OrderTraversal(Order.In);
        }
        
        private List<BinarySearchTreeNode<T>> PostOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node == null)
            {
                return new List<BinarySearchTreeNode<T>>() { };
            }
            
            List<BinarySearchTreeNode<T>> list = new List<BinarySearchTreeNode<T>>();
            list.AddRange(PostOrderTraversal(node.Left));
            list.AddRange(PostOrderTraversal(node.Right));
            list.Add(node);

            return list;
        }
        public BinarySearchTreeNode<T>[] PostOrderTraversal()
        {
            return OrderTraversal(Order.Post);
        }
        
        //WARNING!!! BIG ASS!!!
        private List<BinarySearchTreeNode<T>> MarinaOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node == null)
            {
                return new List<BinarySearchTreeNode<T>>() { new BinarySearchTreeNode<T>(default(T)) };
            }
            
            List<BinarySearchTreeNode<T>> list = new List<BinarySearchTreeNode<T>>();
            list.Add(node);
            list.AddRange(MarinaOrderTraversal(node.Left));
            list.Add(node);
            list.AddRange(MarinaOrderTraversal(node.Right));
            list.Add(node);

            return list;
        }
        public BinarySearchTreeNode<T>[] MarinaOrderTraversal()
        {
            return OrderTraversal(Order.Marina);
        }
        //WARNING!!! BIG ASS!!!
        
        private int GetDepth(BinarySearchTreeNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            
            int leftHeight = GetDepth(node.Left);
            int rightHeight = GetDepth(node.Right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
        public int GetDepth()
        {
            return GetDepth(_root);
        }
        
        //Draw Part
        private void DrawBinarySearchTree(Graphics graphics, BinarySearchTreeNode<T> node, int x, int y, int depth)
        {
            if (node == null)
            {
                return;
            }
            
            int offset = (int)Math.Pow(2, depth - 1) * BinarySearchTreeNode<T>.Diameter;

            if (node.Left != null)
            {
                graphics.DrawLine(Pens.Black, 
                    new Point(x + BinarySearchTreeNode<T>.Diameter / 2, y + BinarySearchTreeNode<T>.Diameter / 2), 
                    new Point(x - offset + BinarySearchTreeNode<T>.Diameter / 2, y + 3 * BinarySearchTreeNode<T>.Diameter / 2));
            }
            if (node.Right != null)
            {
                graphics.DrawLine(Pens.Black, 
                    new Point(x + BinarySearchTreeNode<T>.Diameter / 2, y + BinarySearchTreeNode<T>.Diameter / 2), 
                    new Point(x + offset + BinarySearchTreeNode<T>.Diameter / 2, y + 3 * BinarySearchTreeNode<T>.Diameter / 2));
            }
            
            node.DrawBinarySearchTreeNode(graphics, node, x, y);

            y += BinarySearchTreeNode<T>.Diameter;
            depth--;
            DrawBinarySearchTree(graphics, node.Left, x - offset, y, depth);
            DrawBinarySearchTree(graphics, node.Right, x + offset, y, depth);
        }
        public void DrawBinarySearchTree(object sender, PaintEventArgs e)
        {
            if (Program.Tree._root != null)
            {
                Graphics graphics = e.Graphics;
                int depth = Program.Tree.GetDepth();
                int rootX = ((int)Math.Pow(2, depth - 1) - 1) * BinarySearchTreeNode<T>.Diameter, 
                    rootY = 10;
                ((Control)sender).Width = 2 * rootX + BinarySearchTreeNode<T>.Diameter + 20;
                ((Control)sender).Height = depth * BinarySearchTreeNode<T>.Diameter + 20;
                DrawBinarySearchTree(graphics, _root, rootX + 10, rootY, depth - 1);
            }
        }

        private void GetPosition(BinarySearchTreeNode<T> node, T value, int depth, ref int x, ref int y)
        {
            int offset = (int)Math.Pow(2, depth - 1) * BinarySearchTreeNode<T>.Diameter;
            depth--;
            int compare = value.CompareTo(node.Value);
            if (compare == 1)
            {
                x += offset;
                GetPosition(node.Right, value, depth, ref x, ref y);
            }
            else if (compare == -1)
            {
                x -= offset;
                GetPosition(node.Left, value, depth, ref x, ref y);
            }
            else
            {
                return;
            }
            y += BinarySearchTreeNode<T>.Diameter;
        }
        private Point GetPosition(T value)
        {
            int depth = GetDepth();
            int x = ((int)Math.Pow(2, depth - 1) - 1) * BinarySearchTreeNode<T>.Diameter + BinarySearchTreeNode<T>.Diameter + 10;
            int y = BinarySearchTreeNode<T>.Diameter / 2 + 10;
            GetPosition(_root, value, depth - 1, ref x, ref y);
            return new Point(x, y);
        }
        public void DrawFirmware(object sender, PaintEventArgs e, T value1, T value2)
        {
            if (value2.Equals(default(T)))
            {
                value2 = _root.Value;
            }
            Graphics graphics = e.Graphics;
            graphics.DrawLine(Pens.Black, GetPosition(value1), GetPosition(value2));
        }
    }
}