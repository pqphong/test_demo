using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestParserXML
{
    [TestMethod]
    public void CheckRequiredModulesTest_4_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list91 = new List<String>();
            String list91_0 = "MSN";
            String list91_1 = "OS";
            String list91_2 = "MCU";
            String list91_3 = "DEM";
            list91.Add(list91_0);
            list91.Add(list91_1);
            list91.Add(list91_2);
            list91.Add(list91_3);
            Object basicconfiguration113 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleRequired", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration113, list91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.isExistModuleNameString = (ParserXML instance, String moduleName) =>
            {
                Boolean boolean102 = true;
                return boolean102;
            }

            ;
            var userinterface114 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface114.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                Assert.IsTrue(false);
            }

            ;
            userinterface114.Exit = () =>
            {
                Assert.IsTrue(false);
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface114);
            /* Act */
            typeof(ParserXML).GetMethod("CheckRequiredModules", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
        /* Assert */
        }
    }

    [TestMethod]
    public void CheckRequiredModulesTest_4_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list95 = new List<String>();
            String list95_0 = "MSN";
            String list95_1 = "OS";
            String list95_2 = "MCU";
            String list95_3 = "DEM";
            list95.Add(list95_0);
            list95.Add(list95_1);
            list95.Add(list95_2);
            list95.Add(list95_3);
            Object basicconfiguration115 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleRequired", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration115, list95);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.isExistModuleNameString = (ParserXML instance, String moduleName) =>
            {
                if (moduleName == "MCU")
                {
                    Boolean boolean106 = false;
                    return boolean106;
                }
                else
                {
                    Boolean boolean106 = true;
                    return boolean106;
                }
            }

            ;
            var userinterface116 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface116.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 3)
                    Assert.IsTrue(true);
            }

            ;
            userinterface116.Exit = () =>
            {
                Assert.IsTrue(true);
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface116);
            /* Act */
            typeof(ParserXML).GetMethod("CheckRequiredModules", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
        /* Assert */
        }
    }

    [TestMethod]
    public void CheckRequiredModulesTest_4_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list99 = new List<String>();
            String list99_0 = "MSN";
            String list99_1 = "OS";
            String list99_2 = "MCU";
            String list99_3 = "DEM";
            list99.Add(list99_0);
            list99.Add(list99_1);
            list99.Add(list99_2);
            list99.Add(list99_3);
            Object basicconfiguration117 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleRequired", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration117, list99);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.isExistModuleNameString = (ParserXML instance, String moduleName) =>
            {
                if (moduleName == "MCU")
                {
                    Boolean boolean1010 = false;
                    return boolean1010;
                }
                else
                {
                    if (moduleName == "OS")
                    {
                        Boolean boolean1010 = false;
                        return boolean1010;
                    }
                    else
                    {
                        Boolean boolean1010 = true;
                        return boolean1010;
                    }
                }
            }

            ;
            var userinterface118 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface118.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 3)
                    Assert.IsTrue(true);
            }

            ;
            userinterface118.Exit = () =>
            {
                Assert.IsTrue(true);
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface118);
            /* Act */
            typeof(ParserXML).GetMethod("CheckRequiredModules", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
        /* Assert */
        }
    }
}