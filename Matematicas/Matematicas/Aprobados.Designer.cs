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
	partial class Aprobados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aprobados));
			this.label7 = new System.Windows.Forms.Label();
			this.TxtHum = new System.Windows.Forms.TextBox();
			this.TxtEco = new System.Windows.Forms.TextBox();
			this.TxtFi = new System.Windows.Forms.TextBox();
			this.TxtIn = new System.Windows.Forms.TextBox();
			this.TxtMate = new System.Windows.Forms.TextBox();
			this.BtnCal = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.Location = new System.Drawing.Point(266, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 29);
			this.label7.TabIndex = 38;
			this.label7.Text = "=";
			// 
			// TxtHum
			// 
			this.TxtHum.Location = new System.Drawing.Point(154, 250);
			this.TxtHum.Name = "TxtHum";
			this.TxtHum.Size = new System.Drawing.Size(100, 20);
			this.TxtHum.TabIndex = 37;
			// 
			// TxtEco
			// 
			this.TxtEco.Location = new System.Drawing.Point(154, 208);
			this.TxtEco.Name = "TxtEco";
			this.TxtEco.Size = new System.Drawing.Size(100, 20);
			this.TxtEco.TabIndex = 36;
			// 
			// TxtFi
			// 
			this.TxtFi.Location = new System.Drawing.Point(154, 167);
			this.TxtFi.Name = "TxtFi";
			this.TxtFi.Size = new System.Drawing.Size(100, 20);
			this.TxtFi.TabIndex = 35;
			// 
			// TxtIn
			// 
			this.TxtIn.Location = new System.Drawing.Point(154, 120);
			this.TxtIn.Name = "TxtIn";
			this.TxtIn.Size = new System.Drawing.Size(100, 20);
			this.TxtIn.TabIndex = 34;
			// 
			// TxtMate
			// 
			this.TxtMate.Location = new System.Drawing.Point(154, 73);
			this.TxtMate.Name = "TxtMate";
			this.TxtMate.Size = new System.Drawing.Size(100, 20);
			this.TxtMate.TabIndex = 33;
			// 
			// BtnCal
			// 
			this.BtnCal.Image = ((System.Drawing.Image)(resources.GetObject("BtnCal.Image")));
			this.BtnCal.Location = new System.Drawing.Point(106, 285);
			this.BtnCal.Name = "BtnCal";
			this.BtnCal.Size = new System.Drawing.Size(75, 29);
			this.BtnCal.TabIndex = 32;
			this.BtnCal.Text = "Calcular";
			this.BtnCal.UseVisualStyleBackColor = true;
			this.BtnCal.Click += new System.EventHandler(this.BtnCalClick);
			// 
			// label6
			// 
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(28, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 29);
			this.label6.TabIndex = 31;
			this.label6.Text = "Humanidades";
			// 
			// label5
			// 
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(28, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 29);
			this.label5.TabIndex = 30;
			this.label5.Text = "Ecologia";
			// 
			// label4
			// 
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(28, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 29);
			this.label4.TabIndex = 29;
			this.label4.Text = "Fisica";
			// 
			// label3
			// 
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(28, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 29);
			this.label3.TabIndex = 28;
			this.label3.Text = "Ingles";
			// 
			// label2
			// 
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(28, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 29);
			this.label2.TabIndex = 27;
			this.label2.Text = "Matematicas";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 29);
			this.label1.TabIndex = 26;
			this.label1.Text = "INGRESE LAS CALIFICACIONES";
			// 
			// Aprobados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(375, 321);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TxtHum);
			this.Controls.Add(this.TxtEco);
			this.Controls.Add(this.TxtFi);
			this.Controls.Add(this.TxtIn);
			this.Controls.Add(this.TxtMate);
			this.Controls.Add(this.BtnCal);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Aprobados";
			this.Text = "Aprobados";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button BtnCal;
		private System.Windows.Forms.TextBox TxtMate;
		private System.Windows.Forms.TextBox TxtIn;
		private System.Windows.Forms.TextBox TxtFi;
		private System.Windows.Forms.TextBox TxtEco;
		private System.Windows.Forms.TextBox TxtHum;
		private System.Windows.Forms.Label label7;
	}
}
