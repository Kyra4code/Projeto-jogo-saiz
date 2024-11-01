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
			Height = 200;
			Width = 200;
			Parent = MainForm.telaFundo;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Left = 1100;
			Top = 10;
			tiro.Enabled = true;
			tiro.Tick += tiroI;
			tiro.Interval = 900;
			movimeto.Interval = 5;
			movimeto.Tick += movimentacao;
			movimeto.Enabled = true;
		}
		public void morte(){
			Left -= 9000;
			this.Dispose();
			tiro.Tick -= tiroI;
		}
		
		Timer movimeto = new Timer();
		Timer tiro = new Timer();
		public int direcao = 0;
		
		public void movimentacao(Object sender, EventArgs e){
			if(direcao == 1 ){
				Top -= 5;
			}else if (direcao == 0){
				Top += 5;
			}
			
			if (this.Top > 300){
			    direcao = 0;
			}else if (this.Top  < 100){
				direcao = 1;
			}
		}
		
		public void tiroI(Object sender, EventArgs e){
			TiroEnemy tiroi = new TiroEnemy();
			tiroi.Visible = true;
			tiroi.Left = Left + 70;
			tiroi.Top = Top + 10;
			if(tiroi.Bounds.IntersectsWith(MainForm.heroi.Bounds)){
				tiroi.Dispose();
			}
		}
	}
}
