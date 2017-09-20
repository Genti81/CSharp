using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {

        private string courseName;

        private Dictionary<Student, string> StudentGradeToDictionary = new Dictionary<Student, string>();
        List < Student > StudentsList = new List<Student>();

        public Exam(string courseName)
        {
            this.courseName = courseName;
        }

        public void Assign(Student student)
        {
            StudentGradeToDictionary.Add(student, "");
            StudentsList.Add(student);
        }

        public void Grade(Student student, string betyg)
        {
            if (!StudentGradeToDictionary.ContainsKey(student))
                throw new UnassignedStudentException();
            StudentGradeToDictionary[student] = betyg;
        }

        public void AreEqual(String statistics)
        {
            
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            //Dictionary<string, int> VisaStatistik = new Dictionary<string, int>();
            var VisaStatistik = new Dictionary<string, int>();
            VisaStatistik.Add("IG", 0);
            VisaStatistik.Add("G", 0);
            VisaStatistik.Add("VG", 0);

            foreach (var studentGradeEntry in StudentGradeToDictionary)
            {
                VisaStatistik[studentGradeEntry.Value]++;
            }
            return VisaStatistik;
        }
    }
}
