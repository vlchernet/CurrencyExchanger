/*
 * Created by SharpDevelop.
 * User: vche
 * Date: 11/9/2018
 * Time: 12:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;
using System.Windows.Forms;


namespace winapp1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		const string pattern = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=&&date=&&json";
		string link = "";
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
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string date = dateTimePicker1.Text.Replace(".", "");
			link = pattern;
			link = link.Replace("valcode=", "valcode=" + comboBox1.Text);
			link = link.Replace("date=", "date=" + date);
			Button1Click(sender, e);
		}
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			string currency = comboBox1.Text;
			string date = dateTimePicker1.Text.Replace(".", "");
			link = pattern;
			link = link.Replace("valcode=", "valcode=" + currency);
			link = link.Replace("date=", "date=" + date);
			Button1Click(sender, e);
		}
		void Button1Click(object sender, EventArgs e)
		{
			string html = Utility.ReadResponse(link);
			label1.Text = Utility.JsonParse(html);
			link = pattern;
            try
            {
                numericUpDown1.Value = Math.Round(Convert.ToDecimal(label1.Text, new CultureInfo("en-US")), 4);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Error: {0}", fex.Message);
            }

        }
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = Math.Round(numericUpDown1.Value * numericUpDown2.Value, 2).ToString();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			numericUpDown2.Value = Convert.ToDecimal(textBox1.Text, new CultureInfo("en-US")) / numericUpDown1.Value;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			dateTimePicker1.Value = DateTime.Today;
		}
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			Button2Click(sender, e);
		}
		void NumericUpDown1TextChanged(object sender, EventArgs e)
		{
			Button2Click(sender, e);
		}
		void NumericUpDown2ValueChanged(object sender, EventArgs e)
		{
			Button2Click(sender, e);
		}
		void NumericUpDown2TextChanged(object sender, EventArgs e)
		{
			Button2Click(sender, e);
		}
	}
}
