using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Blog.Infrastructure.EntityTypeConfiguration
{
    public class AppUserCFG : BaseEntityConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(25).HasColumnType("nvarchar").IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(13).HasColumnType("nvarchar").IsRequired();

            PasswordHasher<AppUser> hash = new PasswordHasher<AppUser>();
            AppUser root = new AppUser()
            {
                FirstName = "root",
                LastName = "Admin",
                Email = "root@admin.com",
                UserName = "root@admin.com"
            };
            hash.HashPassword(root, "Root_123");
            builder.HasData(root);


            base.Configure(builder);


        }
    }
}
