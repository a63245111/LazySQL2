//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autogeneration.Dao.SQL
{
    
    
    public class userInsertClass
    {
        
        public static LazySQL.Infrastructure.ExecuteNonModel userInsert(string user, string pwd, string power)
        {
            System.Text.StringBuilder StrbSQL = new System.Text.StringBuilder();
            LazySQL.Infrastructure.SQLiteTemplate sqlLiteT = new LazySQL.Infrastructure.SQLiteTemplate();
            try
            {
                System.Collections.Generic.List<System.Data.SQLite.SQLiteParameter> aList = new System.Collections.Generic.List<System.Data.SQLite.SQLiteParameter>();
                StrbSQL.Append("insert into user (user,pwd,power) values (");
                System.Text.StringBuilder par0 = new System.Text.StringBuilder();
                par0.Append("@user");
                par0.Append(" , ");
                if (!string.IsNullOrWhiteSpace(user))
                {
                    System.Data.SQLite.SQLiteParameter userPar = new System.Data.SQLite.SQLiteParameter("@user",user);
                    aList.Add(userPar);
                }
                else
                {
                    System.Data.SQLite.SQLiteParameter userPar = new System.Data.SQLite.SQLiteParameter("@user","''");
                    aList.Add(userPar);
                }
                par0.Append("@pwd");
                par0.Append(" , ");
                if (!string.IsNullOrWhiteSpace(pwd))
                {
                    System.Data.SQLite.SQLiteParameter pwdPar = new System.Data.SQLite.SQLiteParameter("@pwd",pwd);
                    aList.Add(pwdPar);
                }
                else
                {
                    System.Data.SQLite.SQLiteParameter pwdPar = new System.Data.SQLite.SQLiteParameter("@pwd","''");
                    aList.Add(pwdPar);
                }
                par0.Append("@power");
                if (!string.IsNullOrWhiteSpace(power))
                {
                    System.Data.SQLite.SQLiteParameter powerPar = new System.Data.SQLite.SQLiteParameter("@power",power);
                    aList.Add(powerPar);
                }
                else
                {
                    System.Data.SQLite.SQLiteParameter powerPar = new System.Data.SQLite.SQLiteParameter("@power","''");
                    aList.Add(powerPar);
                }
                StrbSQL.Append(par0);
                StrbSQL.Append(")");
                return sqlLiteT.ExecuteNonQuery("Data Source=db\\sqlliteTest.db;Initial Catalog=sqlliteTest;Integrated Security=Tru" +
                        "e;Max Pool Size=10", StrbSQL, aList);
            }
            catch (System.Exception ex)
            {
                throw ex;;
            }
        }
    }
}
