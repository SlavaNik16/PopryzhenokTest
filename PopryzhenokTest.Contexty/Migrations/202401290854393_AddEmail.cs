﻿namespace PopryzhenokTest.Contexty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAgents", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TAgents", "Email");
        }
    }
}
