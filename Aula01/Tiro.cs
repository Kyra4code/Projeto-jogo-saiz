﻿using System;
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
		int direcao = 0;
		
		public void destruir(){
			Left = 9000;
			Dispose();
		}
		
		public void Tick(Object sender, EventArgs e){
			Left += 15;
			
			if(Left > MainForm.telaFundo.Width ||  Left <= 0){
				delay.Enabled = false;
				destruir();
			}
			
			if(this.Bounds.IntersectsWith(MainForm.inimigo.Bounds)){
				MainForm.inimigo.hpEnemy -= MainForm.heroi.dano - MainForm.inimigo.defEnemy;
				MainForm.inimigo.morte();
				destruir();
			}
		}
	}
}