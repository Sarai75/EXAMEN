/*
 * Created by SharpDevelop.
 * User: CC2-PC18
 * Date: 31/10/2024
 * Time: 02:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Desviacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desviacion));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.labelMedia = new System.Windows.Forms.Label();
			this.labelDesviacion = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(99, 178);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(74, 20);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(205, 41);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(62, 20);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(67, 67);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(74, 20);
			this.textBox3.TabIndex = 5;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(205, 76);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(62, 20);
			this.textBox4.TabIndex = 6;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(131, 105);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(81, 20);
			this.textBox5.TabIndex = 7;
			// 
			// labelMedia
			// 
			this.labelMedia.Image = ((System.Drawing.Image)(resources.GetObject("labelMedia.Image")));
			this.labelMedia.Location = new System.Drawing.Point(297, 64);
			this.labelMedia.Name = "labelMedia";
			this.labelMedia.Size = new System.Drawing.Size(153, 23);
			this.labelMedia.TabIndex = 8;
			this.labelMedia.Text = "=";
			// 
			// labelDesviacion
			// 
			this.labelDesviacion.Image = ((System.Drawing.Image)(resources.GetObject("labelDesviacion.Image")));
			this.labelDesviacion.Location = new System.Drawing.Point(297, 102);
			this.labelDesviacion.Name = "labelDesviacion";
			this.labelDesviacion.Size = new System.Drawing.Size(153, 23);
			this.labelDesviacion.TabIndex = 9;
			this.labelDesviacion.Text = "=";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(67, -2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "INGRESE 5 NUMEROS";
			// 
			// Desviacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(462, 261);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelDesviacion);
			this.Controls.Add(this.labelMedia);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Desviacion";
			this.Text = "Desviacion";
			this.Load += new System.EventHandler(this.DesviacionLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelDesviacion;
		private System.Windows.Forms.Label labelMedia;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		
		void DesviacionLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}
