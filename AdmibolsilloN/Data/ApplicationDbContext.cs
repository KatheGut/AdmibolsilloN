﻿using AdmibolsilloN.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmibolsilloN.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoUsuario> TiposUsuario { get; set; }
        public DbSet<Gastos> Gastos { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
     
       
    }
}
