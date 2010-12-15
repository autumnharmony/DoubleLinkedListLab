/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 15.12.2010
 * Time: 2:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DoubleLinkedListLab
{
	/// <summary>
	/// Description of DLList.
	/// </summary>
	public class DLList
	{
		Node head;
		
		public Node Head {
			get { return head; }
			set { head = value; }
		}
		
		public DLList()
		{
		}
		
		/// <summary>
		/// add last
		/// </summary>
		/// <param name="n"></param>
		public Add(Node n){
			head.Next = n;
			n.Next = head;
		}
	}
}
