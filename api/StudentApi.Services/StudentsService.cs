﻿using StudentApi.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Services
{
    public class StudentsService : IStudentsService
    {
        public List<Student> students = new List<Student>();

        public StudentsService()
        {
            students.Add(new Student
            {
                FirstName = "Marty",
                LastName = "McFly",
                Email = "back.future@test.com",
                Major = "History",
                AverageGrade = 78.3
            });

            students.Add(new Student {
                FirstName = "Emmett",
                LastName = "Brown",
                Email = "dr.brown@test.com",
                Major = "Physics",
                AverageGrade = 96.4
            });

            students.Add(new Student
            {
                FirstName = "Biff",
                LastName = "Tannen",
                Email = "biff@test.com",
                Major = "PE",
                AverageGrade = 54.2
            });
        }

        /// <summary>
        /// Adds a new student to the system
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudent(Student student)
        {
            students.Add(student);
            return true;
        }

        /// <summary>
        /// removes a student from the system
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all of the students currently in the system
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
