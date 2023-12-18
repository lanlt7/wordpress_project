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

namespace Sample
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DragAndVerify recording.
    /// </summary>
    [TestModule("6cc1b330-58ce-4920-9392-0aaeaeb36b2c", ModuleType.Recording, 1)]
    public partial class DragAndVerify : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RanorexWordpressLibrary.RanorexWordpressLibraryRepository repository.
        /// </summary>
        public static global::RanorexWordpressLibrary.RanorexWordpressLibraryRepository repo = global::RanorexWordpressLibrary.RanorexWordpressLibraryRepository.Instance;

        static DragAndVerify instance = new DragAndVerify();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DragAndVerify()
        {
            varTextReturn = "";
            varTextLink = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DragAndVerify Instance
        {
            get { return instance; }
        }

#region Variables

        string _varTextReturn;

        /// <summary>
        /// Gets or sets the value of variable varTextReturn.
        /// </summary>
        [TestVariable("594caf1f-8fbd-41de-975b-d433b4f84db0")]
        public string varTextReturn
        {
            get { return _varTextReturn; }
            set { _varTextReturn = value; }
        }

        string _varTextLink;

        /// <summary>
        /// Gets or sets the value of variable varTextLink.
        /// </summary>
        [TestVariable("15b4e25a-9561-4314-9176-50d915b4e8f3")]
        public string varTextLink
        {
            get { return _varTextLink; }
            set { _varTextLink = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.DragNDropLibrary.DragAndDrop(repo.ApplicationUnderTest.Post.InsertMediaButton, repo.ApplicationUnderTest.Post.txtContent);
            Delay.Milliseconds(0);
            
            varTextReturn = RanorexWordpressLibrary.Common.CommonCode.Get_value_return_variable(repo.ApplicationUnderTest.Post.QtContentCloseInfo, "value");
            Delay.Milliseconds(0);
            
            Ranorex.AutomationHelpers.UserCodeCollections.ValidationLibrary.CompareValues(varTextReturn, varTextLink);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}