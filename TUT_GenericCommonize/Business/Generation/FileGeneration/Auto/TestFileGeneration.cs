using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

[TestClass]
public partial class TestFileGeneration
{

    private FileGeneration _target = new FileGenerationTest
        ("test","output", DebugLogger.Instance,
         BasicConfiguration.Instance,
         RuntimeConfiguration.Instance,
         IntermediateData.Instance
        );
}

public class FileGenerationTest : FileGeneration
{
    public FileGenerationTest(string fileName, string outputDirectory, ILogger logger, IBasicConfiguration basicConfiguration, 
        IRuntimeConfiguration runtimeConfiguration, IIntermediateData intermediateData) : base(fileName, outputDirectory, logger,basicConfiguration, runtimeConfiguration, intermediateData)
    {
    }

   
}