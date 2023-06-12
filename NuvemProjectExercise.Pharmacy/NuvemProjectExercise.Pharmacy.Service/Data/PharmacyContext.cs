using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuvemProjectExercise.Pharmacy.Service.Models;

namespace NuvemProjectExercise.Pharmacy.Service.Data
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options)
        {
            
        }

        public DbSet<PharmacyModel> Pharmacies => Set<PharmacyModel>();
    }
}