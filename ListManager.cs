using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoubleLinkedListLab
{
	/// <summary>
	/// Description of ListManager.
	/// </summary>
	public class ListManager
	{
		
		//Log log;
		public ListManager()
		{
			
		}
	
		
		/// <summary>
		/// Заменяет ? все вхождения одного списка в другой третьим списком
		/// 
		/// 1, 2, 3 , 4, 5, 1, 2, 3, 6
		/// 1, 2, 3
		/// 10, 20.
		/// 
		/// 10, 20, 4, 5, 10, 20, 6.
		/// </summary>
		public static  List Replace(List L1, List L2, List L3){
			
			Debug.WriteLine(L1);
			Debug.WriteLine(L2);
			Debug.WriteLine(L3);
						
			Node F1 = L1.Head.Next;
			Node F2 = L2.Head.Next;
			Node F3 = L3.Head.Next;
			
			List l1 = L1;
			List l2 = L2;
			List l3 = L3;

			if (!L1.isEmpty && !L2.isEmpty && !L3.isEmpty){
				
				Node p = F1;
				Node pp = null;
				Node q = null;
				
				Node prep = F1;
				bool matched = false;

				//FIXME: работает, вроде
				
				if (F1.Info == F2.Info){
					#region если вхождение в самом начале
					
					Debug.WriteLine("предположительно есть совпадение в начале");
					
					p = F1;
					pp = F2;
					
					//CyclicList t = p;
					
					matched = false;
					
					while (pp!=L2.Head && p!=L1.Head){
						
						matched = true;
						
						if (p.Info != pp.Info) {
							matched = false;
							break; 
						}
						//else{
						//matched = true;
						p=p.Next;
						pp=pp.Next;
						//}
						Debug.WriteLine("!!! p ="+p);
					}
					
					// bp
					if (matched) {

						// нашли вхождение
						Debug.WriteLine("и правда, есть вхождение в начале, меняем");
						
						//q = (Node)F3.Clone(L3);
						List newlist = L3.Clone(true);
						
						Debug.WriteLine("клонирован список "+newlist);
						
						q = newlist.Head.Next;
						q.Prev = L1.Head.Prev;
						//F1 = q;
						L1.Head.Next = q;
						
						while (q.Next!=newlist.Head){
							q=q.Next;
						}
						q.Next = p;
						p.Prev = q;
						
						prep = q;
						//p = q.Link;
						//Debug.WriteLine("prep ="+prep.Info+" p="+p.Info);
					}
					
					else {
						Debug.WriteLine("встретилась "+p+"ложная тревога, переходим в "+F1.Next);
						prep = F1;
						p = F1.Next;
					}
					
					#endregion
				}
			
				
				
				#region середина и конец
				
				while (p!=L1.Head){
					
					Debug.WriteLine(p);
					
					if (p.Info == F2.Info){
						Debug.WriteLine("преположительно вхождение");
						Debug.WriteLine(p+"");
						// запомнили начало
						Node s = p;
						
						pp = F2;
						
						matched = false;
						
						while (pp!=L2.Head && p!=L1.Head){
							
							//if (){
								
								matched = true;
								if (pp.Info!=p.Info) {
									Debug.WriteLine(pp.Info + "!="+p.Info);
									matched = false;
									break;
								}
								
								
								
								matched = true;
								//else {
								//	matched = true;
								pp = pp.Next;
								p = p.Next;
								
								if (pp == L2.Head && matched){
									matched = true;
									break;
								}
								
								if (p == L1.Head) { 
									matched = false; 
									break;
								}
								
						
						}
						
						if (matched) {
							Debug.WriteLine("и правда, меняем");
							
							//q = (CyclicList)F3.Clone();
							List newlist = L3.Clone(true);
						
							q = newlist.Head.Next;
							q.Prev = s.Prev;
							
							
							
							prep.Next = q;
							q = newlist.Head.Next;
							
							while (q.Next!=newlist.Head){
								q=q.Next;
							}
							
							q.Next = p;
							p.Prev = q;
							//prep.Link = q;
							prep = q;
							//p = p.Link;
							
							Debug.WriteLine("prep = "+prep + " p = "+p);
						
						}
						
						else {
							
							prep = s;
							p = s.Next;
						}
					}
					
					else {
						prep = p;
						p = p.Next;
						
					}
					
				}
				
				#endregion
				
				
			}
			Debug.WriteLine("возвращается список "+L1);
			return L1;
			
		}
		
		
		
		// идем по 1 списку с начала, если встретился элемент, у которого инф поле равно инф полю первого
		// элемента 2-го списка, то идем и сравниваем поэлементно, если нашли отличие выходим продолжаем
		// проход по первому списку с элемента следующего за
	}
}

