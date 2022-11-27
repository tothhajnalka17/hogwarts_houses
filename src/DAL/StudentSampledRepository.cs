﻿using HogwartsHouses.Models;
using System.Collections.Generic;
using System.Linq;

namespace HogwartsHouses.DAL
{
    public class StudentampledRepository : IRepository<Student>
    {
        public StudentSampler StudentSampler { get; }

        public StudentSampledRepository()
        {
            StudentSampler = new StudentSampler();
        }

        public List<Student> GetAll()
        {
            var StudentList = new List<Student>();
            foreach (var room in StudentSampler.Students)
            {
                StudentList.Add(student);
            }
            return StudentList;
        }

        public Student Find(int id)
        {
            return StudentSampler.Students.Where((student) => student.Id == id).First();
        }

        public void Insert(Student entity)
        {
            StudentSampler.Students.Add(entity);
        }

        public void Update(Student entity)
        {
            Student oldStudent = Find(entity.Id);
            oldStudent = entity;
        }

        public void Delete(Student entity)
        {
            StudentSampler.Students.Remove(entity);
        }
    }
}
