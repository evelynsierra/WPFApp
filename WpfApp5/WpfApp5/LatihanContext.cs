﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp5
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    class LatihanContext : DbContext
    {
        
        public DbSet<ItemPenjualan> DaftarItemPenjualan { get; set; }
    }
}
