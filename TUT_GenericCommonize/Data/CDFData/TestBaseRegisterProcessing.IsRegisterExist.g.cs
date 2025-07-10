using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestBaseRegisterProcessing
{
    [TestMethod]
    public void IsRegisterExistTest_59_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9275 = "RENESAS_P0";
            String macroDefinition = string9275;
            IDictionary<String, String> idictionary10276 = new Dictionary<String, String>();
            String idictionary10276_RENESASP0 = "PORT0P00";
            idictionary10276["RENESAS_P0"] = idictionary10276_RENESASP0;
            typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary10276);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseRegisterProcessing).GetMethod("IsRegisterExist", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroDefinition});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsRegisterExistTest_59_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9277 = "RENESAS_P0";
            String macroDefinition = string9277;
            IDictionary<String, String> idictionary10278 = new Dictionary<String, String>();
            String idictionary10278_RENESASPSR0 = "PORT0PSR00";
            idictionary10278["RENESAS_PSR0"] = idictionary10278_RENESASPSR0;
            typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary10278);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseRegisterProcessing).GetMethod("IsRegisterExist", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroDefinition});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}