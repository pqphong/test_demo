using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

[TestClass]
public partial class TestHeaderFileGeneration
{
    private HeaderFileGeneration _target = new HeaderFileGenerationManual(
        "test.h","U:\\", ObjectFactory.GetInstance<ILogger>(), ObjectFactory.GetInstance<IBasicConfiguration>(),
        ObjectFactory.GetInstance<IRuntimeConfiguration>(),
        ObjectFactory.GetInstance<IIntermediateData>()
        );
}

public class HeaderFileGenerationManual : HeaderFileGeneration
{
    public HeaderFileGenerationManual(string fileName, string outputDirectory,ILogger logger, IBasicConfiguration basicConfiguration, IRuntimeConfiguration runtimeConfiguration, IIntermediateData intermediateData) : 
        base(fileName, outputDirectory, logger, basicConfiguration, runtimeConfiguration, intermediateData)
    {
    }
}