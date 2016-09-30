/*
 * Created by SharpDevelop.
 * User: CYRUS
 * Date: 9/29/2016
 * Time: 1:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace wincal
{
	
	public partial class MainForm : Form
	{
		Double value = 0;
		string calsign = "";
		bool is_click = false;
		
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button7Click(object sender, EventArgs e)
		{
			if ((result.Text == "0") || (is_click)) {
				result.Clear();
			}
			Button b = (Button)sender;
			result.Text = result.Text + b.Text;
		}
		
		void operator_click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			calsign = b.Text;
			value = Double.Parse(result.Text);
			is_click = true;
			equation.Text = value + " " + calsign;
			
		}
		void Clear_buttonClick(object sender, EventArgs e)
		{
			result.Text = "0";
		}
		void Button22Click(object sender, EventArgs e)
		{
			equation.Text = "";
			
		switch (calsign)
	{
				case "+" :
					result.Text = (value + Double.Parse(result.Text)).ToString();
					break;
				case "*" :
					result.Text = (value * Double.Parse(result.Text)).ToString();
					break;
				case "/" :
					result.Text = (value / Double.Parse(result.Text)).ToString();
					break;
				case "-" :
					result.Text = (value - Double.Parse(result.Text)).ToString();
					break;
				default:
					break;
			}
			is_click = false;
			
		}
		void Button23Click(object sender, EventArgs e)
		{
			result.Clear();
			
		}
		
		
	}
}
