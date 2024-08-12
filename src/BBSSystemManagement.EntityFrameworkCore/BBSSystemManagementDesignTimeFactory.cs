using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.EntityFrameworkCore;
using Youshow.Ace.EntityFrameworkCore.SqlServer;

namespace BBSSystemManagement.EntityFrameworkCore
{
    public class BBSSystemManagementDesignTimeFactory : AceSqlServerDesignTimeDbContextFactory<BBSSystemManagementDbContext>
{
    public override AceDesignTimeDbContextOptions Options => new()
    {
        StartupProjectPath = @"../BBSSystemManagement.Web" //appsetting.json所在目录
    };
}
}
