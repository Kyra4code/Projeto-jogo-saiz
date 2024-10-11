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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//Carregamento e configuração do Background
			telaFundo.Parent = this;
			telaFundo.Load("Cenarios/cenario0.gif");
			telaFundo.Height = this.Height;
			telaFundo.Width = this.Width;
			telaFundo.SizeMode = PictureBoxSizeMode.StretchImage;
			
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			//Configuração da interação das teclas com o executável
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
				heroi.tiroH();
			}
		}
		
	}
}
