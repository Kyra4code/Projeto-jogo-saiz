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
			tempoCarga.Interval = 4500;
		}
		
		public static PictureBox telaFundo = new PictureBox();
		
		Timer tempoCarga = new Timer();
		public static Herói heroi = new Herói();
		ProgressBar balas = new ProgressBar();
		public static Enemy inimigo = new Enemy();
		Label vida = new Label();
		Label damage = new Label();
		Label def = new Label();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//Carregamento e configuração do Background
			telaFundo.Parent = this;
			telaFundo.Load("Cenarios/cenario0.gif");
			telaFundo.Height = this.Height;
			telaFundo.Width = this.Width;
			telaFundo.SizeMode = PictureBoxSizeMode.StretchImage;
			vida.Parent = MainForm.telaFundo;
			vida.Text = "Vida: " + heroi.hpHeroi;
			vida.Top = 550;
			vida.Height = 35;
			vida.Width = 35;
			vida.Left = 0;
			balas.Height = 35;
			balas.Width = 200;
			balas.Maximum = 3;
			balas.Top = 500;
			balas.Parent = telaFundo;
			balas.Value = 3;
		}
		
		void tempinho(Object sender, EventArgs e){
			vida.Text = "Vida: " + heroi.hpHeroi;
			if(balas.Value == 0){
				balas.Value = 3;
			}
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
				balas.Value -= 1;
				}
				}catch{}
			}
		}
		
	}
}
