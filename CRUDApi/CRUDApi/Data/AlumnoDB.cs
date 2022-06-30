using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq    ;
using CRUDApi.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDApi.Data
{
    public class AlumnoDB : DbContext
    {
        public AlumnoDB(DbContextOptions<AlumnoDB> options) : base(options)
        {

        }

        public DbSet<AlumnosM> AlumnosItem { get; set; }



    }
}
