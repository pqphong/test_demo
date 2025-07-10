using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestCommandLine
{
    [TestMethod]
    public void DisplayCmdInformationTest_55_1()
    {
        using (ShimsContext.Create())
        {
            
            ObjectFactory.SelectedDllPaths = new List<string>() { @"U:\external\X2x\common\generic\generator\dlls\E2x\DioE2x.dll", "U2x.dll" };
            IBasicConfiguration basicConfiguration = (IBasicConfiguration)_target.GetType().GetField("basicConfiguration", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            basicConfiguration.ModuleName = "Dio";
            basicConfiguration.DeviceVariant = "E2x";

            
            /* Act */
            _target.GetType().GetMethod("DisplayCmdInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual(ObjectFactory.ModuleDllName, "DioE2x.dll");
        }
    }

    
}