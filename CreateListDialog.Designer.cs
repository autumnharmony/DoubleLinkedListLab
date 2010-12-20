/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 19.11.2010
 * Time: 1:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LinkedListLab
{
	partial class CreateListDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tlp = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlp
			// 
			this.tlp.AutoSize = true;
			this.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlp.ColumnCount = 1;
			this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp.Controls.Add(this.textBox1, 0, 0);
			this.tlp.Location = new System.Drawing.Point(28, 30);
			this.tlp.Name = "tlp";
			this.tlp.RowCount = 1;
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp.Size = new System.Drawing.Size(59, 26);
			this.tlp.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(53, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			this.textBox1.Leave += new System.EventHandler(this.TextBox1Leave);
			this.textBox1.Enter += new System.EventHandler(this.TextBox1Enter);
			// 
			// CreateListDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.tlp);
			this.Name = "CreateListDialog";
			this.Text = "CreateListDialog";
			this.tlp.ResumeLayout(false);
			this.tlp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TableLayoutPanel tlp;
	}
}
