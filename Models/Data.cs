using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace database.Models
{
        public class Data : DbContext
        {
            public DbSet<SinhVien> SinhViens { get; set; }
        }
    
}