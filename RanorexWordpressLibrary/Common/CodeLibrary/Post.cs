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

namespace RanorexWordpressLibrary.Common
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
			RanorexWordpressLibraryRepository _repo = RanorexWordpressLibraryRepository.Instance;
			if(!string.IsNullOrEmpty(txtTitle))
			{
				Report.Log(ReportLevel.Info, "Input Text", string.Format("Input text '{0}'.", txtTitle));
				_repo.ApplicationUnderTest.Post.txtTitle.PressKeys(txtTitle);
			}
			
			if(!string.IsNullOrEmpty(txtContent))
			{
				Report.Log(ReportLevel.Info, "Input Text", string.Format("Input text '{0}'.", txtContent));
				_repo.ApplicationUnderTest.Post.txtContent.PressKeys(txtContent);
			}
		}
    }
}
