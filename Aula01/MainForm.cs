using System;
using System.Timers;
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
		
		public static PictureBox telaFundo = new PictureBox();
		
		Herói heroi = new Herói();
		TiroHeroi th = new TiroHeroi();
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//Carregamento do fundo.
			telaFundo.Parent = this;
			telaFundo.Load("Cenarios/cenario0.gif");
			telaFundo.Height = this.Height;
			telaFundo.Width = this.Width;
			telaFundo.SizeMode = PictureBoxSizeMode.StretchImage;
			
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.D){
				heroi.moveDir();
			}
			else if(e.KeyCode == Keys.A){
				heroi.moveEsq();
			}
			else if(e.KeyCode == Keys.S){
				heroi.moveTop();
			}
			else if(e.KeyCode == Keys.W){
				heroi.moveChao();
			}
			
			if(e.KeyCode == Keys.Space){
				th.Visible = true;
				th.Left = heroi.Left + 70;
				th.Top = heroi.Top + 10;
				
			}
		}
		
	}
}
