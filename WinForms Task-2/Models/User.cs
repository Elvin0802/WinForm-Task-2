namespace WinForms_Task_2.Models;

public class User
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string FatherName { get; set; }
	public string Country { get; set; }
	public string City { get; set; }
	public string PhoneNum { get; set; }
	public DateTime BirthDate { get; set; }
	public bool Gender { get; set; }

	public User(string name, string surname, string fatherName, string country, string city, string phoneNum, DateTime birthDate, bool gender)
	{
		Name=name;
		Surname=surname;
		FatherName=fatherName;
		Country=country;
		City=city;
		PhoneNum=phoneNum;
		BirthDate=birthDate;
		Gender=gender;
	}
}
