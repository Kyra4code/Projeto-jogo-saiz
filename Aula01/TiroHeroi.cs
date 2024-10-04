using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public class TiroHeroi: Personagem
	{
		public TiroHeroi()
		{
			Load("Armas/Tiros/fireball2.gif");
			Visible = false;
			delay.Enabled = true;
			delay.Interval = 100;
			delay.Tick += Tick;
		}
		Timer delay = new Timer();
		
		public void Tick(Object sender, EventArgs e){
			Left += 10;
			
			if(Left == 1200){
				delay.Enabled = false;
			}
		}
	}
}
