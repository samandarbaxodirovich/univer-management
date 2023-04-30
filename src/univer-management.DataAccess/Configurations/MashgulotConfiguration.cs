using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;

namespace univer_management.DataAccess.Configurations
{
    public class MashgulotConfiguration : IEntityTypeConfiguration<Mashgulot>
    {
        public void Configure(EntityTypeBuilder<Mashgulot> builder)
        {
            builder.HasData(new Mashgulot()
            {
                Id= 1,
                Name = "Ma'ruza"
            });
            builder.HasData(new Mashgulot()
            {
                Id = 2,
                Name = "Amaliy"
            });
            builder.HasData(new Mashgulot()
            {
                Id = 3,
                Name = "Oraliq nazorat"
            });
            builder.HasData(new Mashgulot()
            {
                Id = 4,
                Name = "Mustaqil ta'lim"
            });
        }
    }
}
