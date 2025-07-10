using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;

public partial class TestBaseValidation
{
    [TestMethod]
    public void GetAllStructureDataTest_124_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            Dictionary<String, List<String>> actualResult = (Dictionary<String, List<String>>)typeof(BaseValidation).GetMethod("GetAllStructureData", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Dictionary<String, List<String>>)null, (Dictionary<String, List<String>>)actualResult);
        }
    }
}