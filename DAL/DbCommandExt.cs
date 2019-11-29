using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace attendanceSystemAPI.DAL
{
    public static class DbCommandExt
    {
        public static DbCommand CreateDbCMD(this DbConnection con, CommandType cmdtype, string cmdtext)
        {
            DbCommand cmd = con.CreateCommand();
            cmd.CommandType = cmdtype;
            cmd.CommandText = cmdtext;
            cmd.Connection = con;
            return cmd;
        }

        public static void AddCMDParam(this DbCommand cmd, string parametername, object value)
        {
            DbParameter param = cmd.CreateParameter();
            param.ParameterName = parametername;
            param.Value = value;
            cmd.Parameters.Add(param);
        }

        public static void AddCMDParam(this DbCommand cmd, string parametername, object value, DbType dbtype)
        {
            DbParameter param = cmd.CreateParameter();
            param.ParameterName = parametername;
            param.Value = value == null ? DBNull.Value : value;
            param.DbType = dbtype;
            cmd.Parameters.Add(param);
        }
    }
}
