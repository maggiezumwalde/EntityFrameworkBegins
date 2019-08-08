﻿using EntityFrameworkBegins.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkBegins {
    class Program {
        static void Main(string[] args) {  

            var context = new AppDbContext();

            //var mathMajor = context.majors.SingleOrDefault(m => m.Description.Contains("Math"));
            //var math101 = new Course {
            //    Name = "Math 101",
            //    Instructor = "Beene Kownter",
            //    Credits = 5,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(math101);
            //var math102 = new Course {
            //    Name = "Math 102",
            //    Instructor = "John Snow",
            //    Credits = 3,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(math102);
            //var math103 = new Course {
            //    Name = "Math 103",
            //    Instructor = "Will Cain",
            //    Credits = 5,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(math103);
            //var calc101 = new Course {
            //    Name = "Calc 101",
            //    Instructor = "Doug Chin",
            //    Credits = 3,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(calc101);
            //var geom = new Course {
            //    Name = "Geometry 101",
            //    Instructor = "Beth Ward",
            //    Credits = 3,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(geom);

            //var geoMajor = context.majors.SingleOrDefault(g => g.Description.Contains("Geology"));
            //var geo101 = new Course {
            //    Name = "Geology 101",
            //    Instructor = "Tiffany Thompson",
            //    Credits = 5,
            //    MajorId = geoMajor.Id
            //};
            //context.courses.Add(geo101);
            //var geo102 = new Course {
            //    Name = "Geology 102",
            //    Instructor = "Ben Tag",
            //    Credits = 3,
            //    MajorId = geoMajor.Id
            //};
            //context.courses.Add(geo102);
            //var geo103 = new Course {
            //    Name = " Geology103",
            //    Instructor = "Linda Cast",
            //    Credits = 3,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(geo102);
            //var geo104 = new Course {
            //    Name = "Geology 104",
            //    Instructor = "Fran Fikke",
            //    Credits = 5,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(geo104);
            //var geo105 = new Course {
            //    Name = "Geology105",
            //    Instructor = "Kim Telly",
            //    Credits = 5,
            //    MajorId = mathMajor.Id
            //};
            //context.courses.Add(geo105);
            //var teachmjr = context.majors.SingleOrDefault(t => t.Description.Contains("Teaching"));
            //var teach101 = new Course {
            //    Name = "Teaching 101",
            //    Instructor = "Nos Ryo",
            //    Credits = 5,
            //    MajorId = teachmjr.Id
            //};
            //context.courses.Add(teach101);
            //var teach102 = new Course {
            //    Name = "Teaching 102",
            //    Instructor = "Obi Siye",
            //    Credits = 5,
            //    MajorId = teachmjr.Id
            //};
            //context.courses.Add(teach102);
            //var teach103 = new Course {
            //    Name = "Teaching 103",
            //    Instructor = "Zach Fille",
            //    Credits = 5,
            //    MajorId = teachmjr.Id
            //};
            //context.courses.Add(teach103);

            //var sociomjr = context.majors.FirstOrDefault(s => s.Description.Contains("Sociology"));
            //var socio101 = new Course {
            //    Name = "Sociology 101",
            //    Instructor = "Fred Smith",
            //    Credits = 3,
            //    MajorId = sociomjr.Id
            //};
            //context.courses.Add(socio101);
            //var socio102 = new Course {
            //    Name = "Sociology 102",
            //    Instructor = "Frank Smill",
            //    Credits = 3,
            //    MajorId = sociomjr.Id
            //};
            //context.courses.Add(socio102);
            //var socio103 = new Course {
            //    Name = "Sociology 103",
            //    Instructor = "Tonya Hill",
            //    Credits = 3,
            //    MajorId = sociomjr.Id
            //};
            //context.courses.Add(socio103);
            //context.SaveChanges();

            var biomjr = context.majors.SingleOrDefault(b => b.Description.Contains("Biology"));
            var bio101 = new Course {
                Name = "Biology 101",
                Instructor = "Zach Zumdy",
                Credits = 4,
                MajorId = biomjr.Id
            };
            context.courses.Add(bio101);
            var bio102 = new Course {
                Name = "Biology 102",
                Instructor = "Zach Tak",
                Credits = 5,
                MajorId = biomjr.Id
            };
            context.courses.Add(bio102);
            var bio103 = new Course {
                Name = "Biology 103",
                Instructor = "Bob Ross",
                Credits = 5,
                MajorId = biomjr.Id
            };
            context.Add(bio103);
            context.SaveChanges(); 

        }


        }


                       
            //var major = context.majors.Find(5);
            //context.Remove(major);

            //find major by description
            //var major = context.majors
            //    .SingleOrDefault(m => m.Description == "Computer Science);");

            //var bowling = context.majors
            //   .FirstOrDefault(m => m.Description == "Bowling");
            //context.Remove(bowling);
            //context.SaveChanges();
            
            //var pubsk = context.majors
            //   .SingleOrDefault(m => m.Description == "Public Speaking");
            //var theater = context.majors
            //   .SingleOrDefault(m => m.Description == "Theater");
            //var golfsci = context.majors
            //   .SingleOrDefault(m => m.Description == "Golf Science");
            //var sociology = context.majors
            //   .SingleOrDefault(m => m.Description == "Sociology)");



            //var bird = new Student {
            //    Firstname = "J.",
            //    Lastname = "Bird",
            //    GPA = 3.5,
            //    SAT = 1250,
            //    IsFulltime = true,
            //    MajorId = esports.Id
            //};
            //var star = new Student {
            //    Firstname = "P.",
            //    Lastname = "Star",
            //    GPA = 1.7,
            //    SAT = 1250,
            //    IsFulltime = true,
            //    MajorId = pubsk.Id
            //};
            //var neutron = new Student {
            //    Firstname = "J.",
            //    Lastname = "Neutron",
            //    GPA = 5.0,
            //    SAT = 2000,
            //    IsFulltime = true,
            //    MajorId = theater.Id
            //};

            //context.students.Add(star);
            //context.students.Add(neutron);
            //context.SaveChanges();

        //    var major = new Major();
        //    major.Id = 0;
        //    major.Description = "Rocket Science";
        //    major.MinSat = 1000;
        //    context.majors.Add(major);

        //     major = new Major();
        //    major.Id = 0;
        //    major.Description = "Bowling";
        //    major.MinSat = 1500;
        //    context.majors.Add(major);
        //    context.SaveChanges();

        }


        //Change Mathematics to Math
        //var major = context.majors.Find(2);
        //if (major == null) { // did not find it       
        //   throw new Exception("Not found!");
        //  }
        //major.Description = "Math";
        //major.MinSat = 1300;


        // easier to just add a collection of strings that represent the description
        //Added Biology
        //var major = new Major();
        //major.Id = 0;
        //major.Description = "Biology";
        //major.MinSat = 1100;

        //context.majors.Add(major);

        //var major = new Major();
        //major.Id = 0;
        //major.Description = "Nursing";
        //major.MinSat = 1100;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "Accounting";
        //major.MinSat = 1300;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "Public Speaking";
        //major.MinSat = 5;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "Golf Science";
        //major.MinSat = 1400;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "ESports";
        //major.MinSat = 800;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "Sociology";
        //major.MinSat = 800;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "History";
        //major.MinSat = 900;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "Political Science";
        //major.MinSat = 1000;
        //context.majors.Add(major);

        //major = new Major();
        //major.Id = 0;
        //major.Description = "Theater";
        //major.MinSat = 200;
        //context.majors.Add(major);


        //foreach (var major in context.majors.ToList()) {
        //    Console.WriteLine(major);
        //}

        //var genStudies = context.majors.Find(1);
        //Console.WriteLine(genStudies);

        //var students = context.students                
        //    .Where(s => s.GPA >= 3.0)
        //    .OrderByDescending(s => s.Lastname)
        //    .ToArray();

        //var students = context.students
        //    .OrderBy(s => s.Firstname)
        //    .ToArray();

        //var students = context.students
        //    .OrderBy(s => s.Lastname)
        //    .ToArray();

        //var studentAverageSat = context.students
        //    .Average(s => s.SAT);
        //Console.WriteLine($"The average sat score is {studentAverageSat}");

        //foreach (var student in students) {
        //    var major = (student.Major == null) 
        //        ? "Undeclared" 
        //        : student.Major.Description;
        //    Console.WriteLine($"{student.Firstname} {student.Lastname} {major}");

        //var students = context.students.ToArray();

        //var students = context.students
        //          .Where(student => student.Major != null)
        //          .OrderBy(student => student.Major.Description)
        //          .ToList();


        //foreach (var student in students) {
        //    var major = (student.Major == null)
        //        ? "Undeclared"
        //        : student.Major.Description;
        //    Console.WriteLine(student);
        //}






   

