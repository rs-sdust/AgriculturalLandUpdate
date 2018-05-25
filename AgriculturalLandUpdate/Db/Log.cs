// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-22-2018
// ***********************************************************************
// <copyright file="log.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>日志模型</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SQLite;

namespace AgriculturalLandUpdate.Db
{
    /// <summary>
    /// Class log.
    /// </summary>
    public class Log
    {
        public string User{get;set;}
        public LogLevel LogLevel { get; set; }
        public EventType EventType { get; set; }
        public string Message { get; set; }
        public DateTime LogTime { get; set; }
        public Log()
        {
            if (ConstDef.curUser!=null)
             User = ConstDef.curUser.UserName;
        }
        public Log(LogLevel level,EventType eventType,string message,DateTime logTime)
        {
            if (ConstDef.curUser != null)
                User = ConstDef.curUser.UserName;
            this.LogLevel = level;
            this.EventType = eventType;
            this.Message = message;
            this.LogTime = logTime;
        }
        public static List<object[]> Query(DateTime? startDate, DateTime? endDate, string user)
        {
            StringBuilder stringBuilder = new StringBuilder("select * from log ");
            ArrayList arrayList = new ArrayList();
            if (!string.IsNullOrEmpty(user))
            {
                arrayList.Add("user = '" + user + "'");
            }
            DateTime dateTime;
            if (startDate.HasValue && startDate.HasValue)
            {
                ArrayList arrayList2 = arrayList;
                dateTime = startDate.Value;
                arrayList2.Add("logtime > datetime('" + dateTime.ToString(ConstDef.shortDate) + "')");
            }
            if (endDate.HasValue && endDate.HasValue)
            {
                ArrayList arrayList3 = arrayList;
                dateTime = endDate.Value;
                arrayList3.Add("logtime < datetime('" + dateTime.ToString(ConstDef.shortDate) + "')");
            }
            string text = "";
            if (arrayList.Count > 0)
            {
                string[] value = (string[])arrayList.ToArray(typeof(string));
                text = string.Join(" and ", value);
            }
            if (!string.IsNullOrEmpty(text))
            {
                stringBuilder.Append(" where " + text);
            }
            stringBuilder.Append(" order by logtime desc");
            List<object[]> list = new List<object[]>();
            Sqlite sqliteHelper = new Sqlite();
            SQLiteDataReader sQLiteDataReader = sqliteHelper.Query(stringBuilder.ToString());
            while (sQLiteDataReader.Read())
            {
                object[] array = new object[5]
			{
				sQLiteDataReader.GetString(0),
				sQLiteDataReader.GetString(4),
				sQLiteDataReader.GetString(3),
				sQLiteDataReader.GetString(2),
				sQLiteDataReader.GetDateTime(1)
			};
                list.Add(array);
            }
            sqliteHelper.Close();
            return list;
        }
        public static void Delete(string loglevel, string eventType, DateTime? startDate, DateTime? endDate, string user)
        {
            StringBuilder stringBuilder = new StringBuilder("delete from log ");
            ArrayList arrayList = new ArrayList();
            if (!string.IsNullOrEmpty(loglevel))
            {
                arrayList.Add("loglevel = '" + loglevel + "'");
            }
            if (!string.IsNullOrEmpty(eventType))
            {
                arrayList.Add("eventtype = '" + eventType + "'");
            }
            if (!string.IsNullOrEmpty(user))
            {
                arrayList.Add("user = '" + user + "'");
            }
            DateTime value;
            if (startDate.HasValue && startDate.HasValue)
            {
                ArrayList arrayList2 = arrayList;
                value = startDate.Value;
                arrayList2.Add("logtime > datetime('" + value.ToString("yyyy-MM-dd HH:mm:ss") + "')");
            }
            if (endDate.HasValue && endDate.HasValue)
            {
                ArrayList arrayList3 = arrayList;
                value = endDate.Value;
                arrayList3.Add("logtime < datetime('" + value.ToString("yyyy-MM-dd HH:mm:ss") + "')");
            }
            string text = "";
            if (arrayList.Count > 0)
            {
                string[] value2 = (string[])arrayList.ToArray(typeof(string));
                text = string.Join(" and ", value2);
            }
            if (!string.IsNullOrEmpty(text))
            {
                stringBuilder.Append(" where " + text);
            }
            Sqlite sqliteHelper = new Sqlite();
            sqliteHelper.Query(stringBuilder.ToString());
            sqliteHelper.Close();
        }
    }




    public enum LogLevel
    {
        Debug,
        Info,
        Success,
        Warn,
        Error,
        Fatal
    }
    public enum EventType
    {
        用户管理,
        权限管理,
        标准化预处理,
        农业用地更新
    }
}
