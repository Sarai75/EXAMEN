/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 30/10/2024
 * Time: 05:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Proyecto
{
	/// <summary>
	/// Description of Moda.
	/// </summary>
	public partial class Moda : Form
	{
		public Moda()
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
			string[] numbersInput = textBox1.Text.Split(',');
            int[] numbers = Array.ConvertAll(numbersInput, int.Parse);
            
            if (numbers.Length != 5)
            {
            	MessageBox.Show("Por favor, ingrese exactamente 5 números separados por comas.");
                    return;
                    
            }
            var frequency = numbers.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
                int maxFrequency = frequency.Values.Max();
                
                var modes = frequency.Where(x => x.Value == maxFrequency).Select(x => x.Key).ToList();
                if (modes.Count == 1)
                {
                	label1.Text = "Moda: " + modes[0];
                }
		}
	}
}
