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
				Info_Matematicas Form2=new Info_Matematicas();
				Form2.Show();
			}
			else if(selectedItem == "Materia Ingles")
			{
				Info_Ingles Form3= new Info_Ingles();
				Form3.Show();
			}
			else if(selectedItem == "Materia Fisica")
			{
				Info_Fisica Form4= new Info_Fisica();
				Form4.Show();
			}
			else if(selectedItem == "Materia Ecosistemas")
			{
				Info_Ecologia Form5= new  Info_Ecologia();
				Form5.Show();
			}
			else if(selectedItem == "Materia Humanidades")
			{
				Info_Humanidades Form6= new Info_Humanidades();
				Form6.Show();
			}
			else if(selectedItem == "Sobre Menu")
			{
				Info_Menu Form7= new Info_Menu();
				Form7.Show();
			}
		}
	}
}
