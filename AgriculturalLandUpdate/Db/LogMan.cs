// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-23-2018
// ***********************************************************************
// <copyright file="LogMan.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>日志管理</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AgriculturalLandUpdate.Db
{
    public class LogMan
    {
        /// <summary>
        /// 记录异常日志到本地文件.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="ex">The ex.</param>
        public static void Log2File(Log log, Exception ex)
        {
            string logStr = "【记录时间】：{0}\r\n【日志级别】：{1}\r\n【错误信息】：{2}\r\n";
            if (log != null)
            {
                logStr = string.Format(logStr, log.LogTime, log.LogLevel, ex.Message + "\r\n" + ex.StackTrace + "\r\n");
                File.AppendAllText(ConstDef.logFile, logStr);
            }
            else
            {
                if (ex != null)
                {
                    logStr = string.Format(logStr, DateTime.Now.ToString(ConstDef.longDate), "ERROR", ex.Message + "\r\n" + ex.StackTrace + "\r\n");
                    File.AppendAllText(ConstDef.logFile, logStr);
                }
            }
        }
        /// <summary>
        /// 记录操作日志到sqlite.
        /// </summary>
        /// <param name="log">The log.</param>
        public static void Log2Sqlite(Log log)
        {
            if (log != null)
            {
                try
                {
                    string strSql = string.Format("INSERT INTO log (loglevel,logtime,message,eventtype,user) VALUES ('{0}','{1}','{2}','{3}','{4}');", log.LogLevel, log.LogTime.ToString(ConstDef.longDate), log.Message, log.EventType, log.User);
                    Sqlite sqlite = new Sqlite();
                    sqlite.ExecuteNonQuery(strSql);
                    sqlite.Close();
                }
                catch (Exception ex)
                {
                    Log2File(null,ex);
                }
            }
        }
    }
}
