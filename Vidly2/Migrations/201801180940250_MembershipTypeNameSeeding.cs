namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeNameSeeding : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE ID = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annually' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
