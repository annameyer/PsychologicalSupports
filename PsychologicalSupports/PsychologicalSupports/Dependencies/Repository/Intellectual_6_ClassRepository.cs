﻿using PsychologicalSupports.Models;
using PsychologicalSupports.Models.Dependencies;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace PsychologicalSupports.Dependencies.Repository
{
    public class Intellectual_6_ClassRepository : IRepository<Intellectual_6_Class>
    {
        private readonly IPsychologicalSupportsContext _psychologicalSupportsContext;
        public Intellectual_6_ClassRepository(IPsychologicalSupportsContext psychologicalSupportsContext)
        {
            _psychologicalSupportsContext = psychologicalSupportsContext;
        }
        public IEnumerable<Intellectual_6_Class> List()
        {
            return _psychologicalSupportsContext.Intellectual_6_Class;
        }
        public Intellectual_6_Class Get(long? id)
        {
            return _psychologicalSupportsContext.Intellectual_6_Class.Find(id);
        }
        public void Create(Intellectual_6_Class Intellectual_6_Class)
        {
            _psychologicalSupportsContext.Intellectual_6_Class.Add(Intellectual_6_Class);
            _psychologicalSupportsContext.SaveChanges();
        }
        public void Edit(Intellectual_6_Class Intellectual_6_Class)
        {
            _psychologicalSupportsContext.Intellectual_6_Class.AddOrUpdate(Intellectual_6_Class);
            _psychologicalSupportsContext.SaveChanges();
        }
        public void Delete(long id)
        {
            var student = _psychologicalSupportsContext.Intellectual_6_Class.Find(id);
            _psychologicalSupportsContext.Intellectual_6_Class.Remove(student);
            _psychologicalSupportsContext.SaveChanges();
        }
    }
}