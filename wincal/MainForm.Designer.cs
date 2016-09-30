/*
 * Created by SharpDevelop.
 * User: CYRUS
 * Date: 9/29/2016
 * Time: 1:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace wincal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
//		private System.Windows.Forms.Button Button_Click;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button clear_button;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label equation;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button18 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.clear_button = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.equation = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(157, 137);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(45, 45);
			this.button18.TabIndex = 0;
			this.button18.Text = "*";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.operator_click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(4, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 45);
			this.button1.TabIndex = 0;
			this.button1.Text = "7";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button7Click);
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(208, 86);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(45, 45);
			this.button21.TabIndex = 0;
			this.button21.Text = "1";
			this.button21.UseVisualStyleBackColor = true;
			// 
			// button23
			// 
			this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button23.Location = new System.Drawing.Point(208, 86);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(45, 45);
			this.button23.TabIndex = 0;
			this.button23.Text = "C";
			this.button23.UseVisualStyleBackColor = true;
			this.button23.Click += new System.EventHandler(this.Button23Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(157, 138);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(45, 45);
			this.button13.TabIndex = 0;
			this.button13.Text = "1";
			this.button13.UseVisualStyleBackColor = true;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(157, 189);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(45, 45);
			this.button12.TabIndex = 0;
			this.button12.Text = "+";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.operator_click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(106, 188);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(45, 45);
			this.button11.TabIndex = 0;
			this.button11.Text = ".";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button7Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(106, 137);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(45, 45);
			this.button9.TabIndex = 0;
			this.button9.Text = "3";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button7Click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(208, 36);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(45, 45);
			this.button17.TabIndex = 0;
			this.button17.Text = "1";
			this.button17.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(106, 86);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(45, 45);
			this.button4.TabIndex = 0;
			this.button4.Text = "6";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button7Click);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(157, 35);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(45, 45);
			this.button15.TabIndex = 0;
			this.button15.Text = "-";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.operator_click);
			// 
			// button22
			// 
			this.button22.Location = new System.Drawing.Point(208, 139);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(45, 94);
			this.button22.TabIndex = 0;
			this.button22.Text = "=";
			this.button22.UseVisualStyleBackColor = true;
			this.button22.Click += new System.EventHandler(this.Button22Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(55, 35);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 45);
			this.button2.TabIndex = 0;
			this.button2.Text = "8";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button7Click);
			// 
			// clear_button
			// 
			this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clear_button.Location = new System.Drawing.Point(208, 35);
			this.clear_button.Name = "clear_button";
			this.clear_button.Size = new System.Drawing.Size(45, 45);
			this.clear_button.TabIndex = 0;
			this.clear_button.Text = "CE";
			this.clear_button.UseVisualStyleBackColor = true;
			this.clear_button.Click += new System.EventHandler(this.Clear_buttonClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(106, 35);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 45);
			this.button3.TabIndex = 0;
			this.button3.Text = "9";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(55, 139);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(45, 45);
			this.button8.TabIndex = 0;
			this.button8.Text = "2";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button7Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(4, 188);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(96, 45);
			this.button10.TabIndex = 0;
			this.button10.Text = "0";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button7Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(4, 86);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(45, 45);
			this.button6.TabIndex = 0;
			this.button6.Text = "4";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button7Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(157, 87);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(45, 45);
			this.button14.TabIndex = 0;
			this.button14.Text = "/";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.operator_click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(55, 86);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(45, 45);
			this.button5.TabIndex = 0;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button7Click);
			// 
			// result
			// 
			this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.result.Location = new System.Drawing.Point(4, 4);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(249, 20);
			this.result.TabIndex = 1;
			this.result.Text = "0";
			this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(4, 139);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(45, 45);
			this.button7.TabIndex = 0;
			this.button7.Text = "1";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// equation
			// 
			this.equation.BackColor = System.Drawing.SystemColors.HighlightText;
			this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equation.Location = new System.Drawing.Point(4, 4);
			this.equation.Name = "equation";
			this.equation.Size = new System.Drawing.Size(96, 20);
			this.equation.TabIndex = 2;
			this.equation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 236);
			this.Controls.Add(this.equation);
			this.Controls.Add(this.result);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.clear_button);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
