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
    public class PostCFG : BaseEntityConfiguration<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x=>x.Title).HasMaxLength(130).IsRequired().HasColumnType("varchar");
            builder.Property(x=>x.Content).HasMaxLength(130).IsRequired().HasColumnType("varchar");
            builder.Property(x=>x.ImagePath).HasMaxLength(130).HasColumnType("varchar").IsRequired(false);
          base.Configure(builder);
        }
    }
}
