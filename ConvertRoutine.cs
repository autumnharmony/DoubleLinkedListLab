/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 20.12.2010
 * Time: 22:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DoubleLinkedListLab
{
	/// <summary>
	/// Description of ConvertRoutine.
	/// </summary>
	public class ConvertRoutine
	{
		public ConvertRoutine()
		{
		}
		
		public static int[] ArraysStrToInt(string[] values){
			int[] a = new int[values.Length];
			for (int i = 0; i<values.Length; i++){
				a[i] = int.Parse(values[i]);
			}
			return a;
				
		}
	}
}
