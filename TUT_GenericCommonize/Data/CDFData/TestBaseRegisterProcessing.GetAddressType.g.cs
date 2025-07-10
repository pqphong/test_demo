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
    public void GetAddressTypeTest_60_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9279 = "ICPWGA0";
            String macroValue = string9279;
            IDictionary<String, String> idictionary10280 = new Dictionary<String, String>();
            String idictionary10280_ICPWGA0 = "0xffff1234";
            String idictionary10280_ICPWGA1 = "0xffff1235";
            idictionary10280["ICPWGA0"] = idictionary10280_ICPWGA0;
            idictionary10280["ICPWGA1"] = idictionary10280_ICPWGA1;
            typeof(BaseRegisterProcessing).GetField("macroAddressType", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary10280);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetAddressType", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"0xffff1234", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetAddressTypeTest_60_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9281 = "ICPWGA2";
            String macroValue = string9281;
            IDictionary<String, String> idictionary10282 = new Dictionary<String, String>();
            String idictionary10282_ICPWGA0 = "0xffff1234";
            String idictionary10282_ICPWGA1 = "";
            idictionary10282["ICPWGA0"] = idictionary10282_ICPWGA0;
            idictionary10282["ICPWGA1"] = idictionary10282_ICPWGA1;
            typeof(BaseRegisterProcessing).GetField("macroAddressType", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary10282);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetAddressType", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}