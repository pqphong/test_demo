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
    public void CheckRequiredFieldsOfSubstructsTest_123_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "GaaCanStruct";
            String structName = string91;
            List<String> list102 = new List<String>();
            String list102_0 = "CanController";
            String list102_1 = "CanGeneral";
            list102.Add(list102_0);
            list102.Add(list102_1);
            List<String> requiredFields = list102;
            
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckRequiredFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(List<String>)}, null).Invoke(_target, new object[]{structName, requiredFields});
            /* Assert */
            
            Assert.AreEqual(0, actualResult.Count);
        }
    }
}