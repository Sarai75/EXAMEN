/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 29/10/2024
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Info_Ingles
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Ingles));
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(380, 337);
			this.label1.TabIndex = 1;
			this.label1.Text = "Elaborado Por\r\nAriana Quintino Guzman\r\n\r\nTercero de Programación\r\n\r\nFecha \r\n31 de" +
	" Octubre del 2024\r\n\r\nMateria: Medologías ágiles\r\n\r\nDocente: Luis Germán Gutiérre" +
	"z Torres\r\n";
			// 
			// Info_Ingles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(534, 448);
			this.Controls.Add(this.label1);
			this.Name = "Info_Ingles";
			this.Text = "Info_Ingles";
			this.ResumeLayout(false);

		}
	}
}
