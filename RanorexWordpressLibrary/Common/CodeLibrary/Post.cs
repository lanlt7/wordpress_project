/*
 * Created by Ranorex
 * User: lan.tuan.le
 * Date: 12/7/2023
 * Time: 4:46 PM
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RanorexWordpressLibrary.Common.CodeLibrary
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class Post
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        [UserCodeMethod]
        public static void FillPost(string txtTitle, string txtContent)
        {
        	Textbox.InputText(RepoItemInfo 

        }
        
		[UserCodeMethod]
        public void Mouse_Click_txtContent(RepoItemInfo textareatagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'textareatagInfo' at 407;77.", textareatagInfo);
            textareatagInfo.FindAdapter<TextAreaTag>().Click();
        }
    }
}
