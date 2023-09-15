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
    public class AppRoleCFG : BaseEntityConfiguration<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {

            builder.HasData(
                 new AppRole { Id = 1, Name = "Admin"},
                 new AppRole { Id = 2, Name = "User" }
             ); ;
            builder.Property(x=>x.Name).HasColumnType("varchar").HasMaxLength(25);
           

            base.Configure(builder);
        }
    }
}
