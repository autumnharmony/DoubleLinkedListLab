/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 18.11.2010
 * Time: 18:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DoubleLinkedListLab
{
	partial class MainForm
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
			this.ouput = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			//this.rl = new LinkedListLab.ListView();
			//this.listView1 = new LinkedListLab.ListView();
			//this.listView2 = new LinkedListLab.ListView();
			//this.listView3 = new LinkedListLab.ListView();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.log = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ouput
			// 
			this.ouput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ouput.Location = new System.Drawing.Point(212, 6);
			this.ouput.Multiline = true;
			this.ouput.Name = "ouput";
			this.ouput.Size = new System.Drawing.Size(170, 100);
			this.ouput.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(510, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(181, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Заменить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.файлToolStripMenuItem,
									this.видToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(91, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// видToolStripMenuItem
			// 
			this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem2,
									this.toolStripMenuItem3});
			this.видToolStripMenuItem.Name = "видToolStripMenuItem";
			this.видToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.видToolStripMenuItem.Text = "Вид";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(91, 22);
			this.toolStripMenuItem2.Text = "1";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(91, 22);
			this.toolStripMenuItem3.Text = "2";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(623, 372);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 41);
			this.label7.TabIndex = 12;
			this.label7.Text = "label7";
			this.label7.Visible = false;
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(53, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 13;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(53, 38);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 14;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(53, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(28, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "F1";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(28, 41);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(19, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "F2";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(28, 67);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(19, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "F3";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 100);
			this.panel1.TabIndex = 19;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
			this.tabControl1.Location = new System.Drawing.Point(0, 32);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(504, 381);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 21;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.ouput);
			this.tabPage1.Location = new System.Drawing.Point(4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(496, 372);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label11);
			//this.tabPage2.Controls.Add(this.rl);
			//this.tabPage2.Controls.Add(this.listView1);
			//this.tabPage2.Controls.Add(this.listView2);
			//this.tabPage2.Controls.Add(this.listView3);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Location = new System.Drawing.Point(4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(496, 372);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.TabPage2Click);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(392, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 13);
			this.label11.TabIndex = 23;
			this.label11.Text = "результат";
			// 
			// rl
			// 
			//this.rl.AutoSize = true;
			//this.rl.Location = new System.Drawing.Point(392, 24);
			//this.rl.Name = "rl";
			//this.rl.Size = new System.Drawing.Size(85, 128);
			//this.rl.TabIndex = 22;
			// 
			// listView1
			// 
			//this.listView1.AutoSize = true;
			//this.listView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			//this.listView1.Location = new System.Drawing.Point(52, 24);
			//this.listView1.Name = "listView1";
			//this.listView1.Size = new System.Drawing.Size(85, 128);
			//this.listView1.TabIndex = 13;
			// 
			// listView2
			// 
			//this.listView2.AutoSize = true;
			//this.listView2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			//this.listView2.Location = new System.Drawing.Point(168, 24);
			//this.listView2.Name = "listView2";
			//this.listView2.Size = new System.Drawing.Size(85, 128);
			//this.listView2.TabIndex = 14;
			// 
			// listView3
			// 
			//this.listView3.AutoSize = true;
			//this.listView3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			//this.listView3.Location = new System.Drawing.Point(284, 24);
			//this.listView3.Name = "listView3";
			//this.listView3.Size = new System.Drawing.Size(85, 128);
			//this.listView3.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(284, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "на";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(168, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "все вхождения";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "заменить в";
			// 
			// log
			// 
			this.log.Location = new System.Drawing.Point(510, 61);
			this.log.Multiline = true;
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(188, 292);
			this.log.TabIndex = 22;
			this.log.WordWrap = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(713, 413);
			this.Controls.Add(this.log);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "LinkedListLab";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox log;
		//private DoubleLinkedListLab.ListView rl;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		//private DoubleLinkedListLab.ListView listView3;
		//private DoubleLinkedListLab.ListView listView2;
		//private DoubleLinkedListLab.ListView listView1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox ouput;
	}
}
