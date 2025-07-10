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

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void PrepareInstanceTest_52_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int329178 = 1;
            Int32 instanceIndex = int329178;
            /* Act */
            _target.GetType().GetMethod("PrepareInstance", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{instanceIndex});
            /* Assert */
            Object currentinstanceindex1517 = _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Assert.AreEqual((Int32)1, (Int32)currentinstanceindex1517);
        }
    }
}