using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aula01
{
	public class Herói: Personagem
	{
		public Herói()
		{
			this.Load("Personagens/Gargoyle.gif");
			this.Height = 70;
			this.Width = 70;
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.BackColor = Color.Transparent;
		}
	}
}
