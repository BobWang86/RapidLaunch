using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class DevTest_v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var CreateViewLaunchHistory = "CREATE VIEW [dbo].[LaunchHistory] AS SELECT dbo.Launches.*, dbo.LaunchStatuses.Name FROM dbo.Launches INNER JOIN dbo.LaunchStatuses ON dbo.Launches.LaunchStatusID = dbo.LaunchStatuses.LaunchStatusID";
            var CreateViewLaunchHistoryByYear = "CREATE VIEW [dbo].[LaunchHistoryByYear] AS " +
                "(SELECT Success.LaunchYear, Success.LaunchSuccess AS Success, Failure.LaunchFailure AS Failure, Abort.LaunchAbort AS Abort FROM" +
                "(SELECT Year(LaunchDate) AS LaunchYear , COUNT(LaunchID) AS LaunchSuccess FROM [RapidLaunchDB].[dbo].[LaunchHistory] WHERE Name = 'Success' GROUP BY YEAR(LaunchDate)) AS Success LEFT OUTER JOIN" +
                "(SELECT YEAR(LaunchDate) AS LaunchYear, COUNT(LaunchID) AS LaunchFailure FROM[RapidLaunchDB].[dbo].[LaunchHistory] WHERE NAME = 'Failure' OR Name = 'Loss During Launch' GROUP BY YEAR(LaunchDate)) AS Failure ON Success.LaunchYear = Failure.LaunchYear LEFT OUTER JOIN" +
                "(SELECT YEAR(LaunchDate) AS LaunchYear, COUNT(LaunchID) AS LaunchAbort FROM[RapidLaunchDB].[dbo].[LaunchHistory] WHERE NAME = 'Abort Before Launch' OR Name = 'Loss Before Launch' GROUP BY YEAR(LaunchDate)) AS Abort ON Success.LaunchYear = Abort.LaunchYear)";

            migrationBuilder.Sql(CreateViewLaunchHistory);
            migrationBuilder.Sql(CreateViewLaunchHistoryByYear);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var DropViewLaunchHistory = "DROP VIEW [dbo].[LaunchHistory]";
            var DropViewLaunchHistoryByYear = "DROP VIEW [dbo].[LaunchHistoryByYear]";

            migrationBuilder.Sql(DropViewLaunchHistoryByYear);
            migrationBuilder.Sql(DropViewLaunchHistory);
        }
    }
}
