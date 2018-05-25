// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-23-2018
// ***********************************************************************
// <copyright file="ConstDef.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>静态配置</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaterialSkin;
using System.IO;

namespace AgriculturalLandUpdate
{
    public class ConstDef
    {
        public static string mainPath = Environment.CurrentDirectory;
        public static MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public static Db.User curUser;
        public static string shortDate = "yyyy-MM-dd";
        public static string longDate = "yyyy-MM-dd HH:mm:ss";
        public static string logFile = string.Format(@"log\{0}.log", DateTime.Now.ToString(shortDate));
        static ConstDef()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue700, Accent.Blue400, TextShade.WHITE);
        }
    }
}
