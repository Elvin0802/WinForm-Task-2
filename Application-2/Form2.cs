using System;
using System.Data;

namespace Application_2;

public partial class Form2 : Form
{

	public Form2()
	{
		InitializeComponent();
	}

	private void num1btn_Click(object sender, EventArgs e)
	{
		line.Text += "1";
	}

	private void num2btn_Click(object sender, EventArgs e)
	{
		line.Text += "2";
	}

	private void num3btn_Click(object sender, EventArgs e)
	{
		line.Text += "3";
	}

	private void num4btn_Click(object sender, EventArgs e)
	{
		line.Text += "4";
	}

	private void num5btn_Click(object sender, EventArgs e)
	{
		line.Text += "5";
	}

	private void num6btn_Click(object sender, EventArgs e)
	{
		line.Text += "6";
	}

	private void num7btn_Click(object sender, EventArgs e)
	{
		line.Text += "7";
	}

	private void num8btn_Click(object sender, EventArgs e)
	{
		line.Text += "8";
	}

	private void num9btn_Click(object sender, EventArgs e)
	{
		line.Text += "9";
	}

	private void num0btn_Click(object sender, EventArgs e)
	{
		line.Text += "0";
	}

	private void pointBtn_Click(object sender, EventArgs e)
	{
		if ((line.Text.Count(c => c == '.') < 1) ||
		(line.Text.Count
		(c => c == '.') <= line.Text.Count(c => c=='+' || c=='-'||c=='*' || c=='/')))
			line.Text += ".";
	}

	private void chnageMinusBtn_Click(object sender, EventArgs e)
	{
		if (line.Text.First() == '-')
		{
			line.Text = line.Text.Remove(0, 1);
			return;
		}

		string result = "-";
		result += line.Text;
		line.Text =  result;
	}

	private void additionalBtn_Click(object sender, EventArgs e)
	{
		line.Text += "+";
	}

	private void substractBtn_Click(object sender, EventArgs e)
	{
		line.Text += "-";
	}

	private void multipleBtn_Click(object sender, EventArgs e)
	{
		line.Text += "*";
	}

	private void divideBtn_Click(object sender, EventArgs e)
	{
		line.Text += "/";
	}

	private void equalBtn_Click(object sender, EventArgs e)
	{
		double result = Convert.ToDouble(new DataTable().Compute(line.Text, null));

		line.Text = result.ToString
		("0.############", System.Globalization.CultureInfo.InvariantCulture);
	}

	private void deleteEndDigitBtn_Click(object sender, EventArgs e)
	{
		try
		{
			line.Text = line.Text.Remove(line.Text.Length - 1);
		}
		catch { return; }
	}

	private void onlyClearBtn_Click(object sender, EventArgs e)
	{
		for (int c = line.Text.Length-1; c>=0; c--)
		{
			if (line.Text[c] == '+' || line.Text[c] == '-' ||
					line.Text[c] == '*' || line.Text[c] == '/')
				break;

			line.Text = line.Text.Remove(c);
		}
	}

	private void fullClearBtn_Click(object sender, EventArgs e)
	{
		line.Text = "";
	}

	private void piBtn_Click(object sender, EventArgs ea)
	{
		double pi = 3.1416;

		if (line.Text == "")
		{
			line.Text = pi.ToString("0.####",
			System.Globalization.CultureInfo.InvariantCulture);
		}
		else
		{
			line.Text = line.Text + "*" + pi.ToString("0.####",
						  System.Globalization.CultureInfo.InvariantCulture);
		}
	}

	private void eBtn_Click(object sender, EventArgs ea)
	{
		double e = 2.7189;

		if (line.Text == "")
		{
			line.Text = e.ToString("0.####",
				System.Globalization.CultureInfo.InvariantCulture);
		}
		else
		{
			line.Text = line.Text + "*" + e.ToString("0.####",
						  System.Globalization.CultureInfo.InvariantCulture);
		}
	}

	private void sqrtNumBtn_Click(object sender, EventArgs e)
	{
		line.Text = Math.Sqrt
			(Convert.ToDouble(new DataTable().Compute(line.Text, null)))
				.ToString();
	}

	private void to2PowBtn_Click(object sender, EventArgs e)
	{
		line.Text = Math.Pow
			(Convert.ToDouble(new DataTable().Compute(line.Text, null)), 2.0)
					.ToString();
	}
}
