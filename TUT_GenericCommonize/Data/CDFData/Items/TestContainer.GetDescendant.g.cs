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

public partial class TestContainer
{
    [TestMethod]
    public void GetDescendantTest_109_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<Container> list9283 = new List<Container>();
            Container list9283_0 = new Container();
            String list9283_0_ShortName = "Child1";
            list9283.Add(list9283_0);
            list9283_0.ShortName = list9283_0_ShortName;
            typeof(Container).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list9283);
            String string10284 = "Root";
            typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string10284);
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(Container).GetMethod("GetDescendant", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_count_1550 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_1550);
            Object actualResult_0_1551 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_1551_shortname_2552 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_1551);
            Assert.AreEqual((String)"Root", (String)actualResult_0_1551_shortname_2552);
            Object actualResult_0_1553 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_1553_childs_2554 = typeof(Container).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_1553);
            Object actualResult_0_1553_childs_2554_count_3555 = typeof(List<Container>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_1553_childs_2554);
            Assert.AreEqual((Int32)1, (Int32)actualResult_0_1553_childs_2554_count_3555);
            Object actualResult_0_1556 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_1556_childs_2557 = typeof(Container).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_1556);
            Object actualResult_0_1556_childs_2557_0_3558 = ((List<Container>)actualResult_0_1556_childs_2557)[0];
            Object actualResult_0_1556_childs_2557_0_3558_shortname_4559 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_1556_childs_2557_0_3558);
            Assert.AreEqual((String)"Child1", (String)actualResult_0_1556_childs_2557_0_3558_shortname_4559);
            Object actualResult_1_1560 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_1560_shortname_2561 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_1560);
            Assert.AreEqual((String)"Child1", (String)actualResult_1_1560_shortname_2561);
            Object actualResult_1_1562 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_1562_childs_2563 = typeof(Container).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_1562);
            Object actualResult_1_1562_childs_2563_count_3564 = typeof(List<Container>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_1562_childs_2563);
            Assert.AreEqual((Int32)0, (Int32)actualResult_1_1562_childs_2563_count_3564);
        }
    }
}