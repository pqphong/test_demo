using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestRuntimeConfiguration
{
    [TestMethod]
    public void OverrideCurrentConfigsByTest_134_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary9333 = new Dictionary<String, String>();
            Dictionary<String, String> options = dictionary9333;
            List<String> list10334 = new List<String>();
            List<String> filePaths = list10334;
            Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.ShimRuntimeConfiguration.AllInstances.overrideOptionsDictionaryOfStringString = (RuntimeConfiguration instance, Dictionary<String, String> _options) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.ShimRuntimeConfiguration.AllInstances.overrideFilesListOfString = (RuntimeConfiguration instance, List<String> _filePaths) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(RuntimeConfiguration).GetMethod("OverrideCurrentConfigsBy", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>), typeof(List<String>)}, null).Invoke(_target, new object[]{options, filePaths});
        /* Assert */
        }
    }
}