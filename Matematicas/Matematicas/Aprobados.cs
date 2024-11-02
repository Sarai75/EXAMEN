/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 01/11/2024
 * Time: 07:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Matematicas
{
	/// <summary>
	/// Description of Aprobados.
	/// </summary>
	public partial class Aprobados : Form
	{
		public Aprobados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCalClick(object sender, EventArgs e)
		{
			decimal Matematicas = Convert.ToDecimal(TxtMate.Text);
            decimal Ingles = Convert.ToDecimal(TxtIn.Text);
            decimal Fisica = Convert.ToDecimal(TxtFi.Text);    
            decimal Ecologia = Convert.ToDecimal(TxtEco.Text);
            decimal Humanidades= Convert.ToDecimal(TxtHum.Text);
            
            decimal[] grades = { Matematicas, Ingles, Fisica, Ecologia, Humanidades };
            
            int Aprobados = 0;
            foreach (var grade in grades)
            	{
                    if (grade >= 6)
                        Aprobados++;
                }

                label7.Text = "Aprobados: " + Aprobados;
		}
	}
}
