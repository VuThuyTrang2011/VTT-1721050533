using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VTT1721050533_.Models
{
    public class QL : DbContext
    {
        public QL() : base("name=QL")
        {
        }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public object Person { get; internal set; }
    }
}