﻿namespace _06_文字檔讀取_判斷與轉換.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.IO;

    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<Table> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
