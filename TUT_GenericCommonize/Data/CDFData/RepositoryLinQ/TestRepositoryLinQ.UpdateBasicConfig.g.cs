using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void UpdateBasicConfigTest_164_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata13 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata13.GetCurrentInstanceConfigurationString = (String moduleName) =>
            {
                Configuration configuration91 = new Configuration();
                String configuration91_ModuleDescriptionRef = "/Renesas/BswModuleDescriptions_Icu/Icu_Impl";
                configuration91.ModuleDescriptionRef = configuration91_ModuleDescriptionRef;
                return configuration91;
            }

            ;
            cdfdata13.GetBswConfigurations = () =>
            {
                IList<BswConfig> ilist102 = new List<BswConfig>();
                BswConfig ilist102_0 = new BswConfig();
                String ilist102_0_VendorId = "59";
                String ilist102_0_VendorApiInfix = "Inst0";
                ilist102.Add(ilist102_0);
                ilist102_0.VendorId = ilist102_0_VendorId;
                ilist102_0.VendorApiInfix = ilist102_0_VendorApiInfix;
                ilist102_0.ImplementRootPath = "/Renesas/BswModuleDescriptions_Icu/Icu_Impl";
                return ilist102;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata13);
            /* Act */
            typeof(RepositoryLinQ).GetMethod("UpdateBasicConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            IBasicConfiguration basicConfig = ObjectFactory.GetInstance<IBasicConfiguration>();
            Assert.AreEqual(basicConfig.VendorId.ToString(), "59");
            Assert.AreEqual(basicConfig.VendorApiInfix, "Inst0");
        }
    }
}