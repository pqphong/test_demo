using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestRuntimeConfiguration
{
    [TestMethod]
    public void GetSingleCmdOptionsTest_132_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.ShimRuntimeConfiguration.AllInstances.getCmdOptionsPredicateOfPropertyInfo = (RuntimeConfiguration instance, Predicate<PropertyInfo> condition) =>
            {
                List<String> list91 = new List<String>();
                String list91_0 = "str1";
                list91.Add(list91_0);
                return list91;
            }

            ;
            /* Act */
            String[] actualResult = (String[])typeof(RuntimeConfiguration).GetMethod("GetSingleCmdOptions", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_0_13 = ((String[])actualResult)[0];
            Assert.AreEqual((String)"str1", (String)actualResult_0_13);
        }
    }

    [TestMethod]
    public void GetSingleCmdOptionsTest_132_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.ShimRuntimeConfiguration.AllInstances.getCmdOptionsPredicateOfPropertyInfo = (RuntimeConfiguration instance, Predicate<PropertyInfo> condition) =>
            {
                List<String> list92 = new List<String>();
                String list92_0 = "str1";
                String list92_1 = "str2";
                list92.Add(list92_0);
                list92.Add(list92_1);
                return list92;
            }

            ;
            /* Act */
            String[] actualResult = (String[])typeof(RuntimeConfiguration).GetMethod("GetSingleCmdOptions", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_0_14 = ((String[])actualResult)[0];
            Assert.AreEqual((String)"str1", (String)actualResult_0_14);
            Object actualResult_1_15 = ((String[])actualResult)[1];
            Assert.AreEqual((String)"str2", (String)actualResult_1_15);
        }
    }
}