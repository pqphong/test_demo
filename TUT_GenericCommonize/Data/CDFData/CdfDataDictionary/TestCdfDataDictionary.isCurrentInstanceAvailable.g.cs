using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void isCurrentInstanceAvailableTest_50_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int3291);
            /* Act */
            Boolean actualResult = (Boolean)_target.GetType().GetMethod("isCurrentInstanceAvailable", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isCurrentInstanceAvailableTest_50_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3292 = -1;
            _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int3292);
            /* Act */
            Boolean actualResult = (Boolean)_target.GetType().GetMethod("isCurrentInstanceAvailable", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}