﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer.Entity_Framework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Education_Platform_Final_TermEntities : DbContext
    {
        public Education_Platform_Final_TermEntities()
            : base("name=Education_Platform_Final_TermEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AnswerScript> AnswerScripts { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Counseling> Counselings { get; set; }
        public virtual DbSet<CourseModule> CourseModules { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<PasswordChangeRequest> PasswordChangeRequests { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Reviewstudent> Reviewstudents { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<ValidStudent> ValidStudents { get; set; }
        public virtual DbSet<AdminToken> AdminTokens { get; set; }
        public virtual DbSet<InstitutionToken> InstitutionTokens { get; set; }
        public virtual DbSet<MentorToken> MentorTokens { get; set; }
    }
}
