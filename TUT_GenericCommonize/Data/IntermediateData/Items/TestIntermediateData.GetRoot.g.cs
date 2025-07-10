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
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;

public partial class TestIntermediateData
{
    [TestMethod]
    public void GetRootTest_154_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(IntermediateData).GetMethod("GetRoot", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_name_1650 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"root", (String)actualResult_name_1650);
            Object actualResult_value_1651 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"", (String)actualResult_value_1651);
        }
    }
}