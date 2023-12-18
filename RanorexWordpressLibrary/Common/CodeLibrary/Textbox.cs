/*
 * Created by Ranorex
 * User: lan.tuan.le
 * Date: 12/7/2023
 * Time: 11:17 AM
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

using OpenQA.Selenium;
using System.Linq;
using RanorexWordpressLibrary.Common;


namespace RanorexWordpressLibrary.Common
{
	/// <summary>
	/// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
	/// </summary>
	[UserCodeCollection]
	public class Textbox
	{
		// You can use the "Insert New User Code Method" functionality from the context menu,
		// to add a new method with the attribute [UserCodeMethod].
		
		
		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void InputText(RepoItemInfo inputText, string text)
		{    		
			if (!string.IsNullOrEmpty(text))
        	{
    			Report.Log(ReportLevel.Info, "Input Text", string.Format("Input text '{0}'.", text), inputText);
    			var control = inputText.FindAdapter<InputTag>();
    			if (WebDriverExtension.IsWebDriverEndPoint())
    			{
    				control.PressKeys(Keys.Control + "a");
    			}
    			else
    			{
    				Keyboard.PrepareFocus(control.Element);
            		Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
    			}
    			Delay.Milliseconds(1000);
            	control.PressKeys(text);
			}
		}
		
	}

}
