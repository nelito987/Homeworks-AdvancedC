using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1To12
{
    class Problems1To12
    {
        static void Main(string[] args)
        {
            
            //Problem.1 Create a List<Student> with sample students
            List<Student> students = new List<Student>()
            {
                new Student("Danail", "Mateev", 30, 84241409, "+359 88 956 45 14", "didko@abv.bg",	new List<int>(){6, 4, 5, 6, 6, 5, 6, 6, 3, 6}, 2,"Yagodka"),
                new Student("Lora", "Stamatova", 28, 26253514, "+3592 976 85 75", "loreta@buzzfeed.com",	new List<int>(){3, 2, 5, 3, 4}, 1, "Chereshka"),
                new Student("Anton", "Gradev", 32, 24451413, "088 337 45 97", "toni23@abv.bg",	new List<int>(){6, 6, 5, 6, 6, 5, 6, 6, 6, 6}, 3, "Yagodka"),
                new Student("Sunny", "Ivanova", 33, 83245512, "02 337 45 45", "tweety@buzzfeed.com",	new List<int>(){3, 2, 5, 3, 2, 5, 3, 4, 6}, 2, "Smily"),
                new Student("Stanislav", "Todorov", 57, 29246511, "+3592 956 14 87", "slavi@skype.com",	new List<int>(){5, 4, 2, 3, 2, 5, 3, 3, 2}, 2, "Chereshka"),
                new Student("Valeri", "Yordanov", 38, 24354510, "+3592 337 75 87", "valYo@abv.bg",	new List<int>(){6, 4, 5, 3, 6, 6, 6, 5, 6, 6}, 3, "Smily"),
                new Student("Neli", "Ivanova", 26, 246514508, "+35988 976 97 45", "neliIvanova@yahoo.com",	new List<int>(){4, 5, 3, 3, 6, 3, 2, 5, 3}, 1, "Yagodka"),
                new Student("Nicola", "Borisov", 28, 541243509, "+359 2 279 45 75", "nicbor@link.com",	new List<int>(){3, 4, 2, 2, 5, 3}, 4, "Smily"),
                new Student("Denis", "Kolev", 19, 24543610, "+3592 279 97 14", "dencho@yahoo.com",	new List<int>(){6, 4, 5, 6, 6, 5, 3, 6}, 1, "Chereshka"),
                new Student("Yavor", "Yasenov", 49, 243614810, "088 279 45 87", "yayaya@marketwatch.com",	new List<int>(){4, 5, 5, 3, 2, 4, 5, 3, 2}, 4, "Chereshka"),
                new Student("Mikaela", "Danailova", 18, 24393504, "+359 88 310 97 75", "smills0@cyberchimps.com",	new List<int>(){4, 2, 2, 5, 3, 2, 5, 3, 4, 5}, 4, "Yagodka")
            };

            List<StudentSpecialty> specialties = new List<StudentSpecialty>()
            {
                new StudentSpecialty("QA Engineer", 84241409),
                new StudentSpecialty("Web Developer", 26253514),
                new StudentSpecialty("PHP Developer", 24451413),
                new StudentSpecialty("Web Developer", 83245512),
                new StudentSpecialty("PHP Developer", 29246511),
                new StudentSpecialty("Web Developer", 24354510),
                new StudentSpecialty("PHP Developer", 246514508),
                new StudentSpecialty("QA Engineer", 541243509),
                new StudentSpecialty("QA Engineer", 24543610),
                new StudentSpecialty("PHP Developer", 243614810),
                new StudentSpecialty("QA Engineer", 24393504)
            };

            PrintStudentsByGroup(students); //Problem 2
            StudentsByFirstAndLastName(students); //Problem 3
            StudentsByAge(students); //Problem 4
            SortStudents(students); //Problem 5
            FilterByEmail(students); //Problem 6
            FilterByPhone(students); //Problem 7
            ExcellentStudent(students); // Problem 8
            WeakStudents(students); //Problem 9
            EnrolledIn2014(students); //Problem 10
            StudentsByGroup(students); //Problem 11
            JoinedToSpecialties(students, specialties); //Problem 12

        }

        private static void PrintStudentsByGroup(List<Student> students)
        {
            //Problem 2. Print students by Group using LINQ
            Console.WriteLine("Students group 2:");
            List<Student> studentsGroupTwo = students.FindAll(student => student.GroupNumber == 2);

            foreach (var item in (studentsGroupTwo.OrderBy(name => name.FirstName)))
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();
        }

        private static void StudentsByFirstAndLastName(List<Student> students)
        {
            //Problem 3. Students by first and last name
            Console.WriteLine("Students whose first name is before their last name alphabetically:");
            List<Student> studentsNames = students.FindAll(student => student.FirstName[0] < student.LastName[0]);
            foreach (var item in studentsNames)
            {
                Console.WriteLine("{0} {1}",item.FirstName, item.LastName);
            }
            Console.WriteLine();
        }

        private static void StudentsByAge(List<Student> students)
        {
            //Problem 4.Students by age bewtween 18 and 24
            Console.WriteLine("Students by age bewtween 18 and 24:");

            List<Student> youngStudents = students.FindAll(student => (student.Age >= 18 && student.Age <= 24));
            foreach (var item in youngStudents)
            {
                Console.WriteLine("{0} {1} {2}",item.FirstName, item.LastName, item.Age);
            }
            Console.WriteLine();

            // Problem 4 using where
            var younger = from student in students
                          where student.Age >= 18 && student.Age <= 24
                          select new { student.FirstName, student.LastName, student.Age };
            foreach (var item in younger)
            {
                 Console.WriteLine("{0} {1} {2}",item.FirstName, item.LastName, item.Age);
            }
            Console.WriteLine();  
        }

        private static void SortStudents (List<Student> students)
        {
            Console.WriteLine("Sorted students using OrderBy() and ThanBY():");
            // Problem 5 Sort students using OrderBy() and ThenBy()
            var sortedStudents = students.OrderByDescending(st => st.FirstName).ThenBy(st => st.LastName);
            foreach (var item in sortedStudents)
            {
                 Console.WriteLine("{0} {1}",item.FirstName, item.LastName);
            }
            Console.WriteLine();

            // Problem 5 Sort students using LINQ
            Console.WriteLine("Sorted students using LINQ:");
            var sortedStudentsQuery =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            foreach (var item in sortedStudentsQuery)
            {
                 Console.WriteLine("{0} {1}",item.FirstName, item.LastName);
            }
            Console.WriteLine();
        }

        private static void FilterByEmail (List<Student> students)
        {
            //Problem 6 Email
            Console.WriteLine("Students that have @abv.bg email:");
            var emailStudentQuery =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
            foreach (var item in emailStudentQuery)
            {
                Console.WriteLine("{0} {1} {2}",item.FirstName, item.LastName, item.Email);
            }
            Console.WriteLine();

            //Problem 6 
            var studentsQuery = students.Where(student => student.Email.Contains("@abv.bg"));

            foreach (var item in studentsQuery)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Email);
            }
            Console.WriteLine();
        }

        private static void FilterByPhone(List<Student> students)
        {
            //Problem 7
            Console.WriteLine("Students that have phones in Sofia:");
            var SofiaStudents =
                from student in students
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student;
            foreach (var item in SofiaStudents)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Phone);
            }
        }

        private static void ExcellentStudent (List<Student> students)
        {
            //Problem 8
            Console.WriteLine("Students that have at least one mark 6:");
            var excellentStudents = (students.Select(student => new { Fullname = student.FirstName + " " + student.LastName, student.Marks })).Where(x => x.Marks.Contains(6));
            foreach (var item in excellentStudents)
            {
                Console.WriteLine("{0} {1}", item.Fullname, string.Join(", ", item.Marks));
            }
            Console.WriteLine();

            // Problem 8 second way           
            var excellentStudent =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, student.Marks };
            foreach (var item in excellentStudent)
            {
                Console.WriteLine(item.FullName + "- " + string.Join(", ", item.Marks));
            }
            Console.WriteLine();
        }

        private static void WeakStudents (List<Student> students)
        {
            //Problem 9
            Console.WriteLine("Students that have 2 marks 2:");
            var weakStudent = students.Where(st => st.Marks.Count(x => x == 2) == 2);
            foreach (var item in weakStudent)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, string.Join(", ", item.Marks));
            }
            Console.WriteLine();
        }

        private static void EnrolledIn2014 (List<Student> students)
        {
            //Problem 10
            Console.WriteLine("EnrolledIn2014 in 2014:");
            var enrolled = students.Where(st => st.FacultyNumber.ToString().Substring(4, 2) == "14");
            foreach (var item in enrolled)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.FacultyNumber);
            }
            Console.WriteLine();

            //Problem 10 second way

            var enrolledQuery =
                from student in students
                where student.FacultyNumber.ToString().Substring(4, 2) == "14"
                select student;
            foreach (var item in enrolledQuery)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.FacultyNumber);
            }
            Console.WriteLine();
        }

        private static void StudentsByGroup (List<Student> students)
        {
            // Problem 11
            Console.WriteLine("Students by groupName:");
            Console.WriteLine();
            var groupName =
                from student in students
                group student by student.GroupName into groupN
                select new { st = groupN.Key, Students = groupN };
            foreach (var group in groupName)
            {
                Console.WriteLine("Group name:{0}", group.st);
                foreach (var item in group.Students)
                {
                    Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static void JoinedToSpecialties (List<Student> students, List<StudentSpecialty> specialties)
        {
            //Problem 12
            Console.WriteLine("Students joined to specialties: \n");
            var joined =
                from student in students
                join specialty in specialties
                on student.FacultyNumber equals specialty.FacultyNumber
                select new { firstName = student.FirstName,
                              lastName = student.LastName, 
                              facultyNum = student.FacultyNumber, 
                              spec = specialty.Specialty };
            foreach (var item in joined)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.firstName, item.lastName, item.facultyNum, item.spec);
                //Console.WriteLine(item);
            }
        }
    }
}
