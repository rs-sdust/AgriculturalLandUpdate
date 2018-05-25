// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-22-2018
// ***********************************************************************
// <copyright file="User.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>用户模型</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace AgriculturalLandUpdate.Db
{
    /// <summary>
    /// Class User.
    /// </summary>
    public class User
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
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        /// <value>The role identifier.</value>
        public int RoleId { get; set; }
        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>The role.</value>
        public Role Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="role">The role.</param>
        public User(string username, string password, Role role)
        {
            this.UserName = username;
            this.Password = password;
            this.Role = role;
            this.RoleId = role.Id;
        }
        /// <summary>
        /// Inserts this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Insert()
        {
            string sql = string.Format("INSERT INTO user (USERNAME,PASSWORD,ROLEID) VALUES ('{0}','{1}',{2})", this.UserName, this.Password, this.RoleId);
            Sqlite sqlite = new Sqlite();
            return sqlite.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// Finds the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>User.</returns>
        public static User Find(string username)
        {
            User user = null;
            string sql = "SELECT U.ID,U.USERNAME,U.PASSWORD,R.ID,R.NAME FROM user U,role R WHERE R.ID=U.ROLEID AND U.USERNAME ='" + username + "'";
            Sqlite sqlite = new Sqlite();
            SQLiteDataReader sQLiteDataReader = sqlite.Query(sql);
            while (sQLiteDataReader.Read())
            {
                user = new User();
                user.Id = sQLiteDataReader.GetInt32(0);
                user.UserName = sQLiteDataReader.GetString(1);
                user.Password = sQLiteDataReader.GetString(2);
                Role role = new Role();
                role.Id = sQLiteDataReader.GetInt32(3);
                role.Name = sQLiteDataReader.GetString(4);
                user.Role = role;
                user.RoleId = role.Id;
            }
            sqlite.Close();
            return user;
        }
        /// <summary>
        /// Queries the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>List&lt;User&gt;.</returns>
        public static List<User> Query(string where)
        {
            List<User> list = new List<User>();
            Sqlite sqlite = new Sqlite();
            string text = "SELECT U.ID,U.USERNAME,U.PASSWORD,R.ID,R.NAME FROM user U,role R WHERE R.ID=U.ROLEID ";
            if (!string.IsNullOrEmpty(where))
            {
                text = text + " AND " + where;
            }
            SQLiteDataReader sQLiteDataReader = sqlite.Query(text);
            while (sQLiteDataReader.Read())
            {
                User user = new User();
                user.Id = sQLiteDataReader.GetInt32(0);
                user.UserName = sQLiteDataReader.GetString(1);
                user.Password = sQLiteDataReader.GetString(2);
                Role role = new Role();
                role.Id = sQLiteDataReader.GetInt32(3);
                role.Name = sQLiteDataReader.GetString(4);
                user.Role = role;
                user.RoleId = role.Id;
                list.Add(user);
            }
            sqlite.Close();
            return list;
        }
        /// <summary>
        /// Updates the specified is need update password.
        /// </summary>
        /// <param name="isNeedUpdatePwd">if set to <c>true</c> [is need update password].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Update(bool isNeedUpdatePwd = true)
        {
            string empty = string.Empty;
            empty = string.Format("update user set username='{0}', password='{1}',roleid={2} where id={3}", this.UserName, this.Password, this.RoleId, this.Id);
            Sqlite sqlite = new Sqlite();
            return sqlite.ExecuteNonQuery(empty);
        }
        /// <summary>
        /// Deletes this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Delete()
        {
            string sql = "delete from user where id=" + this.Id;
            Sqlite sqlite = new Sqlite();
            return sqlite.ExecuteNonQuery(sql);
        }
    }
}
