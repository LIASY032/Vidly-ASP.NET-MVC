namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'750702c5-c576-4102-8a8f-8be7528141b9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6675a3de-8696-459a-b69b-b4e06aea802d', N's1287673784@gmail.com', 0, N'AD3fepDcMJ5BenNe4AupGDzuWGsWg82IfQDAXWSygeL8tz6eMf1IjZKl47tC0qAs/Q==', N'850aa3b2-8a52-4047-be91-3c3b66b42d7a', NULL, 0, 0, NULL, 1, 0, N's1287673784@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b9b1049a-885b-4f4b-9d94-c2ad2daedef3', N'guest@gmail.com', 0, N'ALPCNdotHzybLGy9cAB7qjpaSpv4i9O6ug6jyejNnff4aTt0+zgmayWLPoIdNxZI0A==', N'60389161-6352-426e-978d-c4f284d52d50', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cb5fbd5f-98a1-4958-b577-9c29aded350b', N's1160137289@gmail.com', 0, N'APlw0AtKydKUiSkBrtCEBGDxBy+0XsTOOmzU/q6mViZFTjYXOlu7U1ZAtmhm1A7XTA==', N'97de1681-ba1a-4282-99a0-edcc22f4cf3c', NULL, 0, 0, NULL, 1, 0, N's1160137289@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e15952b8-ee6d-4a3d-947b-ee23b642b9cc', N'admin@gmail.com', 0, N'AFKtR0b8RwYyK35QuadvjpiTtxOFKtOv3iViPEl2WTYHc15VoW2FfwxmdxCB6SaVoA==', N'abb05e69-809a-49c2-8dbe-404bac78ab99', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b9b1049a-885b-4f4b-9d94-c2ad2daedef3', N'750702c5-c576-4102-8a8f-8be7528141b9')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e15952b8-ee6d-4a3d-947b-ee23b642b9cc', N'750702c5-c576-4102-8a8f-8be7528141b9')

");
        }
        
        public override void Down()
        {
        }
    }
}
