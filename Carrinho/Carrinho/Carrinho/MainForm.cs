using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Carrinho
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			//Config Carro
			Carro.Parent = Estrada;
			Carro.Left = 0;
			Carro.Top = 5;
			Carro.BackColor = Color.Transparent;
			
			//Config Arvore
			Arvore.Parent = Estrada;
			Arvore.Left = 579;
			Arvore.Top = 0;
			Arvore.BackColor = Color.Transparent;
		}
		void Button1Click(object sender, EventArgs e){
			Carro.Left = 0;
			Carro.Load("Lamborghini2.png");
			timer1.Enabled = true;
			timer1.Interval = 10;
		}
		void Timer1Tick(object sender, EventArgs e){
			Carro.Left += 15;
			
			if(Carro.Left >= 620){
				timer1.Enabled = false;
			}
			if(Carro.Bounds.IntersectsWith(Arvore.Bounds)){
				timer1.Enabled = false;
				Carro.Load("carroAmassado2.png");
				Carro.Left = Arvore.Left - 140;
				MessageBox.Show("Bateuuuu");
			}
		}
	}
}
