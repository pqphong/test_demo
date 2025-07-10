using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUT_GenericX2x.Business.Generation
{
    [TestClass]
    public partial class GenerationTest
    {
        private FileGeneration _fileGeneration;
        [TestInitialize]
        public void Setup()
        {
            _fileGeneration = new TestClassFileGeneration(
                "test.h",
                "test",
                ObjectFactory.GetInstance<ILogger>(),
                BasicConfiguration.Instance,
                RuntimeConfiguration.Instance,
                null);
        }

        [TestCleanup]
        public void TearDown()
        {
        }
    }
    public class TestClassFileGeneration : FileGeneration
    {
        public TestClassFileGeneration
        (
            string fileName,
            string outputDirectory,
            ILogger logger,
            IBasicConfiguration basicConfiguration,
            IRuntimeConfiguration runtimeConfiguration,
            IIntermediateData intermediateData
        ) : base(fileName, outputDirectory, logger, basicConfiguration, runtimeConfiguration, intermediateData)
        {
        }
    }
    }
