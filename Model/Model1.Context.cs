﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Boolmaster_Samodin.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookmasterDb_KOSATKAEntities : DbContext
    {
        public BookmasterDb_KOSATKAEntities()
            : base("name=BookmasterDb_KOSATKAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }
        public DbSet<BookCover> BookCover { get; set; }
        public DbSet<BookSubject> BookSubject { get; set; }
        public DbSet<Cover> Cover { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Circulation> Circulation { get; set; }
    }
}