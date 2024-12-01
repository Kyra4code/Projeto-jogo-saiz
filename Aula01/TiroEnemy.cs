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
		int speed = 20;
		
		public void tickTiro(Object sender, EventArgs e){
			Left -= speed * direcao;
			if(Left < 0){
				destruir();
			}
			if(this.Bounds.IntersectsWith(MainForm.heroi.Bounds)){
				if(MainForm.heroi.hpHeroi < 199){
					MainForm.heroi.hpHeroi = 0;
				}else{
					MainForm.heroi.hpHeroi -= MainForm.inimigo.damageEnemy - MainForm.heroi.defHeroi;
				}
				MainForm.heroi.morte();
				destruir();
			}
		}
		
		public void destruir(){
			delay.Enabled = false;
			this.Dispose();
			Left = 6000;
		}
	}
}
