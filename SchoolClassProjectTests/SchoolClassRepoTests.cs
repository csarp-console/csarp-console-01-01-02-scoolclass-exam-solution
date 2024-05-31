using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class SchoolClassRepoTests
    {
        [TestMethod()]
        public void MostPaidSchoolClassTestAllDifferent()
        {
            SchoolClass a9 = new SchoolClass(9, "a", 7000, 26);
            SchoolClass b9 = new SchoolClass(9, "b", 8000, 28);
            SchoolClass c9 = new SchoolClass(9, "c", 9000, 28);
            SchoolClass d9 = new SchoolClass(9, "d", 6000, 28);
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
            schoolClassRepo.Add(a9);
            schoolClassRepo.Add(b9);
            schoolClassRepo.Add(c9);
            schoolClassRepo.Add(d9);

            string actaul = schoolClassRepo.MostPaidSchoolClass();
            string exptected= "9.c";

            Assert.AreEqual(actaul, exptected);            
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestFirst()
        {
            SchoolClass a9 = new SchoolClass(9, "a", 10000, 26);
            SchoolClass b9 = new SchoolClass(9, "b", 8000, 28);
            SchoolClass c9 = new SchoolClass(9, "c", 9000, 28);
            SchoolClass d9 = new SchoolClass(9, "d", 6000, 28);
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
            schoolClassRepo.Add(a9);
            schoolClassRepo.Add(b9);
            schoolClassRepo.Add(c9);
            schoolClassRepo.Add(d9);

            string actaul = schoolClassRepo.MostPaidSchoolClass();
            string exptected = "9.a";

            Assert.AreEqual(actaul, exptected);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestLast()
        {
            SchoolClass a9 = new SchoolClass(9, "a", 7000, 26);
            SchoolClass b9 = new SchoolClass(9, "b", 8000, 28);
            SchoolClass c9 = new SchoolClass(9, "c", 9000, 28);
            SchoolClass d9 = new SchoolClass(9, "d", 10000, 28);
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
            schoolClassRepo.Add(a9);
            schoolClassRepo.Add(b9);
            schoolClassRepo.Add(c9);
            schoolClassRepo.Add(d9);

            string actaul = schoolClassRepo.MostPaidSchoolClass();
            string exptected = "9.d";

            Assert.AreEqual(actaul, exptected);
        }

        [TestMethod()]
        public void MostPaidSchoolClassAllSame()
        {
            SchoolClass a9 = new SchoolClass(9, "a", 7000, 26);
            SchoolClass b9 = new SchoolClass(9, "b", 7000, 28);
            SchoolClass c9 = new SchoolClass(9, "c", 7000, 28);
            SchoolClass d9 = new SchoolClass(9, "d", 7000, 28);
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
            schoolClassRepo.Add(a9);
            schoolClassRepo.Add(b9);
            schoolClassRepo.Add(c9);
            schoolClassRepo.Add(d9);

            string actaul = schoolClassRepo.MostPaidSchoolClass();
            string exptected = "9.a";

            Assert.AreEqual(actaul, exptected);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTwoSame()
        {
            SchoolClass a9 = new SchoolClass(9, "a", 10000, 26);
            SchoolClass b9 = new SchoolClass(9, "b", 7000, 28);
            SchoolClass c9 = new SchoolClass(9, "c", 10000, 28);
            SchoolClass d9 = new SchoolClass(9, "d", 7000, 28);
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
            schoolClassRepo.Add(a9);
            schoolClassRepo.Add(b9);
            schoolClassRepo.Add(c9);
            schoolClassRepo.Add(d9);

            string actaul = schoolClassRepo.MostPaidSchoolClass();
            string exptected = "9.a";

            Assert.AreEqual(actaul, exptected);
        }

        [TestMethod()]
        public void MostPaidSchoolClassEmptyList()
        {
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo();

            string actaul = schoolClassRepo.MostPaidSchoolClass();
            string exptected = "";

            Assert.AreEqual(actaul, exptected);
        }
    }
}