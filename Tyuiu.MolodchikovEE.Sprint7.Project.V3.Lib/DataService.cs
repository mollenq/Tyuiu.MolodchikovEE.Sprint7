using System.Collections.Generic;

namespace Tyuiu.MolodchikovEE.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        private List<string> students;

        public DataService()
        {
            students = new List<string>();
        }
        public void AddStudent(string studentName)
        {
            if (!string.IsNullOrWhiteSpace(studentName))
            {
                students.Add(studentName);
            }
        }
        public List<string> GetStudents()
        {
            return new List<string>(students);
        }
    }
}