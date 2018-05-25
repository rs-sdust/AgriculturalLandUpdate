// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="UIIni.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>界面初始化相关功能</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgriculturalLandUpdate.Db;
using System.Windows.Forms;

namespace AgriculturalLandUpdate.Common
{
    class UIIni
    {
        /// <summary>
        /// 加载除su外的角色.
        /// </summary>
        public static void LoadRoles(ComboBox cmb)
        {
            List<Role> list = Role.Query("");
            try
            {
                foreach (Role item in list)
                {
                    string roleName = item.Name;
                    if (item.Id > 1)
                    {
                        cmb.Items.Add(item.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
            }
            finally
            {
                if (cmb.Items.Count > 0)
                {
                    cmb.SelectedIndex = 0;
                }
            }
        }
    }
}
