// <auto-generated />
namespace LibraryManagementSystem.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class AddIsDeletedColumnToBookAndLibrarianAndMemberClasses : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddIsDeletedColumnToBookAndLibrarianAndMemberClasses));
        
        string IMigrationMetadata.Id
        {
            get { return "201709240856093_AddIsDeletedColumnToBookAndLibrarianAndMemberClasses"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
