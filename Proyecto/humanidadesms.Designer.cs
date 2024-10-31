/*
 * Created by SharpDevelop.
 * User: J Sarai
 * Date: 30/10/2024
 * Time: 08:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class humanidadesms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(humanidadesms));
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(421, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(306, 150);
			this.label8.TabIndex = 12;
			this.label8.Text = resources.GetString("label8.Text");
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(306, 150);
			this.label7.TabIndex = 11;
			this.label7.Text = "Esta es una corriente de pensamiento cuya principal tesis es la separación concep" +
			"tual de moral y derecho, lo que supone un rechazo a una vinculación lógica o nec" +
			"esaria entre ambos.";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(455, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(239, 27);
			this.label6.TabIndex = 10;
			this.label6.Text = "IUSNATURALISMO";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(50, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 27);
			this.label5.TabIndex = 9;
			this.label5.Text = "IUSPOSITIVISMO\r\n";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(421, 275);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 123);
			this.label1.TabIndex = 16;
			this.label1.Text = "Esta es el conjunto de normas, valores y creencias que guían el comportamiento de" +
			" las personas en una sociedad, definiendo lo que se considera correcto o incorre" +
			"cto en esa cultura o grupo.";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(306, 119);
			this.label2.TabIndex = 15;
			this.label2.Text = "Esta es la rama de la filosofía que estudia los principios y valores que guían el" +
			" comportamiento humano para distinguir entre lo correcto y lo incorrecto.";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(532, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 27);
			this.label3.TabIndex = 14;
			this.label3.Text = "MORAL";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(105, 234);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 27);
			this.label4.TabIndex = 13;
			this.label4.Text = "ÉTICA";
			// 
			// humanidadesms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(771, 421);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Name = "humanidadesms";
			this.Text = "humanidadesms";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}
