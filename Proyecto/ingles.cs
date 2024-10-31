/*
 * Created by SharpDevelop.
 * User: CC1-PC21
 * Date: 31/10/2024
 * Time: 10:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace Proyecto
{
	/// <summary>
	/// Description of ingles.
	/// </summary>
	public partial class ingles : Form
	{
		public ingles()
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