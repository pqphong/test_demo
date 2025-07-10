using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestParserXML
{
    [TestMethod]
    public void ValidateBswConfigurationDetailTest_33_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswConfig = null;
            IBasicConfiguration ibasicconfiguration102 = BasicConfiguration.Instance;
            String ibasicconfiguration102_ModuleName = "Lin";
            ibasicconfiguration102.ModuleName = ibasicconfiguration102_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration102);
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface116 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface116.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface116.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface116);
            /* Act */
            typeof(ParserXML).GetMethod("ValidateBswConfigurationDetail", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig)}, null).Invoke(_target, new object[]{bswConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void ValidateBswConfigurationDetailTest_33_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswconfig96 = new BswConfig();
            String bswconfig96_DescriptionShortName = null;
            bswconfig96.DescriptionShortName = bswconfig96_DescriptionShortName;
            BswConfig bswConfig = bswconfig96;
            IBasicConfiguration ibasicconfiguration107 = BasicConfiguration.Instance;
            String ibasicconfiguration107_ModuleName = "Can";
            ibasicconfiguration107.ModuleName = ibasicconfiguration107_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration107);
            Int32 int32118 = 0;
            Int32 flag = int32118;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface117.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);
            /* Act */
            typeof(ParserXML).GetMethod("ValidateBswConfigurationDetail", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig)}, null).Invoke(_target, new object[]{bswConfig});
            /* Assert */
            Assert.AreEqual((Int32)26, (Int32)flag);
        }
    }

    [TestMethod]
    public void ValidateBswConfigurationDetailTest_33_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswconfig911 = new BswConfig();
            String bswconfig911_DescriptionShortName = "Lin";
            bswconfig911.DescriptionShortName = bswconfig911_DescriptionShortName;
            BswConfig bswConfig = bswconfig911;
            IBasicConfiguration ibasicconfiguration1012 = BasicConfiguration.Instance;
            String ibasicconfiguration1012_ModuleName = "Can";
            ibasicconfiguration1012.ModuleName = ibasicconfiguration1012_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration1012);
            Int32 int321113 = 0;
            Int32 flag = int321113;
            var userinterface118 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface118.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface118.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface118);
            /* Act */
            typeof(ParserXML).GetMethod("ValidateBswConfigurationDetail", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig)}, null).Invoke(_target, new object[]{bswConfig});
            /* Assert */
            Assert.AreEqual((Int32)26, (Int32)flag);
        }
    }
}