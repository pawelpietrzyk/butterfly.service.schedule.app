﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace butterfly.service.schedule
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScheduleEntities : DbContext
    {
        public ScheduleEntities()
            : base("name=ScheduleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DayGroupTable> DayGroupTable { get; set; }
        public DbSet<DayTable> DayTable { get; set; }
        public DbSet<ScheduleEntry> ScheduleEntry { get; set; }
        public DbSet<ScheduleParam> ScheduleParam { get; set; }
        public DbSet<SpecialDayGroupTable> SpecialDayGroupTable { get; set; }
        public DbSet<SpecialDayTable> SpecialDayTable { get; set; }
        public DbSet<DayGroupRelation> DayGroupRelation { get; set; }
        public DbSet<SpecialDayGroupDayRelation> SpecialDayGroupDayRelation { get; set; }
    }
}
