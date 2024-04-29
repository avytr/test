using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    public class Node
    {
        public Record record { get; set; }
        public Node leftnode { get; set; }
        public Node rightnode { get; set; }
    }
    public class BinarySearchTree
    {
        /// <summary>
        /// LƯU TRỮ HỒ SƠ DỰA THEO THỜI ĐIỂM TIÊM ĐẦU TIÊN
        /// </summary>
        public Node root { get; set; }
        //Phương thức Insert
        public bool Insert(Record value)
        {
            Node before = null, after = root;
            while (after != null)
            {
                before = after;
                if (value.dose1.injection_date.CompareTo(after.record.dose1.injection_date) == 0 || value.dose1.injection_date.CompareTo(after.record.dose1.injection_date) == -1)
                    after = after.leftnode;
                else if (value.dose1.injection_date.CompareTo(after.record.dose1.injection_date) == 1)
                    after = after.rightnode;
                else
                    return false;
            }

            Node newnode = new Node();
            newnode.record = value;
            if (root == null)
            {
                this.root = newnode;
            }
            else
            {
                if (value.dose1.injection_date.CompareTo(before.record.dose1.injection_date) == 0 || value.dose1.injection_date.CompareTo(before.record.dose1.injection_date) == -1)
                {
                    before.leftnode = newnode;
                }
                else if (value.dose1.injection_date.CompareTo(before.record.dose1.injection_date) == 1)
                {
                    before.rightnode = newnode;
                }
            }
            return true;
        }
        //Các phương thức Traversal
        //TraversePreOrder

        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePreOrder(parent.leftnode);
                Console.WriteLine(parent.record.ToString() + " ");
                TraversePreOrder(parent.rightnode);
            }
        }


        //TraverseInOrder
        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.leftnode);
                Console.WriteLine(parent.record.ToString() + " ");
                TraverseInOrder(parent.rightnode);
            }
        }

        //TraversePostOrder
        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.leftnode);
                TraversePostOrder(parent.rightnode);
                Console.WriteLine(parent.record.ToString() + " ");
            }
        }

        //Find
        public void FindThroughName(string name, Node parent, List<Record> records)
        {
            if (parent != null)
            {
                FindThroughName(name, parent.leftnode, records);
                if (parent.record.name.Equals(name))
                    records.Add(parent.record);
                FindThroughName(name, parent.rightnode, records);
            }
        }

        public void FindThroughTime(Node parent, List<Record> records, DateTime a, DateTime b)
        {
            if (parent != null)
            {

                if (parent.record.dose1.injection_date.CompareTo(a) == 1)
                    FindThroughTime(parent.leftnode, records, a, b);
                if ((parent.record.dose1.injection_date.CompareTo(a) == 1 || parent.record.dose1.injection_date.CompareTo(a) == 0) && ((parent.record.dose1.injection_date.CompareTo(b) == -1 || parent.record.dose1.injection_date.CompareTo(b) == 0)))
                    records.Add((parent.record));
                if (parent.record.dose1.injection_date.CompareTo(b) == -1)
                    FindThroughTime(parent.rightnode, records, a, b);
            }

        }

        private void ValueOfID(long id, Node parent, ref Record record)
        {
            if (parent != null)
            {
                ValueOfID(id, parent.leftnode, ref record);
                if (parent.record.id == id)
                    record = parent.record;
                ValueOfID(id, parent.rightnode, ref record);
            }
        }

        public Record FindThroughID(long id)
        {
            Record record = new Record();
            ValueOfID(id, this.root, ref record);
            return record;
        }

        
        //FindMin
        private Record MinValueOfNode(Node node)
        {
            Record minv = node.record;
            while (node.leftnode != null)
            {
                minv = node.leftnode.record;
                node = node.leftnode;
            }
            return minv;
        }
        public Record FindMin()
        {
            return MinValueOfNode(this.root);
        }

        //FindMax
        private Record MaxValueOfNode(Node node)
        {
            Record maxv = node.record;
            while (node.rightnode != null)
            {
                maxv = node.rightnode.record;
                node = node.rightnode;
            }
            return maxv;
        }
        public Record FindMax()
        {
            return MinValueOfNode(this.root);
        }

        //GetTreeDepth
        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.root);
        }
        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.leftnode), GetTreeDepth(parent.rightnode)) + 1;
        }

        //Remove


        public void Remove(Record value)
        {
            this.root = Remove(this.root, value);
        }
        private Node Remove(Node parent, Record value)
        {
            if (parent == null) return parent;
            if (value.dose1.injection_date.CompareTo(parent.record.dose1.injection_date) == -1)
                parent.leftnode = Remove(parent.leftnode, value);
            else if (value.dose1.injection_date.CompareTo(parent.record.dose1.injection_date) == 1)
                parent.rightnode = Remove(parent.rightnode, value);
            else
            {
                if (value.id == parent.record.id)
                {
                    if (parent.leftnode == null)
                        return parent.rightnode;
                    else if (parent.rightnode == null)
                        return parent.leftnode;
                    parent.record = MinValueOfNode(parent.rightnode);
                    parent.rightnode = Remove(parent.rightnode, parent.record);
                }
                else
                    parent.leftnode = Remove(parent.leftnode, value);
            }
            return parent;
        }
        


    }
}
