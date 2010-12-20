using System;

namespace DoubleLinkedListLab
{
	public class Node
    {
        int info;
        Node prev;
        Node next;
        public Node()
        { }
        public Node(int info)
        {
            this.info = info;
        }
        public Node(int info, Node prev, Node next)
        {
            this.info = info;
            this.prev = prev;
            this.next = next;
        }
        public int Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }
        public Node Prev
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }
        }
        public Node Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
        
        //public bool isHead{
        	
        //}
        	
        
        public object Clone(List list)
		{
        	 
						
			Node p = this.Next;
			
			Node first;
			Node last;
			Node prev;
			Node c;
			
			first = new Node(this.Info,null,null);

			last = first.Next;
			//prelast = first;
			
			
			prev = first;
			c=null;
			
			while (p!=list.Head){
				c.Prev.Next = c = new Node(p.Info,last,null);
				c.Prev = prev;
				prev=c;
				p = p.Next;
			}
			
			return first;

		}
    }
}
