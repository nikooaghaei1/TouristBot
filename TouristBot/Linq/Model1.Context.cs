﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TouristBot.Linq
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Tourist_BotEntities : DbContext
    {
        public Tourist_BotEntities()
            : base("name=Tourist_BotEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int AddPlace(string pro, string cit, string pla, string des)
        {
            var proParameter = pro != null ?
                new ObjectParameter("Pro", pro) :
                new ObjectParameter("Pro", typeof(string));
    
            var citParameter = cit != null ?
                new ObjectParameter("Cit", cit) :
                new ObjectParameter("Cit", typeof(string));
    
            var plaParameter = pla != null ?
                new ObjectParameter("Pla", pla) :
                new ObjectParameter("Pla", typeof(string));
    
            var desParameter = des != null ?
                new ObjectParameter("Des", des) :
                new ObjectParameter("Des", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPlace", proParameter, citParameter, plaParameter, desParameter);
        }
    }
}
