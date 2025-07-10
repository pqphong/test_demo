using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class BaseIntermediateTest
{
    [TestMethod]
    public void ComputeAllTest_176_1()
    {
        // Arrange
        // Act
        _intermediate.ComputeAll();

        // Assert
        var interData = (IIntermediateData)_intermediate.GetType()
            .GetField("Interdata", BindingFlags.NonPublic | BindingFlags.Instance)
            .GetValue(_intermediate);
        Assert.AreEqual("TValue1", interData.GetStringDataByPath("/Top/"));
        Assert.AreEqual("TValue2", interData.GetStringDataByPath("/Topx/"));
        Assert.AreEqual("MValue", interData.GetStringDataByPath("/Top/Middle/"));
        Assert.AreEqual("BValue", interData.GetStringDataByPath("/Top/Middle/Bottom/"));
    }
}

