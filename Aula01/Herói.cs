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
			Parent = MainForm.telaFundo;
		}

		public void tiroH(){
			//Uma instância herói é carregada e configurada.
			TiroHeroi th = new TiroHeroi();
			th.Visible = true;
			th.Left = Left + 70;
			th.Top = Top + 10;
		}
		
		public void moveDir(){
			//Movimmento da lateral direita do personagem herói
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
			//Movimmento da lateral esquerda do personagem herói
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
			//Movimmento de cima do personagem herói
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
			//Movimmento para baixo do personagem herói
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
