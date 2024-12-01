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
			checkVida.Enabled = true;
			checkVida.Tick += timerCheckInfos;
			checkVida.Interval = 200;
		}
		
		//Instância das informações que apareceram na tela
		Label vida = new Label();
		Label damage = new Label();
		Label def = new Label();
		Timer checkVida = new Timer();
		
		//Criação de variávies publicas e privadas com informações de ataque vida e defesa do personagem
		public int hpHeroi = 1000;
		public int dano = 120;
		public int defHeroi = 5;
		
		//Eu estou criando um timer nas informações para caso eu adiciono itens de buffs eles irão se atualizar automaticamente		
		void timerCheckInfos(Object sender, EventArgs e){
			vida.Parent = MainForm.telaFundo;
			vida.Text = "vida: " + hpHeroi;
			vida.BackColor = Color.Transparent;
			vida.ForeColor = Color.White;
			vida.Top = 700;
			damage.Parent = MainForm.telaFundo;
			damage.Top = 680;
			damage.Text = "Poder: " + dano;
			damage.BackColor = Color.Transparent;
			damage.ForeColor = Color.White;
			def.Parent = MainForm.telaFundo;
			def.Top = 660;
			def.Text = "Defesa: " + defHeroi;
			def.BackColor = Color.Transparent;
			def.ForeColor = Color.White;
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
			
			if(Left >= 1450){
				Left = 1450;
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
