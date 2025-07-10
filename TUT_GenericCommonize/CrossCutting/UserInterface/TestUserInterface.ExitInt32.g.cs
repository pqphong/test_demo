using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestUserInterface
{
    [TestMethod]
    public void ExitTest_40_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean91 = true;
            _target.GetType().GetField("inExitMode", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean91);
            IRuntimeConfiguration iruntimeconfiguration102 = RuntimeConfiguration.Instance;
            Boolean iruntimeconfiguration102_DryRun = true;
            iruntimeconfiguration102.DryRun = iruntimeconfiguration102_DryRun;
            _target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration102);
            Int32 int32113 = 0;
            Int32 errorCode1 = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimEnvironmentWrapper.ExitInt32 = (Int32 exitCode) =>
            {
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {
                errorCode1 = code;
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoErrorCodeInt32 = (instance,c)=>
            {
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.writeLog = (instance) =>
            {

            };
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {

            };
            System.IO.Fakes.ShimStreamWriter.AllInstances.Close = (instance) =>
            {

            };
            System.IO.Fakes.ShimStreamWriter.AllInstances.Flush = (instance) =>
            {

            };
            /* Act */
            _target.Exit(1);
            /* Assert */
            Assert.AreEqual(5, errorCode1);
        }
    }

    [TestMethod]
    public void ExitTest_40_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean96 = false;
            _target.GetType().GetField("inExitMode", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean96);
            IRuntimeConfiguration iruntimeconfiguration107 = RuntimeConfiguration.Instance;
            Boolean iruntimeconfiguration107_DryRun = false;
            iruntimeconfiguration107.DryRun = iruntimeconfiguration107_DryRun;
            iruntimeconfiguration107.FolderOutput = "";
            IBasicConfiguration basicConfig = BasicConfiguration.Instance;
            basicConfig.ModuleName = "Can";
            _target.GetType().GetField("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, basicConfig);
            _target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration107);
            Int32 int32118 = 0;
            Int32 errorCode1 = int32118;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimEnvironmentWrapper.ExitInt32 = (Int32 exitCode) =>
            {
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {
                errorCode1 = code;
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoErrorCodeInt32 = (instance, c) =>
            {
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.writeLog = (instance) =>
            {

            };
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {

            };
            /* Act */
            _target.Exit(1);
            /* Assert */
            Assert.AreEqual(5, errorCode1);
        }
    }

    [TestMethod]
    //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
    public void ExitTest_40_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean96 = false;
            _target.GetType().GetField("inExitMode", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean96);
            IRuntimeConfiguration iruntimeconfiguration107 = RuntimeConfiguration.Instance;
            Boolean iruntimeconfiguration107_DryRun = true;
            _target.GetType().GetField("swLog", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, null);
            iruntimeconfiguration107.DryRun = iruntimeconfiguration107_DryRun;
            iruntimeconfiguration107.FolderOutput = "";
            IBasicConfiguration basicConfig = BasicConfiguration.Instance;
            basicConfig.ModuleName = "Can";
            _target.GetType().GetField("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, basicConfig);
            _target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration107);
            Int32 int32118 = 0;
            Int32 errorCode1 = int32118;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimEnvironmentWrapper.ExitInt32 = (Int32 exitCode) =>
            {
             
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {
                errorCode1 = code;
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoErrorCodeInt32 = (instance, c) =>
            {
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.writeLog = (instance) =>
            {

            };
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {

            };
            /* Act */
            _target.Exit(1);
            /* Assert */
            Assert.AreEqual(5, errorCode1);
        }
    }

    [TestMethod]
   // [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
    public void ExitTest_40_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean96 = false;
            _target.GetType().GetField("inExitMode", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean96);
            IRuntimeConfiguration iruntimeconfiguration107 = RuntimeConfiguration.Instance;
            Boolean iruntimeconfiguration107_DryRun = false;
            iruntimeconfiguration107.DryRun = iruntimeconfiguration107_DryRun;
            iruntimeconfiguration107.FolderOutput = "";
            IBasicConfiguration basicConfig = BasicConfiguration.Instance;
            basicConfig.ModuleName = "Can";
            _target.GetType().GetField("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, basicConfig);
            _target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration107);
            Int32 int32118 = 0;
            Int32 errorCode1 = int32118;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimEnvironmentWrapper.ExitInt32 = (Int32 exitCode) =>
            {
            }

            ;

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.OpenFileString = (instance,file) =>
            {
                throw new Exception();
            };
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {
                errorCode1 = code;
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoErrorCodeInt32 = (instance, c) =>
            {
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.writeLog = (instance) =>
            {

            };
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {

            };
            System.IO.Fakes.ShimStreamWriter.AllInstances.Close = (instance) =>
            {

            };
            System.IO.Fakes.ShimStreamWriter.AllInstances.Flush = (instance) =>
            {

            };
            /* Act */
            _target.Exit(0);
            /* Assert */
            Assert.AreEqual(5, errorCode1);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
    public void ExitTest_40_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean96 = false;
            _target.GetType().GetField("inExitMode", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean96);
            IRuntimeConfiguration iruntimeconfiguration107 = null;
            _target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration107);
            
            Int32 int32118 = 0;
            Int32 errorCode1 = int32118;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimEnvironmentWrapper.ExitInt32 = (Int32 exitCode) =>
            {
            }

            ;

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.OpenFileString = (instance, file) =>
            {
                throw new Exception();
            };
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {
                errorCode1 = code;
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoErrorCodeInt32 = (instance, c) =>
            {
            };

            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.writeLog = (instance) =>
            {

            };
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, id, code, res, errorCount) =>
            {

            };
            /* Act */
            _target.Exit(0);
            /* Assert */
            Assert.AreEqual(0, errorCode1);
        }
    }
}