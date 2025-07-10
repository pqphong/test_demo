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
    public void CheckSameFieldsOfSubstructsTest_117_1()
    {
        using (ShimsContext.Create())
        {
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.CheckSameFieldsOfSubstructsStringString = (ins, str1, str2) =>
            {

                return new List<string>();
            };
            /* Arrange */
            String string91 = "";
            String structName = string91;

            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckSameFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { null });
            /* Assert */
            Assert.AreEqual(0, actualResult.Count);
        }
    }
}