﻿/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 01/11/2024
 * Time: 07:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Matematicas
{
	partial class Mayor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mayor));
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(85, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "INTRODUSCA 5 NUMEROS";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(113, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(187, 20);
			this.textBox1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(321, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "=";
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
			this.BtnCalcular.Location = new System.Drawing.Point(164, 108);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(117, 27);
			this.BtnCalcular.TabIndex = 4;
			this.BtnCalcular.Text = "Calcular";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// Mayor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(466, 165);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnCalcular);
			this.Name = "Mayor";
			this.Text = "Mayor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
	}
}
