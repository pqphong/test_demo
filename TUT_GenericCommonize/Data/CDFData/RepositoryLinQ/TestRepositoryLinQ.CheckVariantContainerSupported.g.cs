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
    public void CheckVariantContainerSupportedTest_171_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;
            String string1059 = "LinChannel";
            String defName = string1059;

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainerByDefNameStringStringInt32String = (RepositoryLinQ instance, String _moduleName, String _containername, Int32 sorttype, String variant) =>
            {
                Container con = new Container();
                con.DefinitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel";
                con.VariantID = "0";
                IList<ItemValue> ILitem = new List<ItemValue>();
                List<VariantItemValue> Lvaritem = new List<VariantItemValue>();
                VariantItemValue var1 = new VariantItemValue("0", 1);
                Lvaritem.Add(var1);
                ItemValue item1 = new ItemValue("defname", "value", Lvaritem);
                ILitem.Add(item1);
                con.ParameterValues = ILitem;
                return con;
            }

            ;

            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("CheckVariantContainerSupported", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName });

            /* Assert */
            Assert.AreEqual((Object)true, (Object)actualResult);
        }
    }

    [TestMethod]
    public void CheckVariantContainerSupportedTest_171_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;
            String string1059 = "LinChannelBaudRate";
            String defName = string1059;

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainerByDefNameStringStringInt32String = (RepositoryLinQ instance, String _moduleName, String _containername, Int32 sorttype, String variant) =>
            {
                Container con = new Container();
                con.DefinitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel";
                return con;
            }

            ;

            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("CheckVariantContainerSupported", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName });

            /* Assert */
            Assert.AreEqual((Object)false, (Object)actualResult);
        }
    }
    
    [TestMethod]
    public void CheckVariantContainerSupportedTest_171_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;
            String string1059 = "LinChannel";
            String defName = string1059;

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainerByDefNameStringStringInt32String = (RepositoryLinQ instance, String _moduleName, String _containername, Int32 sorttype, String variant) =>
            {
                Container con = new Container();
                con.DefinitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel";
                con.VariantID = "0";
                IList<ItemValue> ILitem = new List<ItemValue>();
                List<VariantItemValue> Lvaritem = new List<VariantItemValue>();
                VariantItemValue var1 = new VariantItemValue("0", 1);
                Lvaritem.Add(var1);
                ItemValue item1 = new ItemValue("defname", "value", Lvaritem);
                ILitem.Add(item1);
                con.ReferenceValues = ILitem;
                return con;
            }

            ;

            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("CheckVariantContainerSupported", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName });

            /* Assert */
            Assert.AreEqual((Object)true, (Object)actualResult);
        }
    }
}