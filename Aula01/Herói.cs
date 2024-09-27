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
			Load("Personagens/Herói/Gargoyle.gif");
			Height = 70;
			Width = 70;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
		}
		
		public void moveDir(){
			Left += speed;
			
			if(Left >= 1300){
				Left = 0;
			}
			if(direcao == 1){
				direcao = 1 ;
				Load("Personagens/Herói/Gargoyle.gif");
			}
		}
		public void moveEsq(){
			Left -= speed;
			
			if(Left <= 0){
				Left = 0;
			}
			if(direcao == 1){
				direcao = 1 ;
				Load("Personagens/Herói/GargoyleEsq.gif");
			}
		}
		public void moveTop(){
			Top += speed;
			
			if(Top >= 600){
				Top = 600;
			}
			if(direcao == 1){
				direcao = 1 ;
				Load("Personagens/Herói/Gargoyle.gif");
			}
		}
		public void moveChao(){
			Top -= speed;
			
			if(Top <= 0){
				Top = 0;
			}
			if(direcao == 1){
				direcao = 1 ;
				Load("Personagens/Herói/Gargoyle.gif");
			}
		}
	}
}
