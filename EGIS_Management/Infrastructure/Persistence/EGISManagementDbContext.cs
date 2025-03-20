using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class EGISManagementDbContext(DbContextOptions<EGISManagementDbContext> options) : DbContext(options)
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Barangay> Barangays { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<CollectionCode> CollectionCodes { get; set; }  
        public DbSet<CollectionSummary> CollectionSummaries { get; set; }
        public DbSet<EstimatedRevenue>  EstimatedRevenues { get; set; } 
        public DbSet<ManagingTemplate> ManagingTemplates { get; set; }   
        public DbSet<OfficialReceipt> OfficialReceipt { get; set; } 
        public DbSet<RevenueCodeChild> RevenueCodeChild { get; set; }
        public DbSet<RevenueCodeForm> RevenueCodeForm { get; set; }
        public DbSet<RevenueCodeParent> RevenueCodeParent { get; set; }
        public DbSet<MasterTableCode> MasterTableCodes { get; set; }   
        public DbSet<MasterTableSubCode> MasterTableSubCodes { get; set; }
        public DbSet<Teller> Tellers { get; set; }
    }
}
