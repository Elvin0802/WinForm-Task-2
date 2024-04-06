namespace WinForms_Task_2;

partial class Form1
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
		loadName = new TextBox();
		loadB = new Button();
		anketG = new GroupBox();
		fNameT = new TextBox();
		phNumT = new TextBox();
		cityT = new TextBox();
		countryT = new TextBox();
		surnameT = new TextBox();
		nameT = new TextBox();
		birthDateT = new DateTimePicker();
		genderQ = new RadioButton();
		genderK = new RadioButton();
		city = new Label();
		birthD = new Label();
		telNum = new Label();
		gender = new Label();
		surname = new Label();
		fName = new Label();
		country = new Label();
		name = new Label();
		saveB = new Button();
		anketG.SuspendLayout();
		SuspendLayout();
		// 
		// loadName
		// 
		loadName.Location = new Point(126, 13);
		loadName.Margin = new Padding(4);
		loadName.Name = "loadName";
		loadName.PlaceholderText = "Enter Name for Load";
		loadName.Size = new Size(314, 36);
		loadName.TabIndex = 0;
		// 
		// loadB
		// 
		loadB.Location = new Point(452, 12);
		loadB.Name = "loadB";
		loadB.Size = new Size(120, 37);
		loadB.TabIndex = 2;
		loadB.Text = "Load";
		loadB.UseVisualStyleBackColor = true;
		loadB.MouseClick += loadB_MouseClick;
		// 
		// anketG
		// 
		anketG.Controls.Add(fNameT);
		anketG.Controls.Add(phNumT);
		anketG.Controls.Add(cityT);
		anketG.Controls.Add(countryT);
		anketG.Controls.Add(surnameT);
		anketG.Controls.Add(nameT);
		anketG.Controls.Add(birthDateT);
		anketG.Controls.Add(genderQ);
		anketG.Controls.Add(genderK);
		anketG.Controls.Add(city);
		anketG.Controls.Add(birthD);
		anketG.Controls.Add(telNum);
		anketG.Controls.Add(gender);
		anketG.Controls.Add(surname);
		anketG.Controls.Add(fName);
		anketG.Controls.Add(country);
		anketG.Controls.Add(name);
		anketG.Location = new Point(12, 72);
		anketG.Name = "anketG";
		anketG.Size = new Size(558, 439);
		anketG.TabIndex = 3;
		anketG.TabStop = false;
		anketG.Text = "Anket";
		// 
		// fNameT
		// 
		fNameT.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
		fNameT.Location = new Point(200, 117);
		fNameT.Name = "fNameT";
		fNameT.Size = new Size(352, 30);
		fNameT.TabIndex = 16;
		// 
		// phNumT
		// 
		phNumT.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
		phNumT.Location = new Point(200, 246);
		phNumT.Name = "phNumT";
		phNumT.Size = new Size(352, 30);
		phNumT.TabIndex = 15;
		// 
		// cityT
		// 
		cityT.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
		cityT.Location = new Point(200, 212);
		cityT.Name = "cityT";
		cityT.Size = new Size(352, 30);
		cityT.TabIndex = 14;
		// 
		// countryT
		// 
		countryT.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
		countryT.Location = new Point(200, 178);
		countryT.Name = "countryT";
		countryT.Size = new Size(352, 30);
		countryT.TabIndex = 13;
		// 
		// surnameT
		// 
		surnameT.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
		surnameT.Location = new Point(200, 81);
		surnameT.Name = "surnameT";
		surnameT.Size = new Size(352, 30);
		surnameT.TabIndex = 12;
		// 
		// nameT
		// 
		nameT.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
		nameT.Location = new Point(200, 42);
		nameT.Name = "nameT";
		nameT.Size = new Size(352, 30);
		nameT.TabIndex = 11;
		// 
		// birthDateT
		// 
		birthDateT.CustomFormat = "dd.MMMM.yyyy";
		birthDateT.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
		birthDateT.Format = DateTimePickerFormat.Custom;
		birthDateT.Location = new Point(200, 310);
		birthDateT.Name = "birthDateT";
		birthDateT.Size = new Size(352, 32);
		birthDateT.TabIndex = 10;
		birthDateT.Value = new DateTime(2024, 1, 1, 12, 1, 0, 0);
		// 
		// genderQ
		// 
		genderQ.AutoSize = true;
		genderQ.Location = new Point(402, 364);
		genderQ.Name = "genderQ";
		genderQ.Size = new Size(88, 32);
		genderQ.TabIndex = 9;
		genderQ.TabStop = true;
		genderQ.Text = "Qadin";
		genderQ.TextAlign = ContentAlignment.MiddleCenter;
		genderQ.UseVisualStyleBackColor = true;
		// 
		// genderK
		// 
		genderK.AutoSize = true;
		genderK.Checked = true;
		genderK.Location = new Point(266, 364);
		genderK.Name = "genderK";
		genderK.Size = new Size(76, 32);
		genderK.TabIndex = 8;
		genderK.TabStop = true;
		genderK.Text = "Kishi";
		genderK.TextAlign = ContentAlignment.MiddleCenter;
		genderK.UseVisualStyleBackColor = true;
		// 
		// city
		// 
		city.Location = new Point(32, 212);
		city.Name = "city";
		city.Size = new Size(90, 34);
		city.TabIndex = 7;
		city.Text = "Sheher";
		city.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// birthD
		// 
		birthD.Location = new Point(32, 310);
		birthD.Name = "birthD";
		birthD.Size = new Size(136, 34);
		birthD.TabIndex = 6;
		birthD.Text = "Dogum Tarixi";
		birthD.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// telNum
		// 
		telNum.Location = new Point(32, 246);
		telNum.Name = "telNum";
		telNum.Size = new Size(136, 34);
		telNum.TabIndex = 5;
		telNum.Text = "Tel Nomresi";
		telNum.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// gender
		// 
		gender.Location = new Point(32, 366);
		gender.Name = "gender";
		gender.Size = new Size(90, 34);
		gender.TabIndex = 4;
		gender.Text = "Cins";
		gender.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// surname
		// 
		surname.Location = new Point(32, 76);
		surname.Name = "surname";
		surname.Size = new Size(90, 34);
		surname.TabIndex = 3;
		surname.Text = "Soyad";
		surname.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// fName
		// 
		fName.Location = new Point(32, 110);
		fName.Name = "fName";
		fName.Size = new Size(90, 34);
		fName.TabIndex = 2;
		fName.Text = "Ata Adi";
		fName.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// country
		// 
		country.Location = new Point(32, 178);
		country.Name = "country";
		country.Size = new Size(90, 34);
		country.TabIndex = 1;
		country.Text = "Olke";
		country.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// name
		// 
		name.Location = new Point(32, 42);
		name.Name = "name";
		name.Size = new Size(90, 34);
		name.TabIndex = 0;
		name.Text = "Ad";
		name.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// saveB
		// 
		saveB.Location = new Point(30, 529);
		saveB.Name = "saveB";
		saveB.Size = new Size(521, 52);
		saveB.TabIndex = 4;
		saveB.Text = "Save";
		saveB.UseVisualStyleBackColor = true;
		saveB.MouseClick += saveB_MouseClick;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(12F, 28F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(582, 603);
		Controls.Add(saveB);
		Controls.Add(anketG);
		Controls.Add(loadB);
		Controls.Add(loadName);
		Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		Icon = (Icon)resources.GetObject("$this.Icon");
		Margin = new Padding(4);
		Name = "Form1";
		Text = "Anket Form";
		anketG.ResumeLayout(false);
		anketG.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private TextBox loadName;
	private Button loadB;
	private GroupBox anketG;
	private Button saveB;
	private Label name;
	private Label surname;
	private Label fName;
	private Label country;
	private Label city;
	private Label birthD;
	private Label telNum;
	private Label gender;
	private DateTimePicker birthDateT;
	private RadioButton genderQ;
	private RadioButton genderK;
	private TextBox phNumT;
	private TextBox cityT;
	private TextBox countryT;
	private TextBox surnameT;
	private TextBox nameT;
	private TextBox fNameT;
}
