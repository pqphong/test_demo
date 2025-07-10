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
    public void AddChildTest_152_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem9359 = new BaseIntermediateItem(null, null);
            String baseintermediateitem9359_Name = "child1";
            String baseintermediateitem9359_Value = "value_child1";
            baseintermediateitem9359.Name = baseintermediateitem9359_Name;
            baseintermediateitem9359.Value = baseintermediateitem9359_Value;
            BaseIntermediateItem child = baseintermediateitem9359;
            /* Act */
            typeof(BaseIntermediateItem).GetMethod("AddChild", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{child});
            /* Assert */
            Object childs1642 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Object childs1642_count_1643 = typeof(List<BaseIntermediateItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1642);
            Assert.AreEqual((Int32)1, (Int32)childs1642_count_1643);
            Object childs1642_0_1644 = ((List<BaseIntermediateItem>)childs1642)[0];
            Object childs1642_0_1644_name_2645 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1642_0_1644);
            Assert.AreEqual((String)"child1", (String)childs1642_0_1644_name_2645);
            Object childs1642_0_1646 = ((List<BaseIntermediateItem>)childs1642)[0];
            Object childs1642_0_1646_value_2647 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1642_0_1646);
            Assert.AreEqual((String)"value_child1", (String)childs1642_0_1646_value_2647);
        }
    }
}