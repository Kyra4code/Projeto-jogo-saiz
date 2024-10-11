using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			//Quando o método for chamada, ele carrega todos esses comandos
			Width = 90;
			Height = 90;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.telaFundo;
		}
		
		public PictureBox x = new PictureBox();
		
		//Todo personagem que herdar de personagem terá esses dados disponíveis para uso
		public	int hp = 100;
		public	int xp = 0;
		public	int ataque = 15;
		public	int defesa = 10;
		public	int speed = 20;
		public int direcao = 1;
			
		
	}
}
