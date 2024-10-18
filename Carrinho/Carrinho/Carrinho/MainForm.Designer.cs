/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 17/10/2024
 * Time: 21:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Carrinho
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox Fundo;
		private System.Windows.Forms.PictureBox Estrada;
		private System.Windows.Forms.PictureBox Carro;
		private System.Windows.Forms.PictureBox Arvore;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Fundo = new System.Windows.Forms.PictureBox();
			this.Estrada = new System.Windows.Forms.PictureBox();
			this.Carro = new System.Windows.Forms.PictureBox();
			this.Arvore = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Fundo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Estrada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Carro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Arvore)).BeginInit();
			this.SuspendLayout();
			// 
			// Fundo
			// 
			this.Fundo.BackColor = System.Drawing.Color.SkyBlue;
			this.Fundo.Image = ((System.Drawing.Image)(resources.GetObject("Fundo.Image")));
			this.Fundo.Location = new System.Drawing.Point(1, 0);
			this.Fundo.Name = "Fundo";
			this.Fundo.Size = new System.Drawing.Size(1270, 474);
			this.Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Fundo.TabIndex = 0;
			this.Fundo.TabStop = false;
			// 
			// Estrada
			// 
			this.Estrada.Image = ((System.Drawing.Image)(resources.GetObject("Estrada.Image")));
			this.Estrada.Location = new System.Drawing.Point(1, 427);
			this.Estrada.Name = "Estrada";
			this.Estrada.Size = new System.Drawing.Size(1270, 124);
			this.Estrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Estrada.TabIndex = 1;
			this.Estrada.TabStop = false;
			// 
			// Carro
			// 
			this.Carro.BackColor = System.Drawing.Color.Transparent;
			this.Carro.Image = ((System.Drawing.Image)(resources.GetObject("Carro.Image")));
			this.Carro.Location = new System.Drawing.Point(27, 427);
			this.Carro.Name = "Carro";
			this.Carro.Size = new System.Drawing.Size(192, 61);
			this.Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Carro.TabIndex = 2;
			this.Carro.TabStop = false;
			// 
			// Arvore
			// 
			this.Arvore.Image = ((System.Drawing.Image)(resources.GetObject("Arvore.Image")));
			this.Arvore.Location = new System.Drawing.Point(906, 427);
			this.Arvore.Name = "Arvore";
			this.Arvore.Size = new System.Drawing.Size(163, 95);
			this.Arvore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Arvore.TabIndex = 3;
			this.Arvore.TabStop = false;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.Silver;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(544, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 41);
			this.button1.TabIndex = 4;
			this.button1.Text = "Iniciar/Reiniciar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1271, 534);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Arvore);
			this.Controls.Add(this.Carro);
			this.Controls.Add(this.Estrada);
			this.Controls.Add(this.Fundo);
			this.Name = "MainForm";
			this.Text = "Carrinho";
			((System.ComponentModel.ISupportInitialize)(this.Fundo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Estrada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Carro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Arvore)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
