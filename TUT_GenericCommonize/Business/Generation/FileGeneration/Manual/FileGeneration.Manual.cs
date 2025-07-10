using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

namespace Renesas.Generator.MCALConfGen.Business.Generation.Tests
{
    [TestClass]
    public partial class FileGenerationTest
    {
        private FileGeneration _fileGeneration;

        [TestInitialize]
        public void Setup()
        {
            _fileGeneration = new TestClassFileGeneration(
                "can.h",
                "test",
                DebugLogger.Instance,
         BasicConfiguration.Instance,
         RuntimeConfiguration.Instance,
         IntermediateData.Instance);
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
        ) : base(fileName, outputDirectory, logger,  basicConfiguration, runtimeConfiguration, intermediateData)
        {
            Description = "Description";
        }

        public void NoHaveItemGenerationAttribute() { }

        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.COPY_RIGHT, SectionOrder = 6)]
        public void HaveItemGenerationAttribute() { }

        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.COPY_RIGHT)]
        protected override BaseGenerationItem[] GenCOPYRIGHTSection()
        {
            return new BaseGenerationItem[] { new StringGenerationItem("__copy_right__") };
        }

        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GENTOOL_VERSION)]
        protected override BaseGenerationItem Gen_GentoolVersion()
        {
            return null;
        }

        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.INPUT_FILES)]
        protected override BaseGenerationItem Gen_InputFiles()
        {
            return new StringGenerationItem("__input_files__");
        }

        [NewLine(2)]
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GLOBAL_DATA, SectionOrder = 2)]
        protected virtual BaseGenerationItem GlobalData_02()
        {
            return new StringGenerationItem("__global_data_02__");
        }

        [NewLine]
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GLOBAL_DATA, SectionOrder = 1)]
        protected virtual BaseGenerationItem GlobalData_01()
        {
            return new StringGenerationItem("__global_data_01__");
        }

        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GLOBAL_DATA, SectionOrder = 1)]
        protected virtual StringGenerationItem GlobalData_New()
        {
            return new StringGenerationItem("new");
        }
    }
}