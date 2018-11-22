/*
 * Created by SharpDevelop.
 * User: vche
 * Date: 11/9/2018
 * Time: 12:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
 
namespace winapp1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Name = "label1";
			// 
			// comboBox1
			// 
			this.comboBox1.AllowDrop = true;
			this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
			resources.ApplyResources(this.comboBox1, "comboBox1");
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			resources.GetString("comboBox1.Items"),
			resources.GetString("comboBox1.Items1"),
			resources.GetString("comboBox1.Items2"),
			resources.GetString("comboBox1.Items3"),
			resources.GetString("comboBox1.Items4"),
			resources.GetString("comboBox1.Items5"),
			resources.GetString("comboBox1.Items6"),
			resources.GetString("comboBox1.Items7")});
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// dateTimePicker1
			// 
			resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LightYellow;
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Value = new System.DateTime(2018, 11, 5, 0, 0, 0, 0);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.SystemColors.Info;
			this.numericUpDown1.DecimalPlaces = 4;
			resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
			this.numericUpDown1.Increment = new decimal(new int[] {
			1,
			0,
			0,
			131072});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.BackColor = System.Drawing.SystemColors.Info;
			this.numericUpDown2.DecimalPlaces = 2;
			resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
			this.numericUpDown2.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericUpDown2.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Value = new decimal(new int[] {
			100,
			0,
			0,
			0});
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2ValueChanged);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightYellow;
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
	}
	}

