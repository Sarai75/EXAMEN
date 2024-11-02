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
	/// Description of Desviacion.
	/// </summary>
	public partial class Desviacion : Form
	{
		public Desviacion()
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
			double[] numeros = new double[5];
                numeros[0] = Convert.ToDouble(textBox1.Text);
                numeros[1] = Convert.ToDouble(textBox2.Text);
                numeros[2] = Convert.ToDouble(textBox3.Text);
                numeros[3] = Convert.ToDouble(textBox4.Text);
                numeros[4] = Convert.ToDouble(textBox5.Text);
                
                double media = CalcularMedia(numeros);
                double desviacionMedia = CalcularDesviacionMedia(numeros, media);

                
                labelMedia.Text = "La media es: " +  media.ToString();
                labelDesviacion.Text = "La desviación media es:" + desviacionMedia.ToString();
		}
                
          
                private double CalcularMedia(double[] numeros)
        {
            return numeros.Average();
        }

        private double CalcularDesviacionMedia(double[] numeros, double media)
        {
            double sumaDesviaciones = numeros.Sum(num => Math.Abs(num - media));
            return sumaDesviaciones / numeros.Length;
        }
	}
}
