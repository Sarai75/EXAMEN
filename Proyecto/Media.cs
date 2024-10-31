/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 30/10/2024
 * Time: 05:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Proyecto
{
	/// <summary>
	/// Description of Media.
	/// </summary>
	public partial class Media : Form
	{
		public Media()
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
			string[] numbersInput = TxtNumeros.Text.Split(',');
			int[] numbers = Array.ConvertAll(numbersInput, int.Parse);
			
			if (numbers.Length != 6)
			{
				MessageBox.Show("Por favor, ingrese exactamente 5 números separados por comas.");
                    return;
			}
			int sum = numbers.Sum();
			double media = (double)sum / numbers.Length;
			lblResultado.Text = "Media: " + media.ToString("F2");
		}
	}
}
