/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 30/10/2024
 * Time: 04:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of Promedio.
	/// </summary>
	public partial class Promedio : Form
	{
		public Promedio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double Matematicas=Convert.ToDouble(TxtMate.Text);
			double Fisica=Convert.ToDouble(TxtFi.Text);
			double Ingles=Convert.ToDouble(Txtin.Text);
			double Humanidades=Convert.ToDouble(TxtHum.Text);
			double Ecologia=Convert.ToDouble(TxtEco.Text);
			
			double Promedio=(Matematicas + Fisica + Ingles + Humanidades + Ecologia)/5;
			LblResultado.Text="="+ Promedio.ToString("F2");
				
            			
		}
	}
}
