using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestParserXML
{
    [TestMethod]
    public void CheckParamConfigTest_17_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswconfig91 = new BswConfig();
            String bswconfig91_ModuleId = "Valid";
            String bswconfig91_SwVersion = "Valid";
            String bswconfig91_VendorId = "Valid";
            String bswconfig91_ArReleaseVersion = "";
            bswconfig91.ModuleId = bswconfig91_ModuleId;
            bswconfig91.SwVersion = bswconfig91_SwVersion;
            bswconfig91.VendorId = bswconfig91_VendorId;
            bswconfig91.ArReleaseVersion = bswconfig91_ArReleaseVersion;
            BswConfig bswConfig = bswconfig91;
            String[] string102 = new String[4];
            String string102_0 = "ModuleId";
            String string102_1 = "SwVersion";
            String string102_2 = "VendorId";
            String string102_3 = "ArReleaseVersion";
            string102[0] = string102_0;
            string102[1] = string102_1;
            string102[2] = string102_2;
            string102[3] = string102_3;
            String[] requiredFields = string102;
            Dictionary<String, String> dictionary113 = new Dictionary<String, String>();
            String dictionary113_TagNameofArReleaseVersion = "ArReleaseVersion";
            dictionary113["TagName of ArReleaseVersion"] = dictionary113_TagNameofArReleaseVersion;
            Dictionary<String, String> tagNameToField = dictionary113;
            var userinterface111 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface111.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                Assert.IsTrue(true);
                if (errorCode != 30)
                    Assert.IsTrue(false);
                ;

            }

            ;
            userinterface111.ErrorCountGet = () => {
                return 1;
            };
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface111);
            
            /* Act */
            typeof(ParserXML).GetMethod("CheckParamConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig), typeof(String[]), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{bswConfig, requiredFields, tagNameToField});
        /* Assert */
        }
    }

    [TestMethod]
    public void CheckParamConfigTest_17_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswconfig96 = new BswConfig();
            String bswconfig96_ModuleId = "Valid";
            String bswconfig96_SwVersion = "Valid";
            String bswconfig96_VendorId = "Valid";
            String bswconfig96_ArReleaseVersion = "";
            bswconfig96.ModuleId = bswconfig96_ModuleId;
            bswconfig96.SwVersion = bswconfig96_SwVersion;
            bswconfig96.VendorId = bswconfig96_VendorId;
            bswconfig96.ArReleaseVersion = bswconfig96_ArReleaseVersion;
            BswConfig bswConfig = bswconfig96;
            String[] string107 = new String[4];
            String string107_0 = "ModuleId";
            String string107_1 = "SwVersion";
            String string107_2 = "VendorId";
            String string107_3 = "ArReleaseVersion";
            string107[0] = string107_0;
            string107[1] = string107_1;
            string107[2] = string107_2;
            string107[3] = string107_3;
            String[] requiredFields = string107;
            Dictionary<String, String> dictionary118 = new Dictionary<String, String>();
            String dictionary118_TagNameofArReleaseVersion = "ArReleaseVersion";
            dictionary118["TagName of ArReleaseVersion"] = dictionary118_TagNameofArReleaseVersion;
            Dictionary<String, String> tagNameToField = dictionary118;
            var userinterface113 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface113.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                Assert.IsTrue(true);
                if (errorCode != 30)
                    Assert.IsTrue(false);
                ;
            }

            ;

            userinterface113.ErrorCountGet = () => {
                return 0;
            };

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface113);
            /* Act */
            typeof(ParserXML).GetMethod("CheckParamConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig), typeof(String[]), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{bswConfig, requiredFields, tagNameToField});
        /* Assert */
        }
    }
}