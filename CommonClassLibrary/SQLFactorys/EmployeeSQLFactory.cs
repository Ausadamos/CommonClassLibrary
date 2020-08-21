using CommonClassLibrary.Propertys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonClassLibrary.SQLFactorys
{
    public class EmployeeSQLFactory
    {
        string sql = "";
        string tableName = CommonClass.DB_OPERATOR;

        public string SearchOne(EmployeeProperty dataItem)
        {
            sql = @"SELECT * FROM tableName 
                             where EmpCode = 'dataItem.EmpCode' 
                             AND EmpCodeResign is null ";

            sql = sql.Replace("tableName", tableName);
            sql = sql.Replace("dataItem.EmpCode", dataItem.EmpCode);
            return sql;
        }
    }
}