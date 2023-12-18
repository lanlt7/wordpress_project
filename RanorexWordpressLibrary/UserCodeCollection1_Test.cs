/*
 * Created by Ranorex
 * User: lan.tuan.le
 * Date: 12/8/2023
 * Time: 9:26 AM
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


namespace RanorexWordpressLibrary
{
	/// <summary>
	/// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
	/// </summary>
	/// 
	
	[UserCodeCollection]
	public class UserCodeCollection1_Test
	{
		// You can use the "Insert New User Code Method" functionality from the context menu,
		// to add a new method with the attribute [UserCodeMethod].
		
		
		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		/// 
		
		
		[UserCodeMethod]
		public static void filltitle(string txtTitle)
		{
			RanorexWordpressLibraryRepository _repo = RanorexWordpressLibraryRepository.Instance;
//	        var timeoutToWaitForAppToBeStarted = Duration.FromMilliseconds(10000);
			////	        var demoApp = Host.Local.FindSingle("/dom[@domain='webtest.ranorex.org']", timeoutToWaitForAppToBeStarted);
//	        var title = Host.Local.FindSingle<InputTag>(".//input[#'title']");
			_repo.ApplicationUnderTest.Post.txtTitle.PressKeys(txtTitle);
		}
	}
}
