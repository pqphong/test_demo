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
    public void StoreTest_146_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9341 = "/Renesas/fCAN/";
            String path = string9341;
            BaseIntermediateItem baseintermediateitem10342 = new BaseIntermediateItem(null, null);
            String baseintermediateitem10342_Name = "Taget";
            String baseintermediateitem10342_Value = "farthest";
            baseintermediateitem10342.Name = baseintermediateitem10342_Name;
            baseintermediateitem10342.Value = baseintermediateitem10342_Value;
            BaseIntermediateItem target = baseintermediateitem10342;
            List<BaseIntermediateItem> list11343 = new List<BaseIntermediateItem>();
            BaseIntermediateItem list11343_0 = new BaseIntermediateItem(null, null);
            String list11343_0_Name = "Renesas";
            String list11343_0_Value = "";
            List<BaseIntermediateItem> list11343_0_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem list11343_0_Childs_0 = new BaseIntermediateItem(null, null);
            String list11343_0_Childs_0_Name = "fCAN";
            String list11343_0_Childs_0_Value = "80";
            list11343.Add(list11343_0);
            list11343_0.Name = list11343_0_Name;
            list11343_0.Value = list11343_0_Value;
            list11343_0.Childs = list11343_0_Childs;
            list11343_0_Childs.Add(list11343_0_Childs_0);
            list11343_0_Childs_0.Name = list11343_0_Childs_0_Name;
            list11343_0_Childs_0.Value = list11343_0_Childs_0_Value;
            typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list11343);
            /* Act */
            typeof(BaseIntermediateItem).GetMethod("Store", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{path, target});
            /* Assert */
            Object childs1598 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Object childs1598_count_1599 = typeof(List<BaseIntermediateItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598);
            Assert.AreEqual((Int32)1, (Int32)childs1598_count_1599);
            Object childs1598_0_1600 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1600_name_2601 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1600);
            Assert.AreEqual((String)"Renesas", (String)childs1598_0_1600_name_2601);
            Object childs1598_0_1602 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1602_value_2603 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1602);
            Assert.AreEqual((String)"", (String)childs1598_0_1602_value_2603);
            Object childs1598_0_1604 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1604_childs_2605 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1604);
            Object childs1598_0_1604_childs_2605_count_3606 = typeof(List<BaseIntermediateItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1604_childs_2605);
            Assert.AreEqual((Int32)1, (Int32)childs1598_0_1604_childs_2605_count_3606);
            Object childs1598_0_1607 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1607_childs_2608 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1607);
            Object childs1598_0_1607_childs_2608_0_3609 = ((List<BaseIntermediateItem>)childs1598_0_1607_childs_2608)[0];
            Object childs1598_0_1607_childs_2608_0_3609_name_4610 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1607_childs_2608_0_3609);
            Assert.AreEqual((String)"fCAN", (String)childs1598_0_1607_childs_2608_0_3609_name_4610);
            Object childs1598_0_1611 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1611_childs_2612 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1611);
            Object childs1598_0_1611_childs_2612_0_3613 = ((List<BaseIntermediateItem>)childs1598_0_1611_childs_2612)[0];
            Object childs1598_0_1611_childs_2612_0_3613_value_4614 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1611_childs_2612_0_3613);
            Assert.AreEqual((String)"80", (String)childs1598_0_1611_childs_2612_0_3613_value_4614);
            Object childs1598_0_1615 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1615_childs_2616 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1615);
            Object childs1598_0_1615_childs_2616_0_3617 = ((List<BaseIntermediateItem>)childs1598_0_1615_childs_2616)[0];
            Object childs1598_0_1615_childs_2616_0_3617_childs_4618 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1615_childs_2616_0_3617);
            Object childs1598_0_1615_childs_2616_0_3617_childs_4618_count_5619 = typeof(List<BaseIntermediateItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1615_childs_2616_0_3617_childs_4618);
            Assert.AreEqual((Int32)1, (Int32)childs1598_0_1615_childs_2616_0_3617_childs_4618_count_5619);
            Object childs1598_0_1620 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1620_childs_2621 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1620);
            Object childs1598_0_1620_childs_2621_0_3622 = ((List<BaseIntermediateItem>)childs1598_0_1620_childs_2621)[0];
            Object childs1598_0_1620_childs_2621_0_3622_childs_4623 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1620_childs_2621_0_3622);
            Object childs1598_0_1620_childs_2621_0_3622_childs_4623_0_5624 = ((List<BaseIntermediateItem>)childs1598_0_1620_childs_2621_0_3622_childs_4623)[0];
            Object childs1598_0_1620_childs_2621_0_3622_childs_4623_0_5624_name_6625 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1620_childs_2621_0_3622_childs_4623_0_5624);
            Assert.AreEqual((String)"Taget", (String)childs1598_0_1620_childs_2621_0_3622_childs_4623_0_5624_name_6625);
            Object childs1598_0_1626 = ((List<BaseIntermediateItem>)childs1598)[0];
            Object childs1598_0_1626_childs_2627 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1626);
            Object childs1598_0_1626_childs_2627_0_3628 = ((List<BaseIntermediateItem>)childs1598_0_1626_childs_2627)[0];
            Object childs1598_0_1626_childs_2627_0_3628_childs_4629 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1626_childs_2627_0_3628);
            Object childs1598_0_1626_childs_2627_0_3628_childs_4629_0_5630 = ((List<BaseIntermediateItem>)childs1598_0_1626_childs_2627_0_3628_childs_4629)[0];
            Object childs1598_0_1626_childs_2627_0_3628_childs_4629_0_5630_value_6631 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1598_0_1626_childs_2627_0_3628_childs_4629_0_5630);
            Assert.AreEqual((String)"farthest", (String)childs1598_0_1626_childs_2627_0_3628_childs_4629_0_5630_value_6631);
        }
    }

    [TestMethod]
    public void StoreTest_146_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9344 = "/Renesas/fCAN/";
            String path = string9344;
            BaseIntermediateItem baseintermediateitem10345 = new BaseIntermediateItem(null, null);
            String baseintermediateitem10345_Name = "Taget";
            String baseintermediateitem10345_Value = "farthest";
            baseintermediateitem10345.Name = baseintermediateitem10345_Name;
            baseintermediateitem10345.Value = baseintermediateitem10345_Value;
            BaseIntermediateItem target = baseintermediateitem10345;
            List<BaseIntermediateItem> list11346 = new List<BaseIntermediateItem>();
            typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list11346);
            /* Act */
            typeof(BaseIntermediateItem).GetMethod("Store", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{path, target});
            /* Assert */
            Object childs1632 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Object childs1632_count_1633 = typeof(List<BaseIntermediateItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1632);
            Assert.AreEqual((Int32)1, (Int32)childs1632_count_1633);
            Object childs1632_0_1634 = ((List<BaseIntermediateItem>)childs1632)[0];
            Object childs1632_0_1634_name_2635 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1632_0_1634);
            Assert.AreEqual((String)"Taget", (String)childs1632_0_1634_name_2635);
            Object childs1632_0_1636 = ((List<BaseIntermediateItem>)childs1632)[0];
            Object childs1632_0_1636_value_2637 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1632_0_1636);
            Assert.AreEqual((String)"farthest", (String)childs1632_0_1636_value_2637);
        }
    }

    [TestMethod]
    public void StoreTest_146_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9347 = "/Renesas/fCAN/";
            String path = string9347;
            BaseIntermediateItem baseintermediateitem10348 = null;
            BaseIntermediateItem target = baseintermediateitem10348;
            List<BaseIntermediateItem> list11349 = new List<BaseIntermediateItem>();
            typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list11349);
            /* Act */
            typeof(BaseIntermediateItem).GetMethod("Store", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{path, target});
            /* Assert */
            Object childs1638 = typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Object childs1638_count_1639 = typeof(List<BaseIntermediateItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(childs1638);
            Assert.AreEqual((Int32)0, (Int32)childs1638_count_1639);
        }
    }
}