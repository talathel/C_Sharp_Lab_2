using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Team
    {
        protected string organization;
        protected int id;
        public Team(string sValue, int iValue)
        {
            organization = sValue;
            id = iValue;
        }
        public Team()
        {
            organization = "MIET";
            id = 1;
        }
        public string Organization { get; set; }
        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Регистрационный номер обязан быть положительным");
                }
                id = value;
            }
        }
        public virtual Team DeepCopy()
        {
            return new Team(organization, id);
        }
        public interface INameAndCopy { };
        public static bool operator ==(Team exmp1, Team exmp2)
        {
            return exmp1.organization.Equals(exmp2.organization) && exmp1.id.Equals(exmp2.id);
        }
        public static bool operator !=(Team exmp1, Team exmp2)
        {
            return !(exmp1 == exmp2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            else
                return this == (Team)obj;
        }
        public override int GetHashCode()
        {
            return organization.GetHashCode()^id.GetHashCode();
        }
        public override string ToString()
        {
            return "Организация: " + organization + " ID: " + id.ToString() + "\n";
        }
    }
}
