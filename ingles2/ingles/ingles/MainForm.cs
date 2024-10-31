/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 28/10/2024
 * Time: 08:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace ingles
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
				try
			{
				// Asegúrate de que la ruta del archivo sea correcta
				using (SoundPlayer player = new SoundPlayer(@"C:\Users\hproj\Downloads\audio.wav"))
				{
					player.Play();
				}
			}
				catch
			{
		}
	}
}
}