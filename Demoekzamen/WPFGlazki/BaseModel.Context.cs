﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfGlazkiSave
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class glazki_saveEntities : DbContext
    {
        private static glazki_saveEntities _context;
        public glazki_saveEntities()
            : base("name=glazki_saveEntities")
        {
        }
    
        public static glazki_saveEntities GetContext()
        {
            if (_context == null)
                _context = new glazki_saveEntities();
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<agents> agents { get; set; }
        public virtual DbSet<product_agent> product_agent { get; set; }
        public virtual DbSet<productsale> productsale { get; set; }
    }
}
