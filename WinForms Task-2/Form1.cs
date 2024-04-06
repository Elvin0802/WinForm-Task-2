using WinForms_Task_2.Models;

namespace WinForms_Task_2;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private void saveB_MouseClick(object sender, MouseEventArgs e)
	{
		if (nameT.Text == "" || surnameT.Text == "" || fNameT.Text == "" || cityT.Text == "" || countryT.Text == "" || phNumT.Text == "" || nameT.Text.All(c => c == ' ') || surnameT.Text.All(c => c == ' ') || fNameT.Text.All(c => c == ' ') || cityT.Text.All(c => c == ' ') || countryT.Text.All(c => c == ' ') || phNumT.Text.All(c => c == ' '))
		{
			MessageBox.Show("Butun Melumatlar Doldurulmalidir !", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			return;
		}


		User user = new(nameT.Text, surnameT.Text, fNameT.Text, countryT.Text, cityT.Text, phNumT.Text, birthDateT.Value, genderK.Checked);

		var res = JsonMethods.Write(user);

		if (res == 1)
			MessageBox.Show("Istifadechi Elave Olundu", "Save Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		else if (res == 2)
			MessageBox.Show("Istifadechi Error Sebebinden Elave Olunmadi", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		else if (res == 0)
			MessageBox.Show("Istifadechi Elave Olunmadi. Bu Adda Istifadechi Movcuddur. Zehmet Olmasa Bashqa Ad Daxil Edin.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

		nameT.Text = "";
		surnameT.Text = "";
		fNameT.Text = "";
		countryT.Text = "";
		cityT.Text = "";
		phNumT.Text = "";
	}

	private void loadB_MouseClick(object sender, MouseEventArgs e)
	{
		if (loadName.Text.All(c => c == ' ') ||
			loadName.Text == string.Empty)
		{
			MessageBox.Show("Ad Daxil Edin !", "Load Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			return;
		}

		User? user = JsonMethods.Read(loadName.Text);

		if (user is null)
		{
			MessageBox.Show("Istifadechi Tapilmadi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		else
		{
			nameT.Text = user.Name;
			surnameT.Text = user.Surname;
			fNameT.Text = user.FatherName;
			countryT.Text = user.Country;
			cityT.Text = user.City;
			phNumT.Text = user.PhoneNum;
			birthDateT.Value = user.BirthDate;

			if (user.Gender)
				genderK.Checked = true;
			else
				genderQ.Checked = true;
		}
	}
}
