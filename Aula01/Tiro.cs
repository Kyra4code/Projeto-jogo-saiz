using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public class TiroHeroi: PictureBox
	{
		public TiroHeroi()
		{
			//Carregar imagem no MainForm
			Load("Armas/Tiros/fireball2.gif");
			Width = 90;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.telaFundo;
			Visible = false;

			//Oque faz em um espaço de tempo definido
			delay.Enabled = true;
			delay.Interval = 10;
			delay.Tick += Tick;
		}
		
		Timer delay = new Timer();
		public int dano = 10;
		public int direcao = 0;
		
		public void Tick(Object sender, EventArgs e){
			Left += 10;
			
			if(Left > MainForm.telaFundo.Width ||  Left <= 0){
				delay.Enabled = false;
				Dispose();
			}
			
			if(this.Bounds.IntersectsWith(MainForm.inimigo.Bounds)){
				MainForm.inimigo.morte();
				this.Dispose();
			}
		}
	}
}