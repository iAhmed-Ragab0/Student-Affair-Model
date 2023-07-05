namespace StudentAffairModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course crs1 = new Course() { Id = 1, Name = "C#" };
            Course crs2 = new Course() { Id = 2, Name = "ASP.NET" };
            Course crs3 = new Course() { Id = 3, Name = "Angular" };


            StudentAffair studentAffair = new StudentAffair();


            //accepted students
            Student std1 = new Student()
            {
                ID = 2,
                Name = "Ahmed",
            };
            Student std2 = new Student()
            {
                ID = 2,
                Name = "mohamed",
               
            };
            Student std3 = new Student()
            {
                ID = 3,
                Name = "Mahmoud",
            };
            Student std4 = new Student()
            {
                ID = 4,
                Name = "ALi",
            };
            Student std5 = new Student()
            {
                ID = 5,
                Name = "Sayed",
            };

            //rejected students
            Student std6 = new Student() { ID = 1, Name = "sara" };
            Student std7 = new Student() { ID = 2, Name = "ola" };


            studentAffair.AddStudent(std1);
            std1.AbsentDays = 10;

            studentAffair.AddStudent(std2);
            std2.AbsentDays = 11;

            studentAffair.AddStudent(std3);
            std3.Courses = new Dictionary<Course, bool?>() { { crs1, false }, { crs2, false }, { crs3, null } };

            studentAffair.AddStudent(std4);
            std4.Courses = new Dictionary<Course, bool?>() { { crs1, null }, { crs2, false }, { crs3, false } };

            studentAffair.AddStudent(std5);
            std5.AbsentDays = 8;


            Console.WriteLine("----- Student List ------");
            studentAffair.GetStudentList();

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("----- Fired List ------");
            studentAffair.GetFiredStudents();



        }
    }
}