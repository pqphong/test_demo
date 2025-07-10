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
    public void GetReferenceValuesTest_25_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9114 = "DeviceName";
            String paramName = string9114;
            /* Act */
            List<ItemValue> actualResult = (List<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{paramName});
            /* Assert */
            Assert.AreEqual((List<ItemValue>)null, (List<ItemValue>)actualResult);
        }
    }
}