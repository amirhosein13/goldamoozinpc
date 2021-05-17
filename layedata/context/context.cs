using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace layedata
{
   public class context:DbContext
    {
        public context(DbContextOptions<context> contextOptions):base(contextOptions)
        {
                
        }
        public DbSet<role> roles { get; set; }
        public DbSet<userbomb> userbombs { get; set; }
        public DbSet<dore> dores { get; set; }
        public DbSet<videodore> videodores { get; set; }
        public DbSet<doreuser> Doreusers { get; set; }
        public DbSet<blogmaghale> blogmaghales { get; set; }
        public DbSet<soal> Soals { get; set; }
        public DbSet<payuserdore> payuserdores { get; set; }
        public DbSet<javab> javabs { get; set; }
        public DbSet<nazarostad> nazarostads { get; set; }
        public DbSet<nazarat> nazarats { get; set; }
        public DbSet<nazaratvideo> nazaratvideos { get; set; }
        public DbSet<nazaratostadvideo> nazaratostadvideos { get; set; }
    }
}
