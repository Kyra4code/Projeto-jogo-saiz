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
		
		Herói sla = new Herói();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			sla.Parent = this;
			sla.Left = 20;
			sla.Top = 20;
		}
		
	}
}
