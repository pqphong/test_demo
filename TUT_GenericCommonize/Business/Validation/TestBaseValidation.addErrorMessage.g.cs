using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestBaseValidation
{
    [TestMethod]
    public void addErrorMessageTest_120_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "can";
            String moduleName = string91;
            var repository115 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository115.GetCdfFileNameString = (String _moduleName) =>
            {
                String string102 = "can.arxml";
                return string102;
            }

            ;
            repository115.GetConfigurationString = (String _moduleName) =>
            {
                Configuration configuration157 = new Configuration();
                String configuration157_ShortName = "Can";
                configuration157.ShortName = configuration157_ShortName;
                return configuration157;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository115);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String _path, Nullable<Int32> exitCode) =>
            {
                String string113 = @"D:\internal\can.arxml";
                return string113;
            }

            ;
            String string124 = "CanDeviceName";
            String param = string124;
            String string135 = "CanGeneral";
            String defName = string135;
            String string146 = @"D:\internal\can.arxml";
            String path = string146;
            String variant = "Variant_1";
            /* Act */
            String actualResult = (String)typeof(BaseValidation).GetMethod("addErrorMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, param, defName, path, variant});
            /* Assert */
            Assert.IsTrue(actualResult.Contains("CanDeviceName"));
            Assert.IsTrue(actualResult.Contains("CanGeneral"));
            Assert.IsTrue(actualResult.Contains("Path: D:\\internal\\can.arxml"));
            Assert.IsTrue(actualResult.Contains("Variant_1"));
        }
    }

    [TestMethod]
    public void addErrorMessageTest_120_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string98 = "can";
            String moduleName = string98;
            var repository116 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository116.GetCdfFileNameString = (String _moduleName) =>
            {
                String string109 = "";
                return string109;
            }

            ;
            repository116.GetConfigurationString = (String _moduleName) =>
            {
                Configuration configuration1514 = new Configuration() { ShortName = "" };
                return configuration1514;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository116);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String _path, Nullable<Int32> exitCode) =>
            {
                String string1110 = @"D:\internal\can.arxml";
                return string1110;
            }

            ;
            String string1211 = "CanDeviceName";
            String param = string1211;
            String string1312 = "CanGeneral";
            String defName = string1312;
            String string1413 = @"D:\internal\can.arxml";
            String path = string1413;
            String variant = "";
            /* Act */
            String actualResult = (String)typeof(BaseValidation).GetMethod("addErrorMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, param, defName, path, variant});
            /* Assert */
            Assert.IsTrue(actualResult.Contains("CanDeviceName"));
            Assert.IsTrue(actualResult.Contains("CanGeneral"));
            Assert.IsTrue(!actualResult.Contains("Path: can.arxml"));
        }
    }
}