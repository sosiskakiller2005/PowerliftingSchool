﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerliftingSchool.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PowerliftingSchoolDbEntities : DbContext
    {
        public PowerliftingSchoolDbEntities()
            : base("name=PowerliftingSchoolDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Group> Group { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Timetable> Timetable { get; set; }
        public DbSet<User> User { get; set; }
    }
}
