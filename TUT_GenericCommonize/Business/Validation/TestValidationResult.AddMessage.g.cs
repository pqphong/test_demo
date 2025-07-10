using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;

public partial class TestValidationResult
{
    [TestMethod]
    public void AddMessageTest_134_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "this is {0}";
            String msgFormat = string91;
            Object[] object102 = new Object[1];
            Object object102_0 = "message";
            object102[0] = object102_0;
            Object[] param = object102;
            /* Act */
            typeof(ValidationResult).GetMethod("AddMessage", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Object[])}, null).Invoke(_target, new object[]{msgFormat, param});
            /* Assert */
            Object message13 = typeof(ValidationResult).GetProperty("Message", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Object message13_0_14 = ((List<String>)message13)[0];
            Assert.AreEqual((String)"this is message", (String)message13_0_14);
        }
    }
}