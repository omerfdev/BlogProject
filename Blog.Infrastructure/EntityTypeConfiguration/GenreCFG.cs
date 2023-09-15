using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.EntityTypeConfiguration
{
    public class GenreCFG : BaseEntityConfiguration<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
               new Genre { ID = 1, Name = "Science" },
               new Genre { ID = 2, Name = "Software" },
               new Genre { ID = 3, Name = "Sports" }
           );
            builder.Property(x => x.Name).HasMaxLength(25).IsRequired().HasColumnType("varchar");
            base.Configure( builder );  
        }
    }
}
