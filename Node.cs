/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 15.12.2010
 * Time: 1:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DoubleLinkedListLab
{
	/// <summary>
	/// Узел двунаправленного списка
	/// </summary>
	public class Node
	{
		Node next;
		
		public Node Next {
			get { return next; }
			set { next = value; }
		}
		
		Node prev;
		
		public Node Prev {
			get { return prev; }
			set { prev = value; }
		}
		
		int info;
		
		public int Info {
			get { return info; }
			set { info = value; }
		}
		
		
		
		public Node()
		{
		}
		
		public Node(int info)
		{
			Info = info;
		}

		
		public Node(Node prev, Node next, int info)
		{
			Prev = prev;
			Next = next;
			Info = info;
		}
	}
}
