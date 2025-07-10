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
    public void PrepareInstanceTest_31_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 1;
            Int32 instanceIndex = int3291;
            var cdfdata13 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata13);
            /* Act */
            typeof(RepositoryLinQ).GetMethod("PrepareInstance", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{instanceIndex});
        /* Assert */
        }
    }
}