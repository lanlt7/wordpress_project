﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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

namespace RanorexWordpressLibrary.Record.Post
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateNewPost recording.
    /// </summary>
    [TestModule("43d43b42-1ad6-4102-8d4f-b2374f20ea45", ModuleType.Recording, 1)]
    public partial class CreateNewPost : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RanorexWordpressLibrary.RanorexWordpressLibraryRepository repository.
        /// </summary>
        public static global::RanorexWordpressLibrary.RanorexWordpressLibraryRepository repo = global::RanorexWordpressLibrary.RanorexWordpressLibraryRepository.Instance;

        static CreateNewPost instance = new CreateNewPost();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewPost()
        {
            varTitle = "";
            varContent = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewPost Instance
        {
            get { return instance; }
        }

#region Variables

        string _varTitle;

        /// <summary>
        /// Gets or sets the value of variable varTitle.
        /// </summary>
        [TestVariable("94f8039e-5bef-45d4-bbf6-289d78e02ba6")]
        public string varTitle
        {
            get { return _varTitle; }
            set { _varTitle = value; }
        }

        string _varContent;

        /// <summary>
        /// Gets or sets the value of variable varContent.
        /// </summary>
        [TestVariable("27ed0fb0-0648-43e9-af23-a2a1772de227")]
        public string varContent
        {
            get { return _varContent; }
            set { _varContent = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Common.MouseClick.Mouse_Click_Left_Side_Menu(repo.ApplicationUnderTest.LeftSideBar.PostsInfo, repo.ApplicationUnderTest.LeftSideBar.contextmenuAddNewInfo);
            Delay.Milliseconds(0);
            
            Common.Post.FillPost(varTitle, varContent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Post.btnPublish' at Center.", repo.ApplicationUnderTest.Post.btnPublishInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Post.btnPublish.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
