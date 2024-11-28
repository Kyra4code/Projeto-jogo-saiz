using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public class Enemy:Personagem
	{
		public Enemy()
		{
			Load("Personagens/Dragão/dragonEsq2.gif");
			Height = 110;
			Width = 110;
			Parent = MainForm.telaFundo;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Left = 1200;
			Top = 10;
			tiro.Enabled = true;
			tiro.Tick += tiroI;
			tiro.Interval = 900;
			movimeto.Interval = 5;
			movimeto.Tick += movimentacao;
			movimeto.Enabled = true;
		}
		
		Timer movimeto = new Timer();
		Timer tiro = new Timer();
		int direcao = 1;
		public int hpEnemy = 1000;
		
		public void morte(){
			if(hpEnemy <= 0){
				Left -= 9000;
				Dispose();
				tiro.Tick -= tiroI;	
			}
		}
		
		void movimentacao(Object sender, EventArgs e){
			Top += speed * direcao;
			
			if(Top >= 600){
				direcao = -1;
			}
			else if(Top <= 0){
				direcao = 1;
			}
		}
		
		void tiroI(Object sender, EventArgs e){
			TiroEnemy tiroi = new TiroEnemy();
			tiroi.Visible = true;
			tiroi.Left = Left + 70;
			tiroi.Top = Top + 10;
			if(tiroi.Bounds.IntersectsWith(MainForm.heroi.Bounds)){
				tiroi.destruir();
			}
		}
	}
}
