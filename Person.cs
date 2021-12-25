using System;
namespace lab2
{
	class Person
	{
		string name;
		string surname;
		DateTime birthday;
		public Person(string name_value, string surname_value, DateTime birthday_value)
		{
			name = name_value;
			surname = surname_value;
			birthday = birthday_value;
		}
		public Person()
		{
			name = "Jhon";
			surname = "Brown";
			birthday = new DateTime(1961,04,12);
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public string Surname
		{
			get
			{
				return surname;
			}
			set
			{
				surname = value;
			}
		}
		public DateTime Birthday
		{
			get
			{
				return birthday;
			}
			set
			{
				birthday = value;
			}
		}
		public int BirthdayYear
		{
			get
			{
				return birthday.Year;
			}
			set
			{
				birthday = new DateTime(value, birthday.Month, birthday.Day);
			}
		}
		public override string ToString()
		{
			return "Name: " + name + " Surname: " + surname + " Birthday " + birthday.ToString();
		}
		public virtual string ToShortString()
		{

			return "Name: " + name + " Surname: " + surname;
		}
		public static bool operator==(Person exmp1, Person exmp2)
        {
			return exmp1.name.Equals(exmp2.name) && exmp1.surname.Equals(exmp2.surname) && exmp1.birthday.Equals(exmp2.birthday);
        }
		public static bool operator!=(Person exmp1, Person exmp2)
        {
			return !(exmp1 == exmp2);
        }
		public override bool Equals(object exmp)
        {
			if (exmp == null)
				return false;
			if (exmp.GetType() != this.GetType())
				return false;
			else
				return this == (Person)exmp;
        }
		public override int GetHashCode()
        {
			return name.GetHashCode() ^ surname.GetHashCode() ^ birthday.GetHashCode();
        }
		public virtual Person DeepCopy()
        {
			return new Person(name, surname, birthday);
        }
	}
}

