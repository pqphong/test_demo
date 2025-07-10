using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestParserXML
{
    [TestMethod]
    public void UpdateBasicConfigurationIfNeededTest_19_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string91);
            var cdfdata15 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata15.GetAllInstanceContainersString = (String moduleName) =>
            {
                IList<Container> ilist102 = new List<Container>();
                Container ilist102_0 = new Container();
                String ilist102_0_DefinitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGeneral";
                String ilist102_0_Path = "/ActiveEcuC/Lin/LinGeneral";
                String ilist102_0_ShortName = "LinGeneral";
                IList<ItemValue> ilist102_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist102_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist102_0_ParameterValues_0_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinDeviceName";
                Object ilist102_0_ParameterValues_0_value = "R7F701401";
                ilist102.Add(ilist102_0);
                ilist102_0.DefinitionRef = ilist102_0_DefinitionRef;
                ilist102_0.Path = ilist102_0_Path;
                ilist102_0.ShortName = ilist102_0_ShortName;
                ilist102_0.ParameterValues = ilist102_0_ParameterValues;
                ilist102_0_ParameterValues.Add(ilist102_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0_ParameterValues_0, ilist102_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0_ParameterValues_0, ilist102_0_ParameterValues_0_value);
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                result.Add("lin", ilist102);
                return result;
            }

            ;
            cdfdata15.GetBswConfigurations = () =>
            {
                List<BswConfig> ret = new List<BswConfig>();
                BswConfig list113_0 = new BswConfig();
                String list113_0_ArReleaseVersion = "4.2.2";
                String list113_0_BehaviorRef = "/Renesas/EcucDefs_Lin/LinInternalBehavior/BswInternalBehavior_0";
                String list113_0_DescriptionShortName = "LinInternalBehavior";
                String list113_0_DescriptionUuid = "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0";
                String list113_0_ImplementSortName = "Lin_Impl";
                String list113_0_ImplementUuid = "9133af99-1416-47ea-9108-12d051ca25a0";
                String list113_0_ModuleId = "82";
                String list113_0_ProgrammingLanguage = "C";
                String list113_0_SwVersion = "1.2.10";
                String list113_0_VendorApiInfix = null;
                String list113_0_VendorId = "59";
                String list113_0_VendorSpecificModuleDefRef = "/Renesas/EcucDefs_Lin/Lin";
                list113_0.ArReleaseVersion = list113_0_ArReleaseVersion;
                list113_0.BehaviorRef = list113_0_BehaviorRef;
                list113_0.DescriptionShortName = list113_0_DescriptionShortName;
                list113_0.DescriptionUuid = list113_0_DescriptionUuid;
                list113_0.ImplementSortName = list113_0_ImplementSortName;
                list113_0.ImplementUuid = list113_0_ImplementUuid;
                list113_0.ModuleId = list113_0_ModuleId;
                list113_0.ProgrammingLanguage = list113_0_ProgrammingLanguage;
                list113_0.SwVersion = list113_0_SwVersion;
                list113_0.VendorApiInfix = list113_0_VendorApiInfix;
                list113_0.VendorId = list113_0_VendorId;
                list113_0.VendorSpecificModuleDefRef = list113_0_VendorSpecificModuleDefRef;

                ret.Add(list113_0);
                return ret;
            }

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (instance) =>
            {

                return "R7F702002AEABA";
            };

            ObjectFactory.SupportedVariants.Add("E2x", new List<string>(){ "R7F702002AEABA" });

            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata15);
            /* Act */
            typeof(ParserXML).GetMethod("UpdateBasicConfigurationIfNeeded", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            IBasicConfiguration basic = (IBasicConfiguration)typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            /* Assert */
            Assert.AreEqual(basic.DeviceVariant, "E2x");
            ObjectFactory.SupportedVariants = new Dictionary<string, List<string>>();


        }
    }

    [TestMethod]
    public void UpdateBasicConfigurationIfNeededTest_19_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string91);
            var cdfdata15 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata15.GetAllInstanceContainersString = (String moduleName) =>
            {
                IList<Container> ilist102 = new List<Container>();
                Container ilist102_0 = new Container();
                String ilist102_0_DefinitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGeneral";
                String ilist102_0_Path = "/ActiveEcuC/Lin/LinGeneral";
                String ilist102_0_ShortName = "LinGeneral";
                IList<ItemValue> ilist102_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist102_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist102_0_ParameterValues_0_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinDeviceName";
                Object ilist102_0_ParameterValues_0_value = "";
                ilist102.Add(ilist102_0);
                ilist102_0.DefinitionRef = ilist102_0_DefinitionRef;
                ilist102_0.Path = ilist102_0_Path;
                ilist102_0.ShortName = ilist102_0_ShortName;
                ilist102_0.ParameterValues = ilist102_0_ParameterValues;
                ilist102_0_ParameterValues.Add(ilist102_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0_ParameterValues_0, ilist102_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0_ParameterValues_0, ilist102_0_ParameterValues_0_value);
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                result.Add("lin", ilist102);
                return result;
            }

            ;
            cdfdata15.GetBswConfigurations = () =>
            {
                List<BswConfig> ret = new List<BswConfig>();

                BswConfig list113_0 = new BswConfig();
                String list113_0_ArReleaseVersion = "4.2.2";
                String list113_0_BehaviorRef = "/Renesas/EcucDefs_Lin/LinInternalBehavior/BswInternalBehavior_0";
                String list113_0_DescriptionShortName = "LinInternalBehavior";
                String list113_0_DescriptionUuid = "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0";
                String list113_0_ImplementSortName = "Lin_Impl";
                String list113_0_ImplementUuid = "9133af99-1416-47ea-9108-12d051ca25a0";
                String list113_0_ModuleId = "82";
                String list113_0_ProgrammingLanguage = "C";
                String list113_0_SwVersion = "1.2.10";
                String list113_0_VendorApiInfix = null;
                String list113_0_VendorId = "59";
                String list113_0_VendorSpecificModuleDefRef = "/Renesas/EcucDefs_Lin/Lin";
                list113_0.ArReleaseVersion = list113_0_ArReleaseVersion;
                list113_0.BehaviorRef = list113_0_BehaviorRef;
                list113_0.DescriptionShortName = list113_0_DescriptionShortName;
                list113_0.DescriptionUuid = list113_0_DescriptionUuid;
                list113_0.ImplementSortName = list113_0_ImplementSortName;
                list113_0.ImplementUuid = list113_0_ImplementUuid;
                list113_0.ModuleId = list113_0_ModuleId;
                list113_0.ProgrammingLanguage = list113_0_ProgrammingLanguage;
                list113_0.SwVersion = list113_0_SwVersion;
                list113_0.VendorApiInfix = list113_0_VendorApiInfix;
                list113_0.VendorId = list113_0_VendorId;
                list113_0.VendorSpecificModuleDefRef = list113_0_VendorSpecificModuleDefRef;

                ret.Add(list113_0);
                return ret;
            }

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (instance) =>
            {

                return "R7F702002XXXX";
            };
            ObjectFactory.SupportedVariants.Add("E2x", new List<string>() { "R7F702002AEABA" });
            IBasicConfiguration basic = (IBasicConfiguration)typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            // Init default value to avoid updating of other test cases.
            basic.DeviceVariant = "";
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata15);
            /* Act */
            typeof(ParserXML).GetMethod("UpdateBasicConfigurationIfNeeded", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            
            /* Assert */
            Assert.AreEqual(basic.DeviceVariant, "");
            ObjectFactory.SupportedVariants = new Dictionary<string, List<string>>();
        }
    }

    

}