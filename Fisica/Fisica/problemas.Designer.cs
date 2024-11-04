/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 3/11/2024
 * Time: 14:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Fisica
{
	partial class problemas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(problemas));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(15, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(789, 378);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"A- Se detiene de inmediato",
			"B- Acelera constantemente",
			"C- Continua en movimiento a una velocidad en linea recta",
			"D.Cambia de direccion"});
			this.comboBox1.Location = new System.Drawing.Point(51, 118);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(268, 24);
			this.comboBox1.TabIndex = 1;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"A- La masa del objeto aumenta",
			"B- El objeto se mueve en circulos",
			"C- El objeto experimenta una aceleración",
			"D- El objeto sigue en reposo"});
			this.comboBox2.Location = new System.Drawing.Point(51, 239);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(268, 24);
			this.comboBox2.TabIndex = 2;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
			"A- Cada fuerza resulta en una aceleración",
			"B- La fuerza es proporcional a la masa ",
			"C- Para cada acción, hay una reacción",
			"D- Las fuerzas siempre actúan en pares paralelos"});
			this.comboBox3.Location = new System.Drawing.Point(51, 352);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(268, 24);
			this.comboBox3.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(473, 458);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 30);
			this.button1.TabIndex = 4;
			this.button1.Text = "VERIFICAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(177, 458);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(139, 30);
			this.button2.TabIndex = 5;
			this.button2.Text = "BORRAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Castellar", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(15, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(523, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "RESUELVE LOS SIGUIENTES PROBLEMAS:";
			// 
			// problemas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(816, 511);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Name = "problemas";
			this.Text = "problemas";
			this.ResumeLayout(false);

		}
	}
}
