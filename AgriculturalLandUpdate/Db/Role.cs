// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-22-2018
// ***********************************************************************
// <copyright file="Role.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>用户角色</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace AgriculturalLandUpdate.Db
{
    /// <summary>
    /// Class Role.
    /// </summary>
    public class Role
    {
        private static Dictionary<int, string> dicRole = new Dictionary<int, string>();
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id{get;set;}
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        //public int Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
        }
        static Role()
        {
            Sqlite sqlite = new Sqlite();
            SQLiteDataReader sQLiteDataReader = sqlite.Query("select * from role;");
            while (sQLiteDataReader.Read())
            {
                int key = sQLiteDataReader.GetInt32(0);
                string value = sQLiteDataReader.GetString(1);
                dicRole.Add(key, value);
            }
            sqlite.Close();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="code">The code.</param>
        public Role(string name)
        {
            this.Name = name;
        }
        public Role(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
        /// <summary>
        /// Finds the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>Role.</returns>
        public static Role Find(string where)
        {
            Role role = new Role();
            Sqlite sqlite = new Sqlite();
            string text = "select * from role ";
            if (!string.IsNullOrEmpty(where))
            {
                text = text + " where " + where;
            }
            SQLiteDataReader sQLiteDataReader = sqlite.Query(text);
            while (sQLiteDataReader.Read())
            {
                role.Id = sQLiteDataReader.GetInt32(0);
                role.Name = sQLiteDataReader.GetString(1);
            }
            sqlite.Close();
            return role;
        }

        /// <summary>
        /// Inserts this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Insert()
        {
            string sql = string.Format("INSERT INTO role (NAME) VALUES ('{0}')", this.Name);
            Sqlite sqlite = new Sqlite();
            return sqlite.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// Queries the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>List&lt;Role&gt;.</returns>
        public static List<Role> Query(string where)
        {
            List<Role> list = new List<Role>();
            string text = "select id,name from role ";
            if (!string.IsNullOrEmpty(where))
            {
                text = text + " where " + where;
            }
            Sqlite sqlite = new Sqlite();
            SQLiteDataReader sQLiteDataReader = sqlite.Query(text);
            while (sQLiteDataReader.Read())
            {
                Role role = new Role();
                role.Id = sQLiteDataReader.GetInt32(0);
                role.Name = sQLiteDataReader.GetString(1);
                list.Add(role);
            }
            sqlite.Close();
            return list;
        }
        public static string GetRoleName(int RoleId)
        {
            return dicRole[RoleId];
        }
    }
}
