using University1.Models;
using System;
using System.Linq;

namespace University1.Data
{
    public static class SeedData
    {
        public static void Initialize(University1Context context)
        {
            context.Database.EnsureCreated();

            
            if (context.Student.Any())
                {
                    return; //DB has been seeded
                }
            var students = new Student[]
                  { new Student {StudentId="322",FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2016-10-8"),AcquiredCredits=167,CurrentSemester=6,EducationLevel="Bachelor's"},
                    new Student {StudentId="270",FirstName="Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2017-9-10"), AcquiredCredits = 93 , CurrentSemester = 4, EducationLevel = "Associate"},
                    new Student {StudentId = "85", FirstName = "Darien", LastName = "Sims", EnrollmentDate = DateTime.Parse("2017-10-7"), AcquiredCredits = 54, CurrentSemester = 2, EducationLevel = "Master's"},
                    new Student {StudentId = "180", FirstName = "Ashley", LastName = "Carney", EnrollmentDate = DateTime.Parse("2017-10-15"), AcquiredCredits = 154, CurrentSemester = 6, EducationLevel = "Bachelor's"},
                    new Student {StudentId = "27", FirstName = "Dario", LastName = "Cole", EnrollmentDate = DateTime.Parse("2019-9-9"), AcquiredCredits = 170, CurrentSemester = 1 , EducationLevel = "Doctoral"}
                        };
            foreach (Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
                 {  new Course {Title = "Telecommunications", Credits = 5, Semester =  3, Programme = "Telecommunications", EducationLevel = "Associate",FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Aiden" && d.LastName == "Terry").Id, SecondTeacherId = context.Teacher.Single(d => d.FirstName=="Celeste" && d.LastName=="Yang").Id},
                    new Course {Title = "Electronics", Credits = 7, Semester = 1, Programme = "Electrical Engeneering", EducationLevel = "Master's", FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Markus" && d.LastName == "Cline").Id, SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Walter" && d.LastName == "Hebert").Id},
                    new Course {Title = "Information and Communication Technologies", Credits = 7, Semester = 2, Programme = "Computer Science", EducationLevel = "Doctoral", FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Maxim" && d.LastName == "Andrews").Id, SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Aiden" && d.LastName == "Terry").Id },
                    new Course {Title = "Internet Technology", Credits = 6, Semester = 3, Programme = "Telecommunications", EducationLevel = "Bachelor's", FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Celeste" && d.LastName == "Yang").Id, SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Sonny" && d.LastName == "Cross").Id }
                       };
            foreach (Course c in courses)
            {
                context.Course.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
                  { new Enrollment {StudentId = 1, CourseId = 5, Semester = "3", Year = 2017, Grade = 7, SeminalUrl = "https://www.oxfordhandbooks.com/view/10.1093/oxfordhb/9780199589074.001.0001/oxfordhb-9780199589074-e-1", ProjectUrl = "https://www.engineering.unsw.edu.au/electrical-engineering/research/our-research/telecommunications/telecommunications-research-projects", ExamPoints = 53, SeminalPoints = 70, ProjectPoints = 66, AdditionalPoints = 5, FinishDate = DateTime.Parse("2018-01-22")},                  
                    new Enrollment {StudentId = 2, CourseId = 3, Semester = "4", Year = 2018, Grade = 6, SeminalUrl = "https://www.newscientist.com/article/dn13812-engineers-find-missing-link-of-electronics/", ProjectUrl = "https://circuitdigest.com/electronic-circuits/triangle-wave-generator-circuit-using-op-amp", ExamPoints = 50, SeminalPoints = 43, ProjectPoints = 76, AdditionalPoints = 0,FinishDate = DateTime.Parse("2018-6-7")},
                    new Enrollment {StudentId = 3, CourseId = 5, Semester = "3", Year = 2018, Grade = 9, SeminalUrl = "https://educationaltechnologyjournal.springeropen.com/articles/10.1186/s41239-017-0063-0", ProjectUrl = "https://ocw.mit.edu/courses/edgerton-center/ec-s01-internet-technology-in-local-and-global-communities-spring-2005-summer-2005/projects/", ExamPoints = 84, SeminalPoints = 80, ProjectPoints = 71, AdditionalPoints = 3, FinishDate = DateTime.Parse("2018-8-29")},
                    new Enrollment {StudentId = 4, CourseId = 2, Semester = "3", Year = 2018, Grade = 9, SeminalUrl = "https://arxiv.org/pdf/1805.11721.pdf", ProjectUrl = "https://www.tendersinfo.com/projects_details/452944273?desc=Cambodia-Fibre-Optic-Network", ExamPoints = 82, SeminalPoints = 64, ProjectPoints = 55, AdditionalPoints = 10, FinishDate = DateTime.Parse("2018-12-28")},
                    new Enrollment {StudentId = 5, CourseId = 3, Semester = "1", Year = 2019, Grade = 8, SeminalUrl = "https://phys.org/news/2018-03-breakthrough-circuit-electronics-resistant-defects.html", ProjectUrl = "https://circuitdigest.com/electronic-circuits/over-voltage-over-current-transient-voltage-reverse-voltage-protection-circuit-using-rt1720-hot-swap-controller", ExamPoints = 74, SeminalPoints = 55, ProjectPoints = 72, AdditionalPoints = 7, FinishDate = DateTime.Parse("2020-01-8")}
                   };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();
            var teachers = new Teacher[]
                 {  new Teacher {FirstName = "Celeste", LastName = "Yang", Degree = "Doctoral", AcademicRank = "Docent", OfficeNumber = "245", HireDate = DateTime.Parse("2010-5-7")},
                    new Teacher {FirstName = "Aiden", LastName = "Terry", Degree = "Doctoral", AcademicRank = "Profesor", OfficeNumber = "33", HireDate = DateTime.Parse("2007-2-19")},
                    new Teacher {FirstName = "Marcus", LastName = "Cline", Degree = "Doctoral", AcademicRank = "Docent", OfficeNumber = "15", HireDate = DateTime.Parse("2011-8-3")},
                    new Teacher {FirstName = "Walter", LastName = "Hebert", Degree = "Master's", AcademicRank = "Assistent", OfficeNumber = "114", HireDate = DateTime.Parse("2015-2-22")},
                    new Teacher {FirstName = "Maxim", LastName = "Andrews", Degree = "Doctoral", AcademicRank = "Profesor", OfficeNumber = "99", HireDate = DateTime.Parse("2006-11-8")},
                    new Teacher {FirstName = "Sonny", LastName = "Cross", Degree = "Master's", AcademicRank = "Assistent", OfficeNumber = "119", HireDate = DateTime.Parse("2017-5-2")}
                 };
            foreach (Teacher t in teachers)
            {
                context.Teacher.Add(t);
            }
            context.SaveChanges();
        }
    }
}
