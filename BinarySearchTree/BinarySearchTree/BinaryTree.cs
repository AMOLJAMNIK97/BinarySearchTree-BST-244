using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinaryTree<T> LeftTree { get; set; }
        public BinaryTree<T> RightTree { get; set; }
        public BinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount=0, rightCount=0;
        bool rsult = false;
        public void Insert(T item)
        {
            T CurrentNodeData = this.NodeData;
            if ((CurrentNodeData.CompareTo(item)) > 0)
            {
                if(this.LeftTree == null)
                {
                    this.LeftTree = new BinaryTree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinaryTree<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }

            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
        public void Getsize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + rightCount));
        }
        public bool IfExists(T element , BinaryTree<T> node)
        {
            if(node ==null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the Element In BSR" + " " + node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData)<0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return true; 
        }

    }
}
