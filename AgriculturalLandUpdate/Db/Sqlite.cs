// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-22-2018
// ***********************************************************************
// <copyright file="Sqlite.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>sqlite数据库访问</summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace AgriculturalLandUpdate.Db
{
    /// <summary>
    /// Class Sqlite.
    /// </summary>
    public class Sqlite
    {
        private const string dbName = "db.sqlite";
        private SQLiteConnection connection;

        public Sqlite(string connStr)
        {
        }
        public Sqlite()
        {
            if (!File.Exists(dbName))
            {
                this.InitDatabase();
            }
            else
            {
                this.Open("Data Source="+dbName+";Version=3;");
            }
        }
        /// <summary>
        /// 打开数据库连接.
        /// </summary>
        /// <param name="connStr">The connection string.</param>
        public void Open(string connStr)
        {
            try
            {
                if (this.connection == null)
                {
                    this.connection = new SQLiteConnection(connStr);
                }
                if (this.connection != null && this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 关闭连接.
        /// </summary>
        public void Close()
        {
            if (this.connection != null && this.connection.State != 0)
            {
                this.connection.Close();
            }
        }
        /// <summary>
        /// 初始化数据库.
        /// </summary>
        public void InitDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(dbName);
                this.Open("Data Source="+dbName+";Version=3;");
                this.InitTables();
                this.InitRoleData();
                this.InitUserData();
                this.InitAuthData();
            }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
            }
        }
        /// <summary>
        /// 初始化表结构.
        /// </summary>
        public void InitTables()
        {
            string sqlUser = "CREATE TABLE user (id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,username varchar NOT NULL UNIQUE,password varchar NOT NULL,roleid integer NOT NULL)";
            string sqlRole = "CREATE TABLE role (id integer NOT NULL PRIMARY KEY AUTOINCREMENT,name varchar NOT NULL)";
            string sqlLog = "CREATE TABLE log (loglevel varchar,logtime timestamp,message varchar,eventtype varchar,user varchar)";
            string sqlAuth = "CREATE TABLE auth (id integer NOT NULL PRIMARY KEY AUTOINCREMENT,name varchar NOT NULL,roleid integer NOT NULL)";
            this.CreateTable(sqlUser);
            this.CreateTable(sqlRole);
            this.CreateTable(sqlLog);
            this.CreateTable(sqlAuth);
        }
        public void CreateTable(string sql)
        {
            SQLiteCommand sQLiteCommand = new SQLiteCommand(sql, this.connection);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// 初始化角色数据.
        /// </summary>
        public void InitRoleData()
        {
            new Role("超级管理员").Insert();
            new Role("管理员").Insert();
            new Role("标准用户").Insert();
        }
        /// <summary>
        /// 初始化超级管理员账号.
        /// </summary>
        public void InitUserData()
        {
            Role role = Role.Find("id = " + 1);
            new User("admin", SunGolden.Encryption.DEncrypt.Encrypt("123456"), role).Insert();
        }
        /// <summary>
        /// 初始化权限配置.
        /// </summary>
        public void InitAuthData()
        {
            string strAuth = "INSERT INTO auth (name,roleid) VALUES ('新建工程',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('打开工程',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('保存工程',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('云/阴影检测',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('云/阴影修复',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('样本分块',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('模型训练',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('农业用地分类',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('图斑更新',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('精度验证',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('权限管理',3);" +
                "INSERT INTO auth (name,roleid) VALUES ('日志管理',3);";
            SQLiteCommand sQLiteCommand = new SQLiteCommand(strAuth, this.connection);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// 执行sql事务
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ExecuteNonQuery(string sql)
        {
            SQLiteCommand sQLiteCommand = new SQLiteCommand(sql, this.connection);
            SQLiteTransaction sQLiteTransaction = this.connection.BeginTransaction();
            try
            {
                sQLiteCommand.ExecuteNonQuery();
                sQLiteTransaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                sQLiteTransaction.Rollback();
                LogMan.Log2File(null, ex);
                return false;
            }
            finally
            {
                this.Close();
            }
        }

        /// <summary>
        /// 执行sql查询.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns>SQLiteDataReader.</returns>
        public SQLiteDataReader Query(string sql)
        {
            SQLiteCommand sQLiteCommand = new SQLiteCommand(sql, this.connection);
            return sQLiteCommand.ExecuteReader();
        }
    }
}
