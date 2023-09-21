﻿using EntityFrameWorkRelations.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkRelations.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {

        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
    }
}
