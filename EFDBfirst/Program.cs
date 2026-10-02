using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFDBfirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var context = new UniversityDBEntities();

            //Student student = new Student();

            //student.StudentID = 1;
            //student.FullName = "Ahmed";
            //student.Email = "ahmed@gmail.com";

            //var student = context.Students.Find(1);

            //context.Students.Remove(student);
            //context.SaveChanges();


            //context.Students.Add(student);
            //context.SaveChanges();


            //var course = context.Courses;

            //foreach (var item in course)
            //{
            //    Console.WriteLine(item.departmentID);

            //}
            //  --------------------------------------------------------------------

            //b1

            var courses = context.TeacherCourses
    .Include(tc => tc.Course)
    .Include(tc => tc.Course.Department)
    .Include(tc => tc.Teacher)
    .ToList();

            foreach (var item in courses)
            {
                Console.WriteLine(
                    $"{item.Course.Title} - " +
                    $"{item.Course.Department.Name} - " +
                    $"{item.Teacher.FullName}"
                );
            }


            //  -------------------------------------------------------------------
            // b2

            var student = context.Enrollments
                .Include(en => en.Student)
                .Include(en => en.Course);


            foreach (var item in student)
            {
                Console.WriteLine(
                   $"{item.Student.FullName} - " +
                   $"{item.Course.Title} - " +
                   $"{item.Grade}"
               );
            }



            //  -------------------------------------------------------------------
            // b3


            var teacher = context.Teachers
                .Include(te => te.Department);


            foreach (var item in teacher)
            {
                Console.WriteLine($"{item.FullName} "
                    + $" {item.Department.Name}");
            }


            //  -------------------------------------------------------------------
            // b4



            var department = context.Departments
                .Select(
                d => new
                {
                    depname = d.Name,
                    numofte = d.Teachers.Count,
                    numofc = d.Courses.Count,
                }).ToList();


            foreach (var item in department)
            {
                Console.WriteLine($"{item.depname}- "
                    + $" num of teachers is {item.numofte} -" +
                     $" num of courses {item.numofc}");
            }




            //  -------------------------------------------------------------------
            // b5







            //  -------------------------------------------------------------------
            // b6





            //  -------------------------------------------------------------------
            // c1



            var stc = context.Enrollments
            .FirstOrDefault(sc => sc.studentID == 7
                  && sc.courseID == 1);


            if (stc != null)
            {

                stc.Grade = 89;

                context.SaveChanges();

                Console.WriteLine("Grade updated successfully.");
            }
            else
            {
                Console.WriteLine("Student is not enrolled in this course.");
            }





            //  -------------------------------------------------------------------
            // c2



            var tec = context.Teachers
.FirstOrDefault(tc => tc.TeacherID == 3
      && tc.departmentID == 1);


            if (tec != null)
            {

                tec.departmentID = 2;

                context.SaveChanges();

                Console.WriteLine("department updated successfully.");
            }
            else
            {
                Console.WriteLine("department is not enrolled in this course.");
            }

            //  -------------------------------------------------------------------
            // c3


            var crh = context.Courses
             .FirstOrDefault(tc => tc.CourseID == 3);


            if (crh != null)
            {

                crh.Credits = 2;

                context.SaveChanges();

                Console.WriteLine("Credits updated successfully.");
            }
            else
            {
                Console.WriteLine("Credits is not enrolled in this course.");
            }

            //  -------------------------------------------------------------------
            // c4


            //same3

            //  -------------------------------------------------------------------
            // d1

            var rst = context.Students
          .FirstOrDefault(s => s.StudentID == 8);


            if (rst != null)
            {

                context.Enrollments.RemoveRange(rst.Enrollments);

                context.Students.Remove(rst);


                context.SaveChanges();

                Console.WriteLine("Student and related enrollments deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found");
            }









            //  -------------------------------------------------------------------
            // d2




            var dc = context.Courses
          .FirstOrDefault(s => s.CourseID == 3);


            if (dc != null)
            {
                bool hasStudents = dc.Enrollments.Any();

                if (!hasStudents)
                {
                    context.TeacherCourses.RemoveRange(dc.TeacherCourses);

                    context.Courses.Remove(dc);


                    context.SaveChanges();
                }
                Console.WriteLine("course deleted successfully.");
            }






            //  -------------------------------------------------------------------
            // d3



        }


    }
}
