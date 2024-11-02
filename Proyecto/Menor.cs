﻿/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 30/10/2024
 * Time: 05:44 p. m.
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
	/// Description of Menor.
	/// </summary>
	public partial class Menor : Form
	{
		public Menor()
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
            int minNumber = numbers.Min();

                
            label1.Text = "Número menor: " + minNumber;
		}
	}
}
