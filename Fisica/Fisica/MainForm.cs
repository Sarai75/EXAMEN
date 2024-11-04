/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 3/11/2024
 * Time: 14:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fisica
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
			problemas Form2=new problemas();
			Form2.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			links Form3=new links();
			Form3.Show();
		}
	}
}
