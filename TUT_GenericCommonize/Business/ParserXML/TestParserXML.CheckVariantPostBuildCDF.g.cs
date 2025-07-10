using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using System.Xml.Linq;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestParserXML
{
    [TestMethod]
    public void CheckVariantPostBuildCDFTest_198_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */

            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "Lin";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
			
			cdfdata16.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ILconfig = new List<Configuration>();
				Configuration config = new Configuration();
				config.postBuildVariantSupport = "true";
                config.ShortName = moduleName;
                ILconfig.Add(config);
                return ILconfig;
            };

            

            cdfdata16.GetAllInstanceContainersString = (String moduleName) =>
            {
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                IList<Container> ILcontainer = new List<Container>();
                Container container = new Container();
                IList<ItemValue> parameterValues = new List<ItemValue>();

                string defref1 = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";

                List<VariantItemValue> Lvariantitem = new List<VariantItemValue>();
                VariantItemValue variantitem1 = new VariantItemValue("0", 9600);
                VariantItemValue variantitem2 = new VariantItemValue("1", 12000);
                Lvariantitem.Add(variantitem1);
                Lvariantitem.Add(variantitem2);

                ItemValue itemval1 = new ItemValue(defref1, null, Lvariantitem);
                parameterValues.Add(itemval1);
                container.ParameterValues = parameterValues;

                List<string> listvariant = new List<string> { "0", "1" };
                container.ListConfiguredVariantID = listvariant;

                container.VariantID = "0";

                ILcontainer.Add(container);
                result.Add(moduleName, ILcontainer);

                return result;
            };

            cdfdata16.GetVariantCriterionSet = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetVariantCriterionModuleConfig = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");
                variantset.Add("1", "Variant2");

                return variantset;
            };

            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            };

            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);

            /* Act */
            typeof(ParserXML).GetMethod("CheckVariantPostBuildCDF", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] {}, null).Invoke(_target, new object[] {});
            /* Assert */
            Assert.AreEqual((Int32)58, (Int32)flag);
        }
    }

    [TestMethod]
    public void CheckVariantPostBuildCDFTest_198_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */

            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "Lin";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
			
			cdfdata16.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ILconfig = new List<Configuration>();
				Configuration config = new Configuration();
				config.postBuildVariantSupport = "true";
                config.ShortName = moduleName;
                ILconfig.Add(config);
                return ILconfig;
            };
			
            cdfdata16.GetAllInstanceContainersString = (String moduleName) =>
            {
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                IList<Container> ILcontainer = new List<Container>();
                Container container = new Container();
                IList<ItemValue> parameterValues = new List<ItemValue>();

                string defref1 = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";

                List<VariantItemValue> Lvariantitem = new List<VariantItemValue>();
                VariantItemValue variantitem1 = new VariantItemValue("0", 9600);
                VariantItemValue variantitem2 = new VariantItemValue("1", 12000);
                Lvariantitem.Add(variantitem1);
                Lvariantitem.Add(variantitem2);

                ItemValue itemval1 = new ItemValue(defref1, null, Lvariantitem);
                parameterValues.Add(itemval1);
                container.ParameterValues = parameterValues;

                List<string> listvariant = new List<string> { "0", "1" };
                container.ListConfiguredVariantID = listvariant;

                ILcontainer.Add(container);
                result.Add(moduleName, ILcontainer);

                return result;
            };

            cdfdata16.GetVariantCriterionSet = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetVariantCriterionModuleConfig = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");

                return variantset;
            };

            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            };

            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);

            /* Act */
            typeof(ParserXML).GetMethod("CheckVariantPostBuildCDF", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)59, (Int32)flag);
        }
    }

    [TestMethod]
    public void CheckVariantPostBuildCDFTest_198_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "Lin";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
			
			cdfdata16.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ILconfig = new List<Configuration>();
				Configuration config = new Configuration();
				config.postBuildVariantSupport = "true";
                config.ShortName = moduleName;
                ILconfig.Add(config);
                return ILconfig;
            };
			
            cdfdata16.GetAllInstanceContainersString = (String moduleName) =>
            {
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                IList<Container> ILcontainer = new List<Container>();
                Container container = new Container();
                IList<ItemValue> parameterValues = new List<ItemValue>();

                string defref1 = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";

                List<VariantItemValue> Lvariantitem = new List<VariantItemValue>();
                VariantItemValue variantitem1 = new VariantItemValue("0", 9600);
                Lvariantitem.Add(variantitem1);

                ItemValue itemval1 = new ItemValue(defref1, null, Lvariantitem);
                parameterValues.Add(itemval1);
                container.ParameterValues = parameterValues;
				container.VariantID = "0";

                List<string> listvariant = new List<string> { "0", "1" };
                container.ListConfiguredVariantID = listvariant;

                ILcontainer.Add(container);
                result.Add(moduleName, ILcontainer);

                return result;
            };

            cdfdata16.GetVariantCriterionSet = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetVariantCriterionModuleConfig = () =>
            {
                string result = "Criterion2";
                return result;
            };

            cdfdata16.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");
                variantset.Add("1", "Variant1");

                return variantset;
            };

            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            };

            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);

            /* Act */
            typeof(ParserXML).GetMethod("CheckVariantPostBuildCDF", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)57, (Int32)flag);
        }
    }
	
	[TestMethod]
    public void CheckVariantPostBuildCDFTest_198_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "Lin";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
			
			cdfdata16.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ILconfig = new List<Configuration>();
				Configuration config = new Configuration();
				config.postBuildVariantSupport = "false";
                config.ShortName = moduleName;
                ILconfig.Add(config);
                return ILconfig;
            };
			
            cdfdata16.GetAllInstanceContainersString = (String moduleName) =>
            {
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                IList<Container> ILcontainer = new List<Container>();
                Container container = new Container();
                IList<ItemValue> parameterValues = new List<ItemValue>();

                string defref1 = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";

                List<VariantItemValue> Lvariantitem = new List<VariantItemValue>();
                VariantItemValue variantitem1 = new VariantItemValue("0", 9600);
                Lvariantitem.Add(variantitem1);

                ItemValue itemval1 = new ItemValue(defref1, null, Lvariantitem);
                parameterValues.Add(itemval1);
                container.ParameterValues = parameterValues;
				container.VariantID = "0";

                List<string> listvariant = new List<string> { "0", "1" };
                container.ListConfiguredVariantID = listvariant;

                ILcontainer.Add(container);
                result.Add(moduleName, ILcontainer);

                return result;
            };

            cdfdata16.GetVariantCriterionSet = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetVariantCriterionModuleConfig = () =>
            {
                string result = "Criterion2";
                return result;
            };

            cdfdata16.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");
                variantset.Add("1", "Variant1");

                return variantset;
            };

            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            };

            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);

            /* Act */
            typeof(ParserXML).GetMethod("CheckVariantPostBuildCDF", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
	
	[TestMethod]
    public void CheckVariantPostBuildCDFTest_198_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "Lin";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
			
			cdfdata16.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ILconfig = new List<Configuration>();
				Configuration config = new Configuration();
				config.postBuildVariantSupport = "";
                config.ShortName = moduleName;
                ILconfig.Add(config);
                return ILconfig;
            };
			
            cdfdata16.GetAllInstanceContainersString = (String moduleName) =>
            {
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                IList<Container> ILcontainer = new List<Container>();
                Container container = new Container();
                IList<ItemValue> parameterValues = new List<ItemValue>();

                string defref1 = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";

                List<VariantItemValue> Lvariantitem = new List<VariantItemValue>();
                VariantItemValue variantitem1 = new VariantItemValue("0", 9600);
                Lvariantitem.Add(variantitem1);

                ItemValue itemval1 = new ItemValue(defref1, null, Lvariantitem);
                parameterValues.Add(itemval1);
                container.ParameterValues = parameterValues;
				container.VariantID = "0";

                List<string> listvariant = new List<string> { "0", "1" };
                container.ListConfiguredVariantID = listvariant;

                ILcontainer.Add(container);
                result.Add(moduleName, ILcontainer);

                return result;
            };

            cdfdata16.GetVariantCriterionSet = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetVariantCriterionModuleConfig = () =>
            {
                string result = "Criterion2";
                return result;
            };

            cdfdata16.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");
                variantset.Add("1", "Variant1");

                return variantset;
            };

            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            };

            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);

            /* Act */
            typeof(ParserXML).GetMethod("CheckVariantPostBuildCDF", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void CheckVariantPostBuildCDFTest_198_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */

            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "Lin";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
			
			cdfdata16.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ILconfig = new List<Configuration>();
				Configuration config = new Configuration();
				config.postBuildVariantSupport = "true";
                config.ShortName = moduleName;
                ILconfig.Add(config);
                return ILconfig;
            };

            

            cdfdata16.GetAllInstanceContainersString = (String moduleName) =>
            {
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                IList<Container> ILcontainer = new List<Container>();
                Container container = new Container();
                IList<ItemValue> parameterValues = new List<ItemValue>();

                string defref1 = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";

                List<VariantItemValue> Lvariantitem = new List<VariantItemValue>();
                VariantItemValue variantitem1 = new VariantItemValue("0", 9600);
                VariantItemValue variantitem2 = new VariantItemValue("1", 12000);
                Lvariantitem.Add(variantitem1);
                Lvariantitem.Add(variantitem2);

                ItemValue itemval1 = new ItemValue(defref1, null, Lvariantitem);
                parameterValues.Add(itemval1);
                container.ReferenceValues = parameterValues;

                List<string> listvariant = new List<string> { "0", "1" };
                container.ListConfiguredVariantID = listvariant;

                container.VariantID = "0";

                ILcontainer.Add(container);
                result.Add(moduleName, ILcontainer);

                return result;
            };

            cdfdata16.GetVariantCriterionSet = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetVariantCriterionModuleConfig = () =>
            {
                string result = "Criterion1";
                return result;
            };

            cdfdata16.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");
                variantset.Add("1", "Variant2");

                return variantset;
            };

            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            };

            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);

            /* Act */
            typeof(ParserXML).GetMethod("CheckVariantPostBuildCDF", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] {}, null).Invoke(_target, new object[] {});
            /* Assert */
            Assert.AreEqual((Int32)58, (Int32)flag);
        }
    }
}