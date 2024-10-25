using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public class enemy:Personagem
	{
		public enemy()
		{
			Load("Personagens/Dragão/dragonEsq2.gif");
			Height = 200;
			Width = 200;
			Parent = MainForm.telaFundo;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Left = 1100;
			Top = 10;
			movimeto.Enabled = true;
			movimeto.Interval = 100;
			movimeto.Tick += movTop;
		}
		
		void movTop(object sender, EventArgs e){
			if(Top == 10){
				movimeto.Tick -= movTop;
				movimeto.Tick += movChao;
			}
			Top -= 20;
		}
		void movChao(object sender, EventArgs e){
			if(Top == 300){
				movimeto.Tick -= movChao;
				movimeto.Tick += movTop;
			}
			Top += 20;
		}
		
		Timer movimeto = new Timer();
		Timer tiro = new Timer();
		
		
	}
}
