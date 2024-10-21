using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MolodchikovEE.Sprint7.Project.V3.Lib;
using System.Collections.Generic;

namespace Tyuiu.MolodchikovEE.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestAddStudent()
        {
            DataService dataService = new DataService();
            string studentName = "Иванов Иван";
            dataService.AddStudent(studentName);
            List<string> students = dataService.GetStudents();
            Assert.AreEqual(1, students.Count);
            Assert.AreEqual(studentName, students[0]);
        }

        [TestMethod]
        public void TestAddEmptyStudent()
        {
            DataService dataService = new DataService();
            dataService.AddStudent(string.Empty);
            List<string> students = dataService.GetStudents();
            Assert.AreEqual(0, students.Count);
        }
    }
}