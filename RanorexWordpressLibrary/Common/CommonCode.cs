/*
 * Created by Ranorex
 * User: lan.tuan.le
 * Date: 12/8/2023
 * Time: 1:26 PM
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
    public class CommonCode
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
         
        [UserCodeMethod]
        public static void ReplaceString(string text, string replace)
        {
        	
        }
        
        [UserCodeMethod]
        public static string Get_value_return_variable(RepoItemInfo spantagInfo)
        {
//	        Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'spantagInfo' and assigning its value to variable 'return_variable'.", spantagInfo);
            string return_variable = spantagInfo.FindAdapter<SpanTag>().Element.GetAttributeValueText("InnerText");
            Report.Log(ReportLevel.Info, "Get", string.Format("Get_value_return_variable '{0}'.", return_variable), spantagInfo);
            return return_variable;
        }
        
        [UserCodeMethod]
        public static void Verify_Text_Exist(RepoItemInfo controlInfo, string varType, string varText)
        {
        	if(string.IsNullOrEmpty(varType))
        	{
        		varType = "InnerText";
        	}
        	Report.Log(ReportLevel.Info, "Validation", string.Format("Verify_Text_Exist type '{0}' exist text: {1}.", varType, varText), controlInfo);
            Validate.AttributeEqual(controlInfo, varType, varText);
        }

    }
}
