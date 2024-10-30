/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 29/10/2024
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
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
		void ComboBox3SelectedIndexChanged(object sender, EventArgs e)
		{
    string selectedItem = comboBox3.SelectedItem.ToString();

    if (selectedItem == "Materia Matematicas")
    {
       Matematicas Form2= new Matematicas();
        Form2.Show();
    }
    else if(selectedItem == "Materia Ingles")
    {
        Ingles Form3= new Ingles();
        Form3.Show();
    }
    else if(selectedItem == "Materia Fisica")
    {
        Fisica Form4= new Fisica();
        Form4.Show();
    }
    else if(selectedItem == "Materia Ecologia")
    {
        Ecologia Form5= new Ecologia();
        Form5.Show();
    }
    else if(selectedItem == "Materia Ingles")
    {
        Humanidades Form6= new Humanidades();
        Form6.Show();
    }
		}
	}
}
