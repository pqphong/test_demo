using System;
using System.Reflection;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Renesas.Generator.MCALConfGen.Business.Generation.ItemGenerationAttribute;

namespace Renesas.Generator.MCALConfGen.Business.Generation.Tests
{
    public partial class FileGenerationTest
    {
        [TestMethod]
        public void GenerateFileTest_137_1()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                string output = null;

                Fakes.ShimFileGeneration.AllInstances.WriteToFileString = (gen, buffer) =>
                {
                    output = buffer;
                };

                // Act
                _fileGeneration.GenerateFile();

                // Assert
                string expected = @"__copy_right__

/*******************************************************************************
**                      Revision Control History                              **
*******************************************************************************/

/*******************************************************************************
**                      Generation Tool Version                               **
*******************************************************************************/
__tool_version__

/*******************************************************************************
**                      Input File                                            **
*******************************************************************************/
__input_files__

/*******************************************************************************
**                      Include Section                                       **
*******************************************************************************/

/*******************************************************************************
**                      Version Information                                   **
*******************************************************************************/

/*******************************************************************************
**                      Global Data                                           **
*******************************************************************************/

__global_data_01__


__global_data_02__

/*******************************************************************************
**                      End of File                                           **
*******************************************************************************/

";
                Assert.IsTrue(output.Contains("Include Section"));
                Assert.IsTrue(output.Contains("Version Information"));
                Assert.IsTrue(output.Contains("Global Data"));
                Assert.IsTrue(output.Contains("__global_data_01__"));
                Assert.IsTrue(output.Contains("__global_data_02__"));
                Assert.IsTrue(output.Contains("End of File"));
            }
        }
    }
}