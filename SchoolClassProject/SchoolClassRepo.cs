using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _schoolClasses;

        public SchoolClassRepo()
        {
            _schoolClasses = new List<SchoolClass>();
        }

        public List<SchoolClass> FindAll()
        {
            return _schoolClasses;
        }

        public void Add(SchoolClass schoolClass)
        {
            _schoolClasses.Add(schoolClass);
        }

        public string MostPaidSchoolClass()
        {
            if (!_schoolClasses.Any())
                return string.Empty;
            int max=FindAll().Select(schoolClass => schoolClass.ClassFee).Max();
            return FindAll().Where(schoolClass => schoolClass.ClassFee==max).First().ShortClassName;
        }

        public void FeePerSchoolClass()
        {
            foreach(SchoolClass schoolClass in _schoolClasses) 
            {
                int allSchoolClassFee = schoolClass.ClassFee * schoolClass.NumberOfStudent * 10;
                Console.WriteLine($"{schoolClass.ShortClassName} -> {allSchoolClassFee} Ft");
            }
        }

    }
}
