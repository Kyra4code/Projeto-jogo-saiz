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
			Height = 90;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.telaFundo;
			Visible = false;

			//Oque faz em um espaço de tempo definido
			delay.Enabled = true;
			delay.Interval = 40;
			delay.Tick += Tick;
		}
		Timer delay = new Timer();
		
		public void Tick(Object sender, EventArgs e){
			Left += 7;
			
			if(Left == 1200){
				delay.Enabled = false;
			}
		}
	}
}