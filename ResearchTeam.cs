using System;
// System Diagnostic StopWatch
namespace lab2
{
	class ResearchTeam : Team
	{
		string theme;
		TimeFrame duration;
		System.Collections.ArrayList papersList = new System.Collections.ArrayList();
		System.Collections.ArrayList personsList = new System.Collections.ArrayList();
		public ResearchTeam(string theme_value, string organization_value, int id_value, TimeFrame duration_value)
		{
			theme = theme_value;
			organization = organization_value;
			id = id_value;
			duration = duration_value;
		}
		public ResearchTeam()
		{
			theme = "IT";
			organization = "MIET";
			id = 1;
			duration = TimeFrame.Year;
			papersList = null;
			personsList = null;
		}
		public string Theme
		{
			get
			{
				return theme;
			}
			set
			{
				theme = value;
			}
		}
		public string Organization
		{
			get
			{
				return organization;
			}
			set
			{
				organization = value;
			}
		}
		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}
		public TimeFrame Duration
		{
			get
			{
				return duration;
			}
			set
			{
				duration = value;
			}
		}
		public System.Collections.ArrayList PapersList
		{
			get
			{
				return papersList;
			}
			set
			{
				papersList = value;
			}
		}
		public Paper Last
		{
			get
			{
				if (papersList == null)
					return null;
				else
				{
					//Paper[] list = new 
					Paper last = null;
					int i, index = 0;
					foreach (Paper item in papersList)
					{
						if (last == null)
                        {

                        }
						if (list[i].Release_date > last.Release_date)
						{
							index = i;
						}
					}
					return list[index];
				}
			}
		}
		public bool this[TimeFrame index]
		{
			get
			{
				return duration == index;
			}
		}
		public void AddPapers(params Paper[] newPapers)
		{
			Paper[] tempArray = new Paper[list.Length + newPapers.Length];
			int i = 0;
			foreach (Paper item in list)
			{
				tempArray[i] = item;
				i++;
			}

			foreach (Paper item in newPapers)
			{
				tempArray[i] = item;
				i++;
			}

			list = tempArray;
		}
		public virtual string ToShortString()
		{
			return "Тема " + theme + " Организация " + organization + " Номер регистрации " + id.ToString();
		}
		public override string ToString()
        {
			string temp = "Тема " + theme + " Организация " + organization + " Номер регистрации " + id.ToString() + " Продолжительность исследований: " + duration.ToString();
			if (list != null)
            {
				foreach (Paper item in list)
                {
					temp += item.ToString();
				}
            }
			return temp;
		}
		public static bool operator ==(ResearchTeam exmp1, ResearchTeam exmp2)
		{
			bool temp = exmp1.duration == exmp2.duration && exmp1.id == exmp2.id && exmp1.theme == exmp2.theme && exmp1.organization == exmp2.organization;
			if (exmp1.list.Length != exmp2.list.Length)
				return false;
			else
			{
				for (int i = 0; i < exmp1.list.Length; i++)
				{
					temp = temp && exmp1.list[i] == exmp2.list[i];
				}
				return temp;
			}
		}
		public static bool operator !=(ResearchTeam exmp1, ResearchTeam exmp2)
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
				return this == (ResearchTeam)exmp;
		}
	}
}	
