namespace mvcwebapp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using mvcwebapp1.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<mvcwebapp1.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(mvcwebapp1.Models.RecordContext context)
        {
            var students = new List<Student>
            {
            new Student{Name="Mohan",Email="Samuai@example.com",Course="Java Technology", Contact="+25-258628"},
            new Student{Name="Rohan",Email="Sam@example.com",Course=".NET Technology", Contact="+25-258694"},
            new Student{Name="John",Email="Max@example.com",Course="Java Technology", Contact="+25-258999"},
            new Student{Name="Saba",Email="saba@example.com",Course="Linux Administration", Contact="+25-258111"},
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
    }

