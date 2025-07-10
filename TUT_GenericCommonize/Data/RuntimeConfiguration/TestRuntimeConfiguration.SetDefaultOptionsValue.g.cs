using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestRuntimeConfiguration
{
    [TestMethod]
    public void SetDefaultOptionsValueTest_129_1()
    {
        // Arrange
        var basicConfig = BasicConfiguration.Instance;

        _target.FolderOutput = "";
        _target.IncOutputDirectory = "";
        _target.SrcOutputDirectory = "";
        _target.TranslationFilePath = "";

        // Act
        _target.SetDefaultOptionsValue(basicConfig);

        // Assert
        Assert.AreEqual(@"\include\", _target.IncOutputDirectory);
        Assert.AreEqual(@"\src\", _target.SrcOutputDirectory);
        Assert.IsTrue(_target.TranslationFilePath.EndsWith(".trxml"));
    }

    [TestMethod]
    public void SetDefaultOptionsValueTest_129_2()
    {
        // Arrange
        var basicConfig = BasicConfiguration.Instance;

        _target.FolderOutput = "FolderOutput";
        _target.IncOutputDirectory = null;
        _target.SrcOutputDirectory = null;
        _target.TranslationFilePath = null;

        // Act
        _target.SetDefaultOptionsValue(basicConfig);

        // Assert
        Assert.AreEqual(@"FolderOutput\include\", _target.IncOutputDirectory);
        Assert.AreEqual(@"FolderOutput\src\", _target.SrcOutputDirectory);
        Assert.IsTrue(_target.TranslationFilePath.EndsWith(".trxml"));
    }

    [TestMethod]
    public void SetDefaultOptionsValueTest_129_3()
    {
        // Arrange
        var basicConfig = BasicConfiguration.Instance;

        _target.FolderOutput = "FolderOutput";
        _target.IncOutputDirectory = "incDir";
        _target.SrcOutputDirectory = "srcDir";
        _target.TranslationFilePath = "txPath.trxml";

        // Act
        _target.SetDefaultOptionsValue(basicConfig);

        // Assert
        Assert.AreEqual(@"incDir\include\", _target.IncOutputDirectory);
        Assert.AreEqual(@"srcDir\src\", _target.SrcOutputDirectory);
        Assert.AreEqual(@"txPath.trxml", _target.TranslationFilePath);
    }
}
