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
            Dictionary<string, int> GenStatistik = new Dictionary<string, int>();

            GenStatistik.Add("IG", 0);
            GenStatistik.Add("G", 0);
            GenStatistik.Add("VG", 0);

            foreach (var student in StudentToDictionary)
            {
                GenStatistik[student.Value]++;
            }
            return GenStatistik;
        }
    }
}
