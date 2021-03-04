using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;


namespace ComputerSelection.Repository
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CPUMap(modelBuilder.Entity<CPU>());
            new GPUMAP(modelBuilder.Entity<GPU>());
            new RAMMAP(modelBuilder.Entity<RAM>());
            new SSDMAP(modelBuilder.Entity<SSD>());
            new HARDDISKMAP(modelBuilder.Entity<HardDisk>());
            new MAINBOARDMAP(modelBuilder.Entity<MainBoard>());
            new LogMap(modelBuilder.Entity<Log>());
            new SystemRequirementMAP(modelBuilder.Entity<SystemRequirement>());
            new ComputerMap(modelBuilder.Entity<Computers>());
        }
       
    }

}
