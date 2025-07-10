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

public partial class TestBaseIntermediateItem
{
    [TestMethod]
    public void ToStringTest_150_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<BaseIntermediateItem> list9354 = new List<BaseIntermediateItem>();
            BaseIntermediateItem list9354_0 = new BaseIntermediateItem(null, null);
            BaseIntermediateItem list9354_2 = new BaseIntermediateItem(null, null);
            list9354.Add(list9354_0);
            list9354.Add(list9354_2);
            typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list9354);
            /* Act */
            String actualResult = (String)typeof(BaseIntermediateItem).GetMethod("ToString", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
        /* Assert */
        }
    }
}