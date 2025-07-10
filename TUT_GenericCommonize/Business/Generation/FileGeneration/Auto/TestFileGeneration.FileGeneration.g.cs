using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestFileGeneration
{
    class FileGenerationTest : FileGeneration
    {
        public FileGenerationTest(string fileName, string outputDirectory, ILogger logger, IBasicConfiguration basicConfiguration, IRuntimeConfiguration runtimeConfiguration, IIntermediateData intermediateData) : base(fileName, outputDirectory, logger, basicConfiguration, runtimeConfiguration, intermediateData)
        {
        }

        public string GetOutputFolder()
        {
            return OutputDirectory;
        }
    }
    [TestMethod]
    public void FileGenerationTest_138_1()
    {
        using (ShimsContext.Create())
        {
            ILogger logger = ObjectFactory.GetInstance<ILogger>();

            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            basicConfiguration.InstanceOutType = InstanceOutputType.FILES;
            IRuntimeConfiguration runtimeConfiguration = ObjectFactory.GetInstance<IRuntimeConfiguration>();
            IIntermediateData intermediateData = ObjectFactory.GetInstance<IIntermediateData>();

            FileGenerationTest test = new FileGenerationTest("can_cfg.h",
                "U:\\can\\include\\", logger, basicConfiguration, runtimeConfiguration, intermediateData
               );
            string actual = test.GetOutputFolder();
            Assert.AreEqual(@"U:\can\include\",actual);
        }
    }

    [TestMethod]
    public void FileGenerationTest_138_2()
    {
        using (ShimsContext.Create())
        {
            ILogger logger = ObjectFactory.GetInstance<ILogger>();

            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            basicConfiguration.InstanceOutType = InstanceOutputType.FOLDERS;
            basicConfiguration.InstanceIndex = (int)0;
            IRuntimeConfiguration runtimeConfiguration = ObjectFactory.GetInstance<IRuntimeConfiguration>();
            IIntermediateData intermediateData = ObjectFactory.GetInstance<IIntermediateData>();

            FileGenerationTest test = new FileGenerationTest("can_cfg.h",
                "U:\\can\\include\\", logger, basicConfiguration, runtimeConfiguration, intermediateData
               );
            string actual = test.GetOutputFolder();
            Assert.AreEqual(@"U:\can\include\", actual);
        }
    }

    [TestMethod]
    public void FileGenerationTest_138_3()
    {
        using (ShimsContext.Create())
        {
            ILogger logger = ObjectFactory.GetInstance<ILogger>();

            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            IRuntimeConfiguration runtimeConfiguration = ObjectFactory.GetInstance<IRuntimeConfiguration>();
            basicConfiguration.InstanceOutType = InstanceOutputType.DEFAULT;
            IIntermediateData intermediateData = ObjectFactory.GetInstance<IIntermediateData>();

            FileGenerationTest test = new FileGenerationTest("can_cfg.h",
                "U:\\can\\include\\", logger, basicConfiguration, runtimeConfiguration, intermediateData
               );
            string actual = test.GetOutputFolder();
            Assert.AreEqual(@"U:\can\include\", actual);
        }
    }
}