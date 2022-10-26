using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void rowsButton_Click(object sender, EventArgs e)
		{
			int rows = GetRows();

			string type =TypeComboBox.Text.ToString() ;
			 
			string stars = Getstars(rows,type);
			
			resultTextBox.Text = stars;
		}

		//private string GetSeletedType()
		//{
		//	ComboBox control = this.TypeComboBox;
		//	object selectedtype = control.SelectedItem;
		//	return;
		//}

		private string Getstars(int rows, string type)
		{
			switch (type)
			{
				case "靠右":
					return GenerateStarsRight(rows);
				case "等腰":
					return GenerateStarsIso(rows);
				case "靠左":
					return GenerateStarsLeft(rows);
			}
			throw new Exception() ;
		}

		private string GenerateStarsRight(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', 2*(rows-i) ) +new string('*',i)+ "\r\n";
			}
			return result;
		}
		private string GenerateStarsLeft(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}
		private string GenerateStarsIso(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ',2* (rows-i)) + new string('*',2*i-1)+"\r\n";
			}
			return result;
		}

		private int GetRows()
		{
			string input = rowsTextBox.Text.ToString();
			bool isInt = int.TryParse(input, out int rows);
			if (isInt&&rows>0)
			{
				return rows;
			}
			else
			{
				throw new Exception() ;
			}
		}
	}
}
