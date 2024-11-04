/*
 * Created by SharpDevelop.
 * User: dulce
 * Date: 3/11/2024
 * Time: 14:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fisica
{
	/// <summary>
	/// Description of problemas.
	/// </summary>
	public partial class problemas : Form
	{
		public problemas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		 string[] preguntas = { "La fu." };
		 string[] respuestas1={ "Masa por aceleración", "Velocidad por tiempo", "Fuerza por distancia" };
		 string[] respuestas2={ "Variación de velocidad entre tiempo", "Distancia entre tiempo", "Aceleración por tiempo" };
		 string[] respuestas3={ "A toda acción corresponde una reacción igual y opuesta", "La fuerza es igual a la masa por la aceleración", "La energía se conserva"};
         string[] bien= {"C- Continua en movimiento a una velocidad constante en línea recta","C- El objeto experimenta una aceleración proporcional a la fuerza aplicada","C- Para cada acción, hay una reacción igual y opuesta"};
         int aciertos=0;
         int act=0;
		void Button1Click(object sender, EventArgs e)
		{
			 string usuario1=comboBox1.SelectedItem.ToString();
			 string usuario2=comboBox2.SelectedItem.ToString();
			 string usuario3=comboBox3.SelectedItem.ToString();

            // Comparar con la respuesta correcta
            if (usuario1==bien[act] && usuario2==bien[act] && usuario3==bien[act])
            {
                aciertos++;
                MessageBox.Show("¡Correcto! ¡¡FELIICIDADES!!");
            }
            else
            {
                MessageBox.Show("Incorrecto.");
            }
        }
		void Button2Click(object sender, EventArgs e)
		{
			comboBox1.Text="";
			comboBox2.Text="";
			comboBox3.Text="";
		}
		}
	}

