/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 19.11.2010
 * Time: 1:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LinkedListLab
{
	/// <summary>
	/// Description of CreateListDialog.
	/// </summary>
	public partial class CreateListDialog : Form
	{
		public CreateListDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1Enter(object sender, EventArgs e)
		{
			tlp.RowCount++;
			TextBox tb = new TextBox();
			tb.Enter+=TextBox1Enter;
			tb.Leave+=TextBox1Leave;
			tlp.Controls.Add(tb);
		}
		
		void TextBox1Leave(object sender, EventArgs e)
		{
			if (Text=="") tlp.RowCount--;
		}
	}
}
