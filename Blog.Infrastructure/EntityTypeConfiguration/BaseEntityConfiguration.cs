using Domain.Entities.Abstract;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.EntityTypeConfiguration
{
    //jenerik kısıtlar. 
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired().HasDefaultValue(DateTime.Now);  
            builder.Property(x => x.UpdateDate).IsRequired();  
            builder.Property(x => x.DeleteDate).IsRequired();  
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);  

           
        }
    }
}
