using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalVariablesExample.Data;

namespace LocalVariablesExample.DataLayer
{
    // Open the Package Manager Console
    // Set default project to LocalVariablesExample.DataLayer
    // The important commands I have been using are
    // Enable-Migrations
    // Add-Migration <Migration Name>
    // Update-Database
    // 
    // When Downgrading:
    // Update-Database -TargetMigration:<Migration Name>
    //
    // When going to production:
    // Update-Database -Script -SourceMigration:<Migration Name>
    // Use -SourceMigration:0 when wanting all of the database changes from the beginning
    // Update-Database -Script -SourceMigration:0

    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public class LocalVariablesModelContext : DbContext
    {
        public LocalVariablesModelContext()
            : base("LocalVariables")
        { }

        virtual public DbSet<Post> Posts { get; set; }
        virtual public DbSet<Comment> Comments { get; set; }
    }
}
