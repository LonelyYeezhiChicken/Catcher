﻿

namespace Catcher.Web.Config
{
    public static class DataBase
    {
        /// <summary>
        /// 資料庫連線
        /// </summary>
        /// <param name="builder"></param>
        public static void Connection(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<CatcherDb>();

            builder.Services.AddDbContext<CatcherDb>(options =>
                                            options.UseMySql(builder.Configuration.GetConnectionString("CatcherContext"), ServerVersion.Parse("8.0.29-mysql")));
        }
    }
}
