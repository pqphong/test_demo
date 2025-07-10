using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void GetStartOfDbTocTest_3_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetVersionInformationStringString = (RepositoryLinQ instance, String name, String moduleName) =>
            {
                if (name.Equals("SW-VERSION"))
                    return "1.4.3";
                if (name.Equals("MODULE-ID"))
                    return "84";
                if (name.Equals("VENDOR-ID"))
                    return "59";
                else
                    return "";
                ;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetStartOfDbToc", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"0ED50120", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetStartOfDbTocTest_3_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetVersionInformationStringString = (RepositoryLinQ instance, String name, String moduleName) =>
            {
                if (name.Equals("SW-VERSION"))
                    return "";
                if (name.Equals("MODULE-ID"))
                    return "";
                if (name.Equals("VENDOR-ID"))
                    return "";
                else
                    return "";
                ;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetStartOfDbToc", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetStartOfDbTocTest_3_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetVersionInformationStringString = (RepositoryLinQ instance, String name, String moduleName) =>
            {
                if (name.Equals("SW-VERSION"))
                    return "A.B.C";
                if (name.Equals("MODULE-ID"))
                    return "84";
                if (name.Equals("VENDOR-ID"))
                    return "59";
                else
                    return "";
                ;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetStartOfDbToc", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}