using System.Collections.Generic;

namespace LeecodeStudy
{
    public class LRUCache
    {
         class CacheNode
        {
            public int nodeKey;
            public int nodeValue;
            public CacheNode pre, next;

            public CacheNode(int nodeKey, int nodeValue)
            {
                this.nodeKey = nodeKey;
                this.nodeValue = nodeValue;
            }
        }

        Dictionary<int, CacheNode> dic;
        private CacheNode head, tail;
        private int capacity;
        private int size;

        public LRUCache(int capacity)
        {
            dic = new Dictionary<int, CacheNode>();
            head = new CacheNode(0, -1);
            tail = new CacheNode(-1, -1);
            head.next = tail;
            tail.pre = head;
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            CacheNode node  = null;
            if(dic.TryGetValue(key,out node))
            {
                if (node != null)
                {
                    RemoveCurNode(node);
                    AddToTail(node);
                    return node.nodeValue;
                }
            }
            return -1;
        }

      
        public void Put(int key, int value)
        {
            if (dic.ContainsKey(key))
            {
                CacheNode node = dic[key];
                RemoveCurNode(node);
                AddToTail(node);
                node.nodeValue = value;
                return;
            } 
            if (size == capacity)
            {
                if(size == 0) return;
                //获取链表头节点的key
                int headKey = head.next.nodeKey;
                RemoveCurNode(head.next);
                dic.Remove(headKey);
                size--;
            }
            CacheNode newNode = new CacheNode(key,value);
            AddToTail(newNode);
            dic.Add(key,newNode);
            size++;
        }
        /// <summary>
        /// 移除当前元素
        /// </summary>
        /// <param name="node"></param>
        private void RemoveCurNode(CacheNode node)
        {
            node.pre.next = node.next;
            node.next.pre = node.pre;
        }

        private void AddToTail(CacheNode node)
        {
            CacheNode pre = tail.pre;
            pre.next = node;
            node.pre = pre;
            
            node.next = tail;
            tail.pre = node;
        }
    }
}