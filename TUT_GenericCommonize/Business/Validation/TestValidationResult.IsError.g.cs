using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using static Renesas.Generator.MCALConfGen.Business.Validation.ValidationResult;

public partial class TestValidationResult
{
    [TestMethod]
    public void IsErrorTest_133_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            MessageType messagetype91 = MessageType.ERROR;
            typeof(ValidationResult).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, messagetype91);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ValidationResult).GetMethod("IsError", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsErrorTest_133_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            MessageType messagetype92 = MessageType.SUCCESS;
            typeof(ValidationResult).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, messagetype92);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ValidationResult).GetMethod("IsError", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}