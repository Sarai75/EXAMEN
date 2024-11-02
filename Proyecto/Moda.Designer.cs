/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 30/10/2024
 * Time: 05:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Moda
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnCal
			// 
			this.BtnCal.Location = new System.Drawing.Point(100, 174);
			this.BtnCal.Name = "BtnCal";
			this.BtnCal.Size = new System.Drawing.Size(75, 23);
			this.BtnCal.TabIndex = 0;
			this.BtnCal.Text = "Calcular";
			this.BtnCal.UseVisualStyleBackColor = true;
			this.BtnCal.Click += new System.EventHandler(this.BtnCalClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(215, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "=";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(84, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// Moda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnCal);
			this.Name = "Moda";
			this.Text = "Moda";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnCal;
	}
}
