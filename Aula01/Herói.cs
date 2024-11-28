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
			checkVida.Enabled = true;
			checkVida.Tick += timerCheckVida;
			checkVida.Interval = 200;
		}
		
		public int hpHeroi = 300;
		Label vida = new Label();
		Label damage = new Label();
		Label def = new Label();
		Timer checkVida = new Timer();
		
		public void timerCheckVida(Object sender, EventArgs e){
			vida.Parent = MainForm.telaFundo;
			vida.Text = "vida: " + hpHeroi;
			vida.BackColor = Color.Transparent;
			vida.ForeColor = Color.White;
			vida.Top = 600;
		}
	
		
		public void morte(){
			if(hpHeroi <= 0 ){
			Left = 9000;
			Dispose();
			}
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
				Left = 1150;
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
