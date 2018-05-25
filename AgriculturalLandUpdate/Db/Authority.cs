// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-24-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="Authority.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>权限模型</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace AgriculturalLandUpdate.Db
{
    public class Authority
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string Name { get; set; }
        public Role Role { get; set; }
        //private static Dictionary<string, int> dicAuth = new Dictionary<string, int>();
        static Authority()
        {
            //try
            //{
            //    string strSql = "select * from auth;";
            //    Sqlite sqlite = new Sqlite();
            //    SQLiteDataReader reader=sqlite.Query(strSql);
            //    while (reader.Read())
            //    {
            //        string key = reader.GetString(1);
            //        int value = reader.GetInt32(2);
            //        dicAuth.Add(key, value);
            //    }
            //    sqlite.Close();
            //}
            //catch (Exception ex)
            //{
            //    LogMan.Log2File(null, ex);
            //}
 
        }
        /// <summary>
        /// 更新当前权限项
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Update()
        {
            string strSql=string.Format("update auth set name='{0}', roleid='{1}' where id={2}", this.Name, this.Role.Id,this.Id);
            Sqlite sqlite = new Sqlite();
            return sqlite.ExecuteNonQuery(strSql);
        }
        /// <summary>
        /// Queries the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>List&lt;User&gt;.</returns>
        public static List<Authority> Query(string where)
        {
            List<Authority> list = new List<Authority>();
            Sqlite sqlite = new Sqlite();
            string text = "SELECT A.id,A.name,R.id,R.name FROM auth A,role R WHERE A.roleid=R.id ";
            if (!string.IsNullOrEmpty(where))
            {
                text = text + " AND " + where;
            }
            SQLiteDataReader reader = sqlite.Query(text);
            while (reader.Read())
            {
                Authority auth = new Authority();
                auth.Id = reader.GetInt32(0);
                auth.Name=reader.GetString(1);
                Role role = new Role();
                role.Id = reader.GetInt32(2);
                role.Name = reader.GetString(3);
                auth.Role = role;
                list.Add(auth);
            }
            sqlite.Close();
            return list;
        }
        /// <summary>
        /// Finds the specified Authority.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>Authority.</returns>
        public static Authority Find(string where)
        {
            Authority auth = new Authority();
            Sqlite sqlite = new Sqlite();
            string text = "SELECT A.id,A.name,R.id,R.name FROM auth A,role R WHERE A.roleid=R.id ";
            if (!string.IsNullOrEmpty(where))
            {
                text = text + " AND A." + where;
            }
            SQLiteDataReader reader = sqlite.Query(text);
            while (reader.Read())
            {
                auth.Id = reader.GetInt32(0);
                auth.Name = reader.GetString(1);
                Role role = new Role();
                role.Id = reader.GetInt32(2);
                role.Name = reader.GetString(3);
                auth.Role = role;
            }
            sqlite.Close();
            return auth;
        }

        /// <summary>
        /// Checks the authentication.
        /// </summary>
        /// <param name="name">模块名称.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool CheckAuth(string name)
        {

            try
            {
                if (ConstDef.curUser == null)
                {
                    return false;
                }
                Authority auth = Find(string.Format("name = '{0}'", name));
                if (auth==null)
                {
                    return false;
                }
                if (ConstDef.curUser.RoleId > auth.Role.Id)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
                return false;
            }

        }
    }
}
