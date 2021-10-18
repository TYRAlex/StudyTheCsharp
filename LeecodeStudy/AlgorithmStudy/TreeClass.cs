using System;
using System.Collections.Generic;
using System.Net;

namespace AlgorithmStudy
{
    public class TreeClass<T> where T : IComparable<T>
    {
        /// <summary>
        /// 定义一个二叉树
        /// </summary>
        private T data;
        private TreeClass<T> left;
        private TreeClass<T> right;
        /// <summary>
        /// 构造函数，定义二叉树的根节点
        /// </summary>
        /// <param name="nodeValue">二叉树的跟节点</param>
        public TreeClass(T nodeValue)
        {
            this.data = nodeValue;
            this.left = null;
            this.right = null;
        }

        /// <summary>
        /// 数据节点属性
        /// </summary>
        public T NodeData
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public TreeClass<T> LeftTree
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public TreeClass<T> RightTree
        {
            get { return this.right; }
            set { this.right = value; }
        }

        /// <summary>
        /// 向二叉树中插入一个节点
        /// 存储思想，凡是小于改节点值的数据全部都在该节点的左子树中，凡是大于该节点节点值的数据全部在该节点的右子树中
        /// </summary>
        /// <param name="newItem"></param>
        public void Insert(T newItem)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new TreeClass<T>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree=new TreeClass<T>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }

        /// <summary>
        /// 前序遍历：先根节点然后左子树，右子树
        /// </summary>
        /// <param name="root"></param>
        public void PreOrderTree(TreeClass<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.NodeData);
                PreOrderTree(root.LeftTree);
                PreOrderTree(root.RightTree);
            }
        }

        /// <summary>
        /// 中序遍历：左子树，根节点，右子树可以实现顺序输出
        /// </summary>
        /// <param name="root"></param>
        public void InOrderTree(TreeClass<T> root)
        {
            if (root != null)
            {
                InOrderTree(root.LeftTree);
                Console.WriteLine(root.NodeData);
                InOrderTree(root.RightTree);
            }
        }

        public void PostOrderTree(TreeClass<T> root)
        {
            if (root != null)
            {
                PostOrderTree(root.LeftTree);
                PostOrderTree(root.RightTree);
                Console.WriteLine(root.NodeData);
            }
        }

        /// <summary>
        /// 逐层遍历，遍历思想是从根节点开始，访问一个节点然后将其左右子树的根节点以此放入链表中，然后删除该节点
        /// 依次遍历直到链表中的元素数量为0即没有更下一层的节点出现时候止
        /// </summary>
        public void WideOrderTree()
        {
            List<TreeClass<T>> nodeList=new List<TreeClass<T>>();
            nodeList.Add(this);
            TreeClass<T> temp = null;
            while (nodeList.Count>0)
            {
                Console.WriteLine(nodeList[0].NodeData);
                temp = nodeList[0];
                nodeList.Remove(nodeList[0]);
                if (temp.LeftTree != null)
                {
                    nodeList.Add(temp.LeftTree);
                }

                if (temp.RightTree != null)
                {
                    nodeList.Add(temp.RightTree);
                }
                Console.WriteLine();
            }
        }

    }
}