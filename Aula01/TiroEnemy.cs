using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public class TiroEnemy: PictureBox
	{
		public TiroEnemy()
		{
			Load("Armas/Tiros/forceball.gif");
			Width = 90;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.telaFundo;
			Visible = false;
			delay.Enabled = true;
			delay.Interval = 10;
			delay.Tick += tickTiro;
		}
		Timer delay = new Timer();
		public int direcao = 1;
		
		public void tickTiro(Object sender, EventArgs e){
			if(direcao == 1){
				Left -= 10;
			}else if(direcao == 0){
				Left += 10;
			}
			if(this.Left < 0){
				this.Dispose();
			}
			if(Bounds.IntersectsWith(MainForm.heroi.Bounds)){
				MainForm.heroi.morte();
				this.destruir();
			}
		}
		
		public void destruir(){
			delay.Enabled = false;
			this.Dispose();
			Left = 6000;
		}
	}
}
