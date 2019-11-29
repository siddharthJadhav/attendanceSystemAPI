using Microsoft.Extensions.Configuration;
using System;

namespace attendanceSystemAPI
{
    public class AppSetting
    {
        public AppSetting(IConfiguration Configuration)
        {
            EnvironmentVariableTarget target = EnvironmentVariableTarget.Process;

            string ConStr = Configuration["ConStr"];
            Environment.SetEnvironmentVariable("ConStr", ConStr, target);
        }
    }
}
