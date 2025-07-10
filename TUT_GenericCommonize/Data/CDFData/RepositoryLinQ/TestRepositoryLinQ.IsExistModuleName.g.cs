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
    public void IsExistModuleNameTest_24_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9110 = "Dem";
            String moduleName = string9110;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainersString = (RepositoryLinQ instance, String _moduleName) =>
            {
                IList<Container> ilist10111 = new List<Container>();
                return ilist10111;
            }

            ;
            /* Act */
            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("IsExistModuleName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsExistModuleNameTest_24_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9112 = "Dem";
            String moduleName = string9112;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainersString = (RepositoryLinQ instance, String _moduleName) =>
            {
                IList<Container> ilist10113 = new List<Container>();
                Container ilist10113_0 = new Container();
                Container ilist10113_2 = new Container();
                Container ilist10113_4 = new Container();
                Container ilist10113_6 = new Container();
                Container ilist10113_8 = new Container();
                ilist10113.Add(ilist10113_0);
                ilist10113.Add(ilist10113_2);
                ilist10113.Add(ilist10113_4);
                ilist10113.Add(ilist10113_6);
                ilist10113.Add(ilist10113_8);
                return ilist10113;
            }

            ;
            /* Act */
            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("IsExistModuleName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }
}