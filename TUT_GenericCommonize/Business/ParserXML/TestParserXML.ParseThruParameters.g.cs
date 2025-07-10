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

public partial class TestParserXML
{
    [TestMethod]
    public void ParseThruParametersTest_26_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("PARAMETER-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            defRef.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            XElement value = new XElement("VALUE", "true");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(value);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Container), typeof(XElement)}, null).Invoke(_target, new object[]{container, element});
            /* Assert */
            Object actualResult_count_12 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_12);
        }
    }

    [TestMethod]
    public void ParseThruParametersTest_26_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("PARAMETER-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defRef = new XElement("DEFINITION-REF");
            defRef.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            XElement value = new XElement("VALUE");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(value);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] {container, element });
            /* Assert */
            Object actualResult_count_12 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_12);
        }
    }

    [TestMethod]
    public void ParseThruParametersTest_26_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("PARAMETER-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate");
            defRef.Add(new XAttribute("DEST", "ECUC-INTEGER-PARAM-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE", "9600");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            XElement ECUC_NUMERICAL_PARAM_VALUE1 = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defRef1 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate");
            defRef1.Add(new XAttribute("DEST", "ECUC-INTEGER-PARAM-DEF"));
            XElement varpoint1 = new XElement("VARIATION-POINT");
            XElement pbvarcons1 = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon1 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref1 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref1.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val10 = new XElement("VALUE", "1");
            pbvarcon1.Add(matchref1);
            pbvarcon1.Add(val10);
            pbvarcons1.Add(pbvarcon1);
            varpoint1.Add(pbvarcons1);
            XElement val11 = new XElement("VALUE", "9600");
            ECUC_NUMERICAL_PARAM_VALUE1.Add(defRef1);
            ECUC_NUMERICAL_PARAM_VALUE1.Add(varpoint1);
            ECUC_NUMERICAL_PARAM_VALUE1.Add(val11);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE1);


            XElement ECUC_NUMERICAL_PARAM_VALUE2 = new XElement("ECUC-TEXTUAL-PARAM-VALUE");
            XElement defRef2 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinInterByteSpace");
            defRef2.Add(new XAttribute("DEST", "ECUC-ENUMERATION-PARAM-DEF"));
            XElement varpoint2 = new XElement("VARIATION-POINT");
            XElement pbvarcons2 = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref2 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val20 = new XElement("VALUE", "1");
            pbvarcon2.Add(matchref2);
            pbvarcon2.Add(val20);
            pbvarcons2.Add(pbvarcon2);
            varpoint2.Add(pbvarcons2);
            XElement val21 = new XElement("VALUE", "Tbits_3");
            ECUC_NUMERICAL_PARAM_VALUE2.Add(defRef2);
            ECUC_NUMERICAL_PARAM_VALUE2.Add(varpoint2);
            ECUC_NUMERICAL_PARAM_VALUE2.Add(val21);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE2);

            Container container = new Container();

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_12 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_12);
        }
    }

    [TestMethod]
    public void ParseThruParametersTest_26_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("PARAMETER-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate");
            defRef.Add(new XAttribute("DEST", "ECUC-INTEGER-PARAM-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REFFF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE", "9600");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_12 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_12);
        }
    }

    [TestMethod]
    public void ParseThruParametersTest_26_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("PARAMETER-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate");
            defRef.Add(new XAttribute("DEST", "ECUC-INTEGER-PARAM-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONSSS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE", "9600");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_12 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_12);
        }
    }

    [TestMethod]
    public void ParseThruParametersTest_26_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("PARAMETER-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defRef = new XElement("DEFINITION-REFFF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate");
            defRef.Add(new XAttribute("DEST", "ECUC-INTEGER-PARAM-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE", "9600");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_12 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_12);
        }
    }
}