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

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void GetAddressTypeTest_21_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9104 = "ICPWGA0";
            String macroValue = string9104;
            var register1476 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            register1476.GetAddressTypeString = (String _macroValue) =>
            {
                String string10105 = "0xffff1234ul";
                return string10105;
            }

            ;
            typeof(RepositoryLinQ).GetField("register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, register1476);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetAddressType", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"0xffff1234ul", (String)actualResult);
        }
    }
}