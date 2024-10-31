/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 30/10/2024
 * Time: 04:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of Matematicas.
	/// </summary>
	public partial class Matematicas : Form
	{
		public Matematicas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Promedio promedio= new Promedio();
			promedio.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Media media = new Media();
			media.Show();
		}
		
		
		void Button3Click(object sender, EventArgs e)
		{
			Moda moda = new Moda();
			moda.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Mayor mayor = new Mayor();
			mayor.Show();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Menor menor = new Menor();
			menor.Show();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Reprobados reprobados = new Reprobados();
			reprobados.Show();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			Aprobados aprobados= new Aprobados();
			aprobados.Show();
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			Desviacion desviacion = new Desviacion();
			desviacion.Show();
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			PromApro promapro= new PromApro();
			promapro.Show();
		}
	}
}
