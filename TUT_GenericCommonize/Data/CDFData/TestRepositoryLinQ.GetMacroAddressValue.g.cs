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
    public void GetMacroAddressValueTest_30_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9125 = "PORTPCR0_12";
            String macroValue = string9125;
            var register1487 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            register1487.GetMacroAddressValueString = (String _macroValue) =>
            {
                String string10126 = "0xffc12030ul";
                return string10126;
            }

            ;
            typeof(RepositoryLinQ).GetField("register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, register1487);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"0xffc12030ul", (String)actualResult);
        }
    }
}