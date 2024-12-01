using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula01
{
	public class Enemy:Personagem
	{
		public Enemy()
		{
			Load("Personagens/Dragão/dragonEsq2.gif");
			Height = 110;
			Width = 110;
			Parent = MainForm.telaFundo;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Left = 1200;
			Top = 10;
			tiro.Enabled = true;
			tiro.Tick += tiroI;
			tiro.Interval = 900;
			movimeto.Interval = 5;
			movimeto.Tick += movimentacao;
			movimeto.Enabled = true;
			Infos.Enabled = true;
			Infos.Interval = 200;
			Infos.Tick += infos;			
		}
		
		Timer movimeto = new Timer();
		Timer tiro = new Timer();
		Timer Infos = new Timer();
		Label vida = new Label();
		Label damage = new Label();
		Label def = new Label();
		int direcao = 1;
		
		public int hpEnemy = 1;
		public int damageEnemy = 200;
		public int defEnemy = 10;
				
		public void morte(){
			if(hpEnemy <= 0){
				Visible = false;
				Left -= 9000;
				Dispose();
				tiro.Tick -= tiroI;	
			}
		}
		
		//Eu estou criando um timer nas informações para caso eu adiciono itens de buffs eles irão se atualizar automaticamente
		void infos(Object sender, EventArgs e){
			vida.Parent = MainForm.telaFundo;
			vida.Text = "vida: " + hpEnemy;
			vida.BackColor = Color.Transparent;
			vida.ForeColor = Color.White;
			vida.Top = 700;
			vida.Left = 1450;
			damage.Parent = MainForm.telaFundo;
			damage.Left = 1450;			
			damage.Top = 680;
			damage.Text = "Poder: " + damageEnemy;
			damage.BackColor = Color.Transparent;
			damage.ForeColor = Color.White;
			def.Parent = MainForm.telaFundo;
			def.Left = 1450;
			def.Top = 660;
			def.Text = "Defesa: " + defEnemy;
			def.BackColor = Color.Transparent;
			def.ForeColor = Color.White;
		}
		
		void movimentacao(Object sender, EventArgs e){
			Top += speed * direcao;
			
			if(Top >= 600){
				direcao = -1;
			}
			else if(Top <= 0){
				direcao = 1;
			}
		}
		
		void tiroI(Object sender, EventArgs e){
			TiroEnemy tiroi = new TiroEnemy();
			tiroi.Visible = true;
			tiroi.Left = Left + 70;
			tiroi.Top = Top + 10;
			if(tiroi.Bounds.IntersectsWith(MainForm.heroi.Bounds)){
				tiroi.destruir();
			}
		}
	}
}
