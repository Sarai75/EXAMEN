/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 01/11/2024
 * Time: 07:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Matematicas
{
	partial class Media
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
			this.label1 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.TxtNumeros = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(32, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(297, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "INTRODUSCA LOS 6 NUMEROS";
			// 
			// lblResultado
			// 
			this.lblResultado.Image = ((System.Drawing.Image)(resources.GetObject("lblResultado.Image")));
			this.lblResultado.Location = new System.Drawing.Point(294, 95);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 6;
			this.lblResultado.Text = "=";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
			this.btnCalcular.Location = new System.Drawing.Point(134, 109);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(98, 26);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// TxtNumeros
			// 
			this.TxtNumeros.Location = new System.Drawing.Point(98, 55);
			this.TxtNumeros.Name = "TxtNumeros";
			this.TxtNumeros.Size = new System.Drawing.Size(171, 20);
			this.TxtNumeros.TabIndex = 4;
			// 
			// Media
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(406, 191);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.TxtNumeros);
			this.Name = "Media";
			this.Text = "Media";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox TxtNumeros;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label1;
	}
}
