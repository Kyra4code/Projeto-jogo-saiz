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
			tempoCarga.Enabled = true;
			tempoCarga.Tick += tempinho;
			tempoCarga.Interval = 5000;
		}
		
		public static PictureBox telaFundo = new PictureBox();
		
		Timer tempoCarga = new Timer();
		Herói heroi = new Herói();
		ProgressBar balas = new ProgressBar();
		public static enemy inimigo = new enemy();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//Carregamento e configuração do Background
			telaFundo.Parent = this;
			telaFundo.Load("Cenarios/cenario0.gif");
			telaFundo.Height = this.Height;
			telaFundo.Width = this.Width;
			telaFundo.SizeMode = PictureBoxSizeMode.StretchImage;
			balas.Height = 35;
			balas.Width = 200;
			balas.Top = 500;
			balas.Parent = telaFundo;
			balas.Value = 100;
		}
		
		void tempinho(Object sender, EventArgs e){
			balas.Value = 100;
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
				try{
				if(balas.Value != 0){
				heroi.tiroH();
				balas.Value -= 25;
				}
				}catch{}
			}
		}
		
	}
}
