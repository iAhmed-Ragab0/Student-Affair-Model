using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairModel
{
    //subscriber
    internal class StudentAffair
    {
        private List<Student> studentList ;
        private Dictionary<Student,EventArgs> FiredStudents ;

        public StudentAffair()
        {
            studentList = new List<Student>();
            FiredStudents = new Dictionary<Student, EventArgs>();
        }

        public void AddStudent(Student student) 
        {
            studentList.Add(student);
            student.onStudentFired += RemoveStudent;
        }

        public void RemoveStudent(object sender,EventArgs Cause)
        {
            Student student = sender as Student;

            studentList.Remove(student);
            FiredStudents.Add(student,Cause);
        }

        public void GetStudentList() 
        {
            foreach (Student item in studentList)
            {
                Console.WriteLine(item);
            }
        }

        public void GetFiredStudents()
        {

            foreach (var item in FiredStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
