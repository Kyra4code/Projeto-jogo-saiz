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
		}
		
		
		Timer movimeto = new Timer();
		Timer tiro = new Timer();
	}
}
