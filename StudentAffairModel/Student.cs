using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairModel
{
    //publisher
    internal class Student
    {
        int failedCourses;
        private int absentdays ;
        private Dictionary<Course, bool?> courses;

        //public  Action<Student,string> onStudentFired;
        public EventHandler<StudentFiredArgs> onStudentFired;


        public Student()
        {
            failedCourses= 0;
            absentdays=0 ;
            Courses = new Dictionary<Course, bool?>();
        }


        public int ID { get; set;} 
        public string Name { get; set; }

        public int AbsentDays 
        {
            get 
            {
                return this.absentdays; 
            }
            set {

                if (value > 0)
                {
                    this.absentdays += value;

                    if (this.absentdays >= 10)
                        onStudentFired?.Invoke(this,new StudentFiredArgs() { Cause = "Absent Days"});   
                }
                else
                {
                    Console.WriteLine($"absents cant be negative for {this.Name}");
                }

            }
        }

        public Dictionary<Course, bool?> Courses 
        { 
            get {
                return courses; 
            } 
            set {

                courses= value;
                foreach (var item in courses)
                {
                    if (item.Value == false)
                    {
                        this.failedCourses++;
                        if (failedCourses >=2)
                        {
                            onStudentFired?.Invoke(this, new StudentFiredArgs() { Cause = "Failed in 2 courses" });

                        }
                    }
                }
                 
            } 
        }




        public override string ToString()
        {
            return $"{ID}:{Name}:{AbsentDays}"; 
        }

    }
}
