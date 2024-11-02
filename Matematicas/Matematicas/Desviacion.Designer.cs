/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 01/11/2024
 * Time: 07:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Matematicas
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
			this.label2 = new System.Windows.Forms.Label();
			this.labelDesviacion = new System.Windows.Forms.Label();
			this.labelMedia = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(48, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "INGRESE 5 NUMEROS";
			// 
			// labelDesviacion
			// 
			this.labelDesviacion.Image = ((System.Drawing.Image)(resources.GetObject("labelDesviacion.Image")));
			this.labelDesviacion.Location = new System.Drawing.Point(278, 113);
			this.labelDesviacion.Name = "labelDesviacion";
			this.labelDesviacion.Size = new System.Drawing.Size(153, 23);
			this.labelDesviacion.TabIndex = 18;
			this.labelDesviacion.Text = "=";
			// 
			// labelMedia
			// 
			this.labelMedia.Image = ((System.Drawing.Image)(resources.GetObject("labelMedia.Image")));
			this.labelMedia.Location = new System.Drawing.Point(278, 75);
			this.labelMedia.Name = "labelMedia";
			this.labelMedia.Size = new System.Drawing.Size(153, 23);
			this.labelMedia.TabIndex = 17;
			this.labelMedia.Text = "=";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(112, 116);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(81, 20);
			this.textBox5.TabIndex = 16;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(186, 87);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(62, 20);
			this.textBox4.TabIndex = 15;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(48, 78);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(74, 20);
			this.textBox3.TabIndex = 14;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(186, 52);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(62, 20);
			this.textBox2.TabIndex = 13;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(48, 52);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(74, 20);
			this.textBox1.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(80, 189);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 40);
			this.button1.TabIndex = 11;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Desviacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(452, 260);
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
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label labelMedia;
		private System.Windows.Forms.Label labelDesviacion;
		private System.Windows.Forms.Label label2;
	}
}
