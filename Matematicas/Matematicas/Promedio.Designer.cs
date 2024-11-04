/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 01/11/2024
 * Time: 07:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Matematicas
{
	partial class Promedio
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promedio));
			this.LblResultado = new System.Windows.Forms.Label();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.TxtEco = new System.Windows.Forms.TextBox();
			this.TxtHum = new System.Windows.Forms.TextBox();
			this.Txtin = new System.Windows.Forms.TextBox();
			this.TxtFi = new System.Windows.Forms.TextBox();
			this.TxtMate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LblResultado
			// 
			this.LblResultado.Image = ((System.Drawing.Image)(resources.GetObject("LblResultado.Image")));
			this.LblResultado.Location = new System.Drawing.Point(294, 138);
			this.LblResultado.Name = "LblResultado";
			this.LblResultado.Size = new System.Drawing.Size(100, 23);
			this.LblResultado.TabIndex = 23;
			this.LblResultado.Text = "=";
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
			this.BtnCalcular.Location = new System.Drawing.Point(119, 293);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
			this.BtnCalcular.TabIndex = 22;
			this.BtnCalcular.Text = "Calcular";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// TxtEco
			// 
			this.TxtEco.Location = new System.Drawing.Point(159, 245);
			this.TxtEco.Name = "TxtEco";
			this.TxtEco.Size = new System.Drawing.Size(100, 20);
			this.TxtEco.TabIndex = 21;
			// 
			// TxtHum
			// 
			this.TxtHum.Location = new System.Drawing.Point(159, 192);
			this.TxtHum.Name = "TxtHum";
			this.TxtHum.Size = new System.Drawing.Size(100, 20);
			this.TxtHum.TabIndex = 20;
			// 
			// Txtin
			// 
			this.Txtin.Location = new System.Drawing.Point(159, 141);
			this.Txtin.Name = "Txtin";
			this.Txtin.Size = new System.Drawing.Size(100, 20);
			this.Txtin.TabIndex = 19;
			// 
			// TxtFi
			// 
			this.TxtFi.Location = new System.Drawing.Point(159, 82);
			this.TxtFi.Name = "TxtFi";
			this.TxtFi.Size = new System.Drawing.Size(100, 20);
			this.TxtFi.TabIndex = 18;
			// 
			// TxtMate
			// 
			this.TxtMate.Location = new System.Drawing.Point(159, 30);
			this.TxtMate.Name = "TxtMate";
			this.TxtMate.Size = new System.Drawing.Size(100, 20);
			this.TxtMate.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(25, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Ecologia";
			// 
			// label4
			// 
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(25, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Humanidades";
			// 
			// label3
			// 
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(25, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Ingles";
			// 
			// label2
			// 
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(25, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Física";
			// 
			// label1
			// 
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(25, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Matematicas";
			// 
			// Promedio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(406, 328);
			this.Controls.Add(this.LblResultado);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.TxtEco);
			this.Controls.Add(this.TxtHum);
			this.Controls.Add(this.Txtin);
			this.Controls.Add(this.TxtFi);
			this.Controls.Add(this.TxtMate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Promedio";
			this.Text = "Promedio";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtMate;
		private System.Windows.Forms.TextBox TxtFi;
		private System.Windows.Forms.TextBox Txtin;
		private System.Windows.Forms.TextBox TxtHum;
		private System.Windows.Forms.TextBox TxtEco;
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.Label LblResultado;
	}
}
