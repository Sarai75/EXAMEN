/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 30/10/2024
 * Time: 05:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Menor
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
			this.BtnCal = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnCal
			// 
			this.BtnCal.Location = new System.Drawing.Point(97, 115);
			this.BtnCal.Name = "BtnCal";
			this.BtnCal.Size = new System.Drawing.Size(107, 26);
			this.BtnCal.TabIndex = 0;
			this.BtnCal.Text = "Calcular";
			this.BtnCal.UseVisualStyleBackColor = true;
			this.BtnCal.Click += new System.EventHandler(this.BtnCalClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 60);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(255, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "=";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(71, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "INTRODUSCA 5 NUEMROS";
			// 
			// Menor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 175);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.BtnCal);
			this.Name = "Menor";
			this.Text = "Menor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button BtnCal;
	}
}
