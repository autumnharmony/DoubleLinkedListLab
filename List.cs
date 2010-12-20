using System;

namespace DoubleLinkedListLab
{
	public class List:ICloneable
    {
        Node head;
        public List()
        {
            head = new Node();
            head.Prev = head;
            head.Next = head;
        }
        
        public bool isEmpty{
        	get{
        		if (this.Count == 0) return true;
        		return false;
        	}
        }
        
        public void InsertAfter(Node pointer, Node newNode)
        {
            if (pointer != null && head != null && newNode != null)
            {
                newNode.Next = pointer.Next;
                newNode.Prev = pointer;
                pointer.Next.Prev = newNode;
                pointer.Next = newNode;
            }
        }
        public void InsertAfter(Node pointer, int value)
        {
            if (pointer != null && head != null && value != null)
            {
                Node newNode = new Node(value, pointer, pointer.Next);
                pointer.Next.Prev = newNode;
                pointer.Next = newNode;
            }
        }
        public void InsertBefore(Node pointer, int value)
        {
            if (pointer != null && head != null && value != null)
            {
                Node node = new Node(value, pointer.Prev, pointer);
                pointer.Prev.Next = node;
                pointer.Prev = node;
            }
        }
        public void InsertBefore(Node pointer, Node newNode)
        {
            if (pointer != null && head != null && newNode != null)
            {
                newNode.Prev = pointer.Prev;
                newNode.Next = pointer;
                pointer.Prev.Next = newNode;
                pointer.Prev = newNode;
            }
        }
        
        public void Add(Node pointer){
        	Node q = Head.Next;
        	while (q!=Head){
        		q=q.Next;
        	}
        	
        	q.Next = pointer;
        	pointer.Prev = q;
        }
        
        public void Add(int value){
        	Node q = Head.Next;
        	while (q!=Head){
        		q=q.Next;
        	}
        	q.Next = new Node(value);
        	q.Next.Prev = q;
        }
        	
        public void Create(int[] values)
        {
            if (head != null && values != null)
            {
                Node node;
                for (int i = values.Length - 1; i >= 0; i--)
                {
                    node = new Node(values[i], head, head.Next);
                    head.Next.Prev = node;
                    head.Next = node;
                }
            }
        }
        
        public void Create(int[] values, string[] strValues)
        {
            if (head != null && values != null)
            {
                Node node;
                for (int i = values.Length - 1; i >= 0; i--)
                {
                    node = new Node(values[i], head, head.Next);
                    head.Next.Prev = node;
                    head.Next = node;
                }
            }
        }
        
        	
        public void Destroy()
        {
            head.Next = head;
            head.Prev = head;
        }
        public int Count
        {
            get
            {
                if (head != null)
                {
                    Node node = head.Next;
                    int i = 0;
                    while (node != head)
                    {
                        i++;
                        node = node.Next;
                    }
                    return i;
                }
                else
                    return 0;

            }
        }
        public Node Head
        {
            get
            {
                return head;
            }
        }
        public Node this[int t]
        {
            get
            {
                Node node = head;
                for (int i = 0; i <=t; i++)
                    node = node.Next;
                return node;
            }
            set
            {
                Node node = head;
                for (int i = 0; i <= t; i++)
                    node = node.Next;
                if (node != head)
                    node = value;
            }
        }
        public System.Collections.Generic.IEnumerator<Node> GetEnumerator()
        {
            Node buf = head.Next;
            while (buf != head)
            {
                yield return buf;
                buf = buf.Next;
            }
        }
        public int IndexOf(Node node)
        {
            Node buf = head.Next;
            int i = 0;
            while (buf != head && buf != node)
            {
                buf = buf.Next;
                i++;
            }
            if (buf == head)
                i = -1;
            return i;

        }
        public int IndexOf(int value)
        {
            Node buf = head.Next;
            int i = 0;
            while (buf != head && !buf.Info.Equals(value))
            {
                buf = buf.Next;
                i++;
            }
            if (buf == head)
                i = -1;
            return i;

        }
        public void Remove(Node node)
        {
            Node fnode = head.Next.Next;
            while (node != head && fnode != node)
                fnode = fnode.Next;
            if (fnode == node)
            {
                fnode.Next.Prev = fnode.Prev;
                fnode.Prev.Next = fnode.Next;
            }
            else
                throw new InvalidOperationException("«аданный узел не принадлежит этому списку");
        }
        public void RemoveAt(int index)
        {
            Node fnode = head;
            for (int i = 0; i <= index; i++)
                fnode = fnode.Next;
            if (fnode != head)
            {
                fnode.Next.Prev = fnode.Prev;
                fnode.Prev.Next = fnode.Next;
            }
        }
        public void RemoveWhere(int value)
        {
            Node node = head.Next;
            while (node != head)
            {
                if (node.Info.Equals(value))
                {
                    node.Prev.Next = node.Next;
                    node.Next.Prev = node.Prev;
                }
                node = node.Next;
            }
        }
        public void RemoveAllNodesWithValue(int value)
        {
            Node node = head.Next;
            while (node != head)
            {
                if (node.Info.Equals(value))
                {
                    node.Next.Prev = node.Prev;
                    node.Prev.Next = node.Next;
                }
                node = node.Next;
            }
        }
        
		public override string ToString()
		{
			string s = "";
			foreach(Node n in this){
				if (n!=null)
				s+=n.Info+"->";
				else break;
			}
			
			if (this.isEmpty){
				s = "empty";
			}
				
			return s;
		}
		
		
		public virtual object Clone()
		{
			List listClone = new List();
			
			for (Node node = Head.Next; node != Head; node = node.Next)
				listClone.Add(node);
			
			return listClone;
		}
		
		public List Clone(bool attemptDeepCopy)
		{
			List listClone = new List();

			if (attemptDeepCopy)
			{
				
				Node prev = listClone.Head; // new Head
				Node c = Head.Next;
				Node q = null;
				while (c!=Head){
					q = new Node(c.Info,null,null);
					q.Prev = prev;
					prev.Next = q;
					c = c.Next;
					prev = prev.Next;
				}
				
				q.Next = listClone.Head;
				
				
			}
			else
				listClone = (List)this.Clone();

			return listClone;
		}
    }
}
