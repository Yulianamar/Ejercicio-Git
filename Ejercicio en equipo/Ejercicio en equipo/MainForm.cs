/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 04/11/2026
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_en_equipo
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
		
		void BtnIngresarClick(object sender, EventArgs e)
		{
			if(txtNombre.Text == "Admin" && txtContraseña.Text == "1234"){
				MessageBox.Show("Bienvenido al sistema");
				MenuPrincipal f = new MenuPrincipal();
				this.Hide();
				f.Show();
			}
			else
			{
				MessageBox.Show("El usuario o contraseña es incorrecto.");
			}
		}
	}
}
