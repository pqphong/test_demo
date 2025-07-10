using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestSourceFileGeneration
{
    [TestMethod]
    public void GenINSTANCE_INDEXTest_149_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration91 = BasicConfiguration.Instance;
            Boolean ibasicconfiguration91_HasInstanceSetting = false;
            Int32 ibasicconfiguration91_VendorId = 59;
            String ibasicconfiguration91_ModuleName = "Can";
            ibasicconfiguration91.HasInstanceSetting = ibasicconfiguration91_HasInstanceSetting;
            ibasicconfiguration91.VendorId = ibasicconfiguration91_VendorId;
            ibasicconfiguration91.ModuleName = ibasicconfiguration91_ModuleName;
            typeof(SourceFileGeneration).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration91);
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(SourceFileGeneration).GetMethod("GenINSTANCE_INDEX", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((BaseGenerationItem[])null, (BaseGenerationItem[])actualResult);
        }
    }

    [TestMethod]
    public void GenINSTANCE_INDEXTest_149_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration92 = BasicConfiguration.Instance;
            Boolean ibasicconfiguration92_HasInstanceSetting = true;
            Int32 ibasicconfiguration92_VendorId = 0;
            String ibasicconfiguration92_ModuleName = "Can";
            ibasicconfiguration92.HasInstanceSetting = ibasicconfiguration92_HasInstanceSetting;
            ibasicconfiguration92.VendorId = ibasicconfiguration92_VendorId;
            ibasicconfiguration92.ModuleName = ibasicconfiguration92_ModuleName;
            typeof(SourceFileGeneration).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration92);
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(SourceFileGeneration).GetMethod("GenINSTANCE_INDEX", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_0_13 = ((BaseGenerationItem[])actualResult)[0];
            Object actualResult_0_13_name_24 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_13);
            Assert.AreEqual((String)"CAN_INSTANCE_INDEX", (String)actualResult_0_13_name_24);
        }
    }
}