using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		Herói herio = new Herói();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			herio.Parent = this;
			herio.Left = 20;
			herio.Top = 20;
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.D){
				herio.Left += 15;
			}
			else if(e.KeyCode == Keys.A){
				herio.Left -= 15;
			}
			else if(e.KeyCode == Keys.S){
				herio.Top += 15;
			}
			else if(e.KeyCode == Keys.W){
				herio.Top -= 15;
			}
			if(e.KeyCode == Keys.D && e.KeyCode == Keys.LShiftKey){
				herio.Left += 100;
			}
			
		}
		
	}
}
