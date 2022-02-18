using System.Globalization;

namespace WorkingWithFiles.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmploye)
        {
            string[] vect = csvEmploye.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(obj is not Employee)
            {
                throw new ArgumentException("Comparing error: argument is not");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}

