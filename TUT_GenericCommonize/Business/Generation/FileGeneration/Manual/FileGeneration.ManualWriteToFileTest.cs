using System;
using System.Reflection;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using static Renesas.Generator.MCALConfGen.Business.Generation.ItemGenerationAttribute;

namespace Renesas.Generator.MCALConfGen.Business.Generation.Tests
{
    public partial class FileGenerationTest
    {
        [TestMethod]
        public void WriteToFileTest_139_1()
        {
            // Arrange
            string buffer = "text";

            RuntimeConfiguration.Instance.DryRun = true;

            // Act
            _fileGeneration.WriteToFile(buffer);

            // Assert

        }

        [TestMethod]
        public void WriteToFileTest_139_2()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                bool error = false;
                string buffer = "text";
                string outputDirectory = "\\";
                string fileName = "inc.h";

                RuntimeConfiguration.Instance.DryRun = false;
                _fileGeneration.GetType().GetProperty("OutputDirectory", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_fileGeneration, outputDirectory);
                _fileGeneration.GetType().GetProperty("FileName", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_fileGeneration, fileName);

                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.DirectoryExistsStringNullableOfInt32 = (d, e) =>
                {
                    return false;
                };
                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.CreateDirectoryStringNullableOfInt32 = (p, e) =>
                {
                };
                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.StreamWriteStreamWriterStringStringNullableOfInt32 = (s, c, p, e) =>
                {
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.OpenFileString = (instance, path) =>
                {
                    throw new Exception();
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, moduleId, errorCode, message, parameters) =>
                {
                    error = true;
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (instance) =>
                {

                };
                
                // Act
                _fileGeneration.WriteToFile(buffer);

                // Assert
                Assert.AreEqual(true, error);
            }
        }

        [TestMethod]
        public void WriteToFileTest_139_3()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                bool error = false;
                string buffer = "text";
                string outputDirectory = "outDir";
                string fileName = "inc.h";

                RuntimeConfiguration.Instance.DryRun = false;
                _fileGeneration.GetType().GetProperty("OutputDirectory", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_fileGeneration, outputDirectory);
                _fileGeneration.GetType().GetProperty("FileName", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_fileGeneration, fileName);

                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.DirectoryExistsStringNullableOfInt32 = (d, e) =>
                {
                    return false;
                };
                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.CreateDirectoryStringNullableOfInt32 = (p, e) =>
                {
                };
                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.StreamWriteStreamWriterStringStringNullableOfInt32 = (s, c, p, e) =>
                {
                };
                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.OpenFileString = (instance,path) =>
                {
                    return null;
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, moduleId, errorCode, message, parameters) =>
                {
                    error = true;
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (instance) =>
                {
                    
                };

                // Act
                _fileGeneration.WriteToFile(buffer);

                // Assert
                Assert.AreEqual(false, error);
            }
        }

        [TestMethod]
        public void WriteToFileTest_139_4()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                bool error = false;
                string buffer = "text";
                string outputDirectory = string.Empty;
                string fileName = "inc.h";

                RuntimeConfiguration.Instance.DryRun = false;
                _fileGeneration.GetType().GetProperty("OutputDirectory", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_fileGeneration, outputDirectory);
                _fileGeneration.GetType().GetProperty("FileName", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_fileGeneration, fileName);

                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.DirectoryExistsStringNullableOfInt32 = (d, e) =>
                {
                    return false;
                };
                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.CreateDirectoryStringNullableOfInt32 = (p, e) =>
                {
                };
                CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.StreamWriteStreamWriterStringStringNullableOfInt32 = (s, c, p, e) =>
                {
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.OpenFileString = (instance, path) =>
                {
                    throw new Exception();
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (instance, moduleId, errorCode, message, parameters) =>
                {
                    error = true;
                };

                CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (instance) =>
                {

                };

                // Act
                _fileGeneration.WriteToFile(buffer);

                // Assert
                Assert.AreEqual(true, error);
            }
        }
    }
}