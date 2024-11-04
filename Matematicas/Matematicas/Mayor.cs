/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 01/11/2024
 * Time: 07:32 p. m.
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
	/// Description of Mayor.
	/// </summary>
	public partial class Mayor : Form
	{
		public Mayor()
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
			string[] numbersInput = textBox1.Text.Split(',');
            int[] numbers = Array.ConvertAll(numbersInput, int.Parse);
            
            if (numbers.Length != 5)
            {
            	MessageBox.Show("Por favor, ingrese exactamente 5 números separados por comas.");
                    return;
            }
            int maxNumber = numbers.Max();
            label1.Text = "Número mayor: " + maxNumber;
            	


		}
	}
}
