using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestBaseIntermediate
{
    [TestMethod]
    public void ComputeAutosarVersionTest_178_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration91 = BasicConfiguration.Instance;
            String ibasicconfiguration91_AutoSARVersion = "4.2.2";
            String ibasicconfiguration91_ModuleName = "Can";
            ibasicconfiguration91.AutoSARVersion = ibasicconfiguration91_AutoSARVersion;
            ibasicconfiguration91.ModuleName = ibasicconfiguration91_ModuleName;
            typeof(BaseIntermediate).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration91);
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(BaseIntermediate).GetMethod("ComputeAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_name_14 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CAN_AR_VERSION", (String)actualResult_name_14);
            Object actualResult_value_15 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CAN_AR_422_VERSION", (String)actualResult_value_15);
        }
    }

    [TestMethod]
    public void ComputeAutosarVersionTest_178_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration92 = BasicConfiguration.Instance;
            String ibasicconfiguration92_AutoSARVersion = "4.3.1";
            String ibasicconfiguration92_ModuleName = "Can";
            ibasicconfiguration92.AutoSARVersion = ibasicconfiguration92_AutoSARVersion;
            ibasicconfiguration92.ModuleName = ibasicconfiguration92_ModuleName;
            typeof(BaseIntermediate).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration92);
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(BaseIntermediate).GetMethod("ComputeAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_name_16 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CAN_AR_VERSION", (String)actualResult_name_16);
            Object actualResult_value_17 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CAN_AR_431_VERSION", (String)actualResult_value_17);
        }
    }

    [TestMethod]
    public void ComputeAutosarVersionTest_178_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration93 = BasicConfiguration.Instance;
            String ibasicconfiguration93_AutoSARVersion = "";
            String ibasicconfiguration93_ModuleName = "Can";
            ibasicconfiguration93.AutoSARVersion = ibasicconfiguration93_AutoSARVersion;
            ibasicconfiguration93.ModuleName = ibasicconfiguration93_ModuleName;
            typeof(BaseIntermediate).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration93);
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(BaseIntermediate).GetMethod("ComputeAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual(null, actualResult);
        }
    }
	
	[TestMethod]
    public void ComputeAutosarVersionTest_178_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration94 = BasicConfiguration.Instance;
            String ibasicconfiguration94_AutoSARVersion = "4.8.0";
            String ibasicconfiguration94_ModuleName = "Can";
            ibasicconfiguration94.AutoSARVersion = ibasicconfiguration94_AutoSARVersion;
            ibasicconfiguration94.ModuleName = ibasicconfiguration94_ModuleName;
            typeof(BaseIntermediate).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration94);
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(BaseIntermediate).GetMethod("ComputeAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_name_18 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CAN_AR_VERSION", (String)actualResult_name_18);
            Object actualResult_value_19 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CAN_AR_R22_11_VERSION", (String)actualResult_value_19);
        }
    }
}