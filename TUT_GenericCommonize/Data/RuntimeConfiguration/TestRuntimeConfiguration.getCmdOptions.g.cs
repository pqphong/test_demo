using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestRuntimeConfiguration
{
    
    [TestMethod]
    public void getCmdOptionsTest_128_1()
    {
        // Arrange
        Predicate<PropertyInfo> condition = (info) =>
        {
            return true;
        };

        // Act
        var options = invokeGetCmdOptions(condition);

        // Assert
        Assert.AreEqual(18, options.Count);
    }

    [TestMethod]
    public void getCmdOptionsTest_128_2()
    {
        using (ShimsContext.Create())
        {
            Predicate<PropertyInfo> condition = (info) =>
            {
                return typeof(bool) == info.PropertyType;
            };

            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimOptionAttribute.AllInstances.GetOption = (instance) =>
            {

                return "";

            };

            // Act
            var options = invokeGetCmdOptions(condition);

            // Assert
            Assert.AreEqual(0, options.Count);

        }

    }

    private List<string> invokeGetCmdOptions(Predicate<PropertyInfo> condition)
    {
        return (List<string>)_target.GetType()
            .GetMethod("getCmdOptions", BindingFlags.NonPublic | BindingFlags.Instance)
            .Invoke(_target, new object[] { condition });
    }
}
