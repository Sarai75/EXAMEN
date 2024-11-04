/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 3/11/2024
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fisica
{
	/// <summary>
	/// Description of links.
	/// </summary>
	public partial class links : Form
	{
		public links()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://youtu.be/9yH_LiONXEo?si=H-9wJfNXJYMdO2n5");
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(" https://youtu.be/MbG-c9tlaX4?si=yhgR5Yihe9icfpgO");
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://youtu.be/86ZNmoAdlNg?si=fm6usr7-hWd6MRc9");
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://youtu.be/4a2vBFmTQe8?si=dOPKhAttjdBz9AVB");
		}
	}
}
