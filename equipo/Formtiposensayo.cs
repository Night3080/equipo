﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 29/10/2024
 * Time: 08:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Formtiposensayo.
	/// </summary>
	public partial class Tiposensayo : Form
	{
		public Tiposensayo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnfilosoficoClick(object sender, EventArgs e)
		{
			Filosofico Formfilosofico = new Filosofico();
			Formfilosofico.Show();
		}
		
		void BtnliterarioClick(object sender, EventArgs e)
		{
			Literario Formliterario = new Literario();
			Formliterario.Show();
		}
		
		void BtnargumentativoClick(object sender, EventArgs e)
		{
			Argumentativo Formargumentativo = new Argumentativo();
			Formargumentativo.Show();
		}
		
		void BtncientificoClick(object sender, EventArgs e)
		{
			Cientifico Formcientifico = new Cientifico();
			Formcientifico.Show();
		}
	}
}
