using System;
namespace lab2
{
	class Paper
	{
		public string Title {get; set;}
		public Person Author {get; set;}
		public DateTime Release_date {get; set;}
		public Paper()
		{
			Title = "Title";
			Author = new Person();
			Release_date = new DateTime (1999, 01, 01);
		}
		public Paper(string title_value, Person author_value, DateTime release_date_value)
		{
			Title = title_value;
			Author = author_value;
			Release_date = release_date_value;
		}
		public override string ToString()
		{
			return "Title: " + Title + " Author: " + Author.ToString() + " Relese date: " + Release_date.ToString();
		}
		public static bool operator==(Paper exmp1, Paper exmp2)
        {
			return exmp1.Author==exmp2.Author && exmp1.Title == exmp2.Title && exmp1.Release_date == exmp2.Release_date;
        }
		public static bool operator !=(Paper exmp1, Paper exmp2)
		{
			return !(exmp1==exmp2);
		}
		public override bool Equals(object exmp)
		{
			if (exmp == null)
				return false;
			if (exmp.GetType() != this.GetType())
				return false;
			else
				return this == (Paper)exmp;
		}
        public override int GetHashCode()
        {
            return Title.GetHashCode()^Author.GetHashCode()^Release_date.GetHashCode();
        }
    }
}	
