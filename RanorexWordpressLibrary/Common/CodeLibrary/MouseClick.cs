/*
 * Created by Ranorex
 * User: lan.tuan.le
 * Date: 12/7/2023
 * Time: 3:05 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RanorexWordpressLibrary.Common
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class MouseClick
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        

        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void Mouse_Click_Left_Side_Menu(RepoItemInfo leftMenu, RepoItemInfo contextLeftMenu )
        {
            Report.Log(ReportLevel.Info, "Mouse", string.Format("Mouse Left Click item '{0}' at Center.", leftMenu), leftMenu);
            leftMenu.FindAdapter<DivTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", string.Format("Mouse Left Click item '{0}' at Center.", contextLeftMenu), contextLeftMenu);
            contextLeftMenu.FindAdapter<ATag>().Click();
        }
    }
}
