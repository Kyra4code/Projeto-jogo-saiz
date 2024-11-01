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
		}
		public void morte(){
			Left -= 9000;
			this.Dispose();
			tiro.Tick -= tiroI;
		}
		
		Timer movimeto = new Timer();
		Timer tiro = new Timer();
		
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
