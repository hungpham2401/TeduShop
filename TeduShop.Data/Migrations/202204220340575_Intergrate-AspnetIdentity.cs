namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntergrateAspnetIdentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(maxLength: 256),
                        Address = c.String(maxLength: 256),
                        BirthDay = c.DateTime(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.Products", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.PostCategories", "Image", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.Posts", "Image", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Sildes", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "UPdateBy", c => c.String());
            AlterColumn("dbo.ProductCategories", "UPdateBy", c => c.String());
            AlterColumn("dbo.Pages", "UPdateBy", c => c.String());
            AlterColumn("dbo.PostCategories", "UPdateBy", c => c.String());
            AlterColumn("dbo.Posts", "ViewCount", c => c.Int());
            AlterColumn("dbo.Posts", "UPdateBy", c => c.String());
            AlterColumn("dbo.Sildes", "UPdateBy", c => c.String());
            DropColumn("dbo.PostCategories", "Discription");
            DropColumn("dbo.PostCategories", "Images");
            DropColumn("dbo.Posts", "Discription");
            DropColumn("dbo.Posts", "Images");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Images", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "Discription", c => c.String(maxLength: 500));
            AddColumn("dbo.PostCategories", "Images", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "Discription", c => c.String(maxLength: 500));
            DropForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropIndex("dbo.IdentityUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            AlterColumn("dbo.Sildes", "UPdateBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "UPdateBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "ViewCount", c => c.Boolean());
            AlterColumn("dbo.PostCategories", "UPdateBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "UPdateBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "UPdateBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "UPdateBy", c => c.String(maxLength: 256));
            DropColumn("dbo.Sildes", "UpdatedBy");
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Posts", "Image");
            DropColumn("dbo.Posts", "Description");
            DropColumn("dbo.PostCategories", "UpdatedBy");
            DropColumn("dbo.PostCategories", "Image");
            DropColumn("dbo.PostCategories", "Description");
            DropColumn("dbo.Pages", "UpdatedBy");
            DropColumn("dbo.ProductCategories", "UpdatedBy");
            DropColumn("dbo.Products", "UpdatedBy");
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityRoles");
        }
    }
}
