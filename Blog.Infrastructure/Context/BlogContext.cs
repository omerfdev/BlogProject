using Blog.Infrastructure.EntityTypeConfiguration;
using Domain.Entities.Abstract;
using Domain.Entities.Concrete;
using Domain.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Blog.Infrastructure.Context
{
    public class BlogContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public BlogContext()
        {
            
        }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=ALMALI\\OMERFDEV;Initial Catalog=Blog_DB;User ID=sa;pwd=Omer34;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override async void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration<AppRole>(new AppRoleCFG());
            builder.ApplyConfiguration<AppUser>(new AppUserCFG());
            builder.ApplyConfiguration<Genre>(new GenreCFG());
            builder.ApplyConfiguration<Post>(new PostCFG());
            builder.ApplyConfiguration<Comment>(new CommentCFG());          
            builder.ApplyConfiguration<Like>(new LikeCFG());
            //Admin Role.
            //this.UserRoles.Add(new IdentityUserRole<int> { RoleId=1,UserId=1});

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> {
                    RoleId=1,UserId=1 
                });
            base.OnModelCreating(builder);
        }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
     
    }
}
