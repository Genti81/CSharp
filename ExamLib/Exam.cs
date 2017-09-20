using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {

        private string Ämne;

        Dictionary<Student, string> StudentToDictionary = new Dictionary<Student, string>();
        List < Student > StudentsList = new List<Student>();

        public Exam(string ämne)
        {
            this.Ämne = ämne;
        }

        public void Assign(Student student)
        {
            StudentToDictionary.Add(student, "G");
            StudentsList.Add(student);
        }

        public void Grade(Student student, string betyg)
        {
            StudentToDictionary[student] = betyg;
        }

        public void AreEqual(String statistics)
        {
            
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            Dictionary<string, int> VisaStatistik = new Dictionary<string, int>();

            VisaStatistik.Add("IG", 0);
            VisaStatistik.Add("G", 0);
            VisaStatistik.Add("VG", 0);

            foreach (var student in StudentToDictionary)
            {
                VisaStatistik[student.Value]++;
            }
            return VisaStatistik;
        }
    }
}
