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
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;

public partial class TestParserXML
{
    [TestMethod]
    public void ParseBswPackageTest_189_1()
    {
        using (ShimsContext.Create())
        {
            CdfDataDictionary cdfdatabase = CdfDataDictionary.Instance;

            typeof(CdfDataDictionary).GetField("bswConfigs", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(cdfdatabase, new Dictionary<string, List<BswConfig>>());
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, cdfdatabase);

            IBasicConfiguration basicConfig = ObjectFactory.GetInstance<IBasicConfiguration>();
            basicConfig.ModuleName = "Lin";
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, basicConfig);

            XElement document = new XElement("AR-PACKAGE");
            XElement documentShortName = new XElement("SHORT-NAME", "Package");
            document.Add(documentShortName);
            XElement root = new XElement("ELEMENTS");
            XElement BSW_MODULE_DESCRIPTION = new XElement("BSW-MODULE-DESCRIPTION");
            XElement short_name = new XElement("SHORT-NAME", "LinInternalBehavior");
            XElement moduleId = new XElement("MODULE-ID", "82");
            BSW_MODULE_DESCRIPTION.Add(short_name);
            BSW_MODULE_DESCRIPTION.Add(moduleId);
            BSW_MODULE_DESCRIPTION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root.Add(BSW_MODULE_DESCRIPTION);

            XElement BSW_IMPLEMENTATION = new XElement("BSW-IMPLEMENTATION");
            XElement shortName2 = new XElement("PROGRAMMING-LANGUAGE", "C");
            XElement SW_VERSION = new XElement("SW-VERSION", "1.2.10");
            XElement VENDOR_ID = new XElement("VENDOR-ID", "59");
            XElement AR_RELEASE_VERSION = new XElement("AR-RELEASE-VERSION", "4.2.2");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REFS = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REFS");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REF = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REF", "/Renesas/EcucDefs_Lin/Lin");
            BSW_IMPLEMENTATION.Add(shortName2);
            BSW_IMPLEMENTATION.Add(SW_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_ID);
            BSW_IMPLEMENTATION.Add(AR_RELEASE_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_SPECIFIC_MODULE_DEF_REFS);
            VENDOR_SPECIFIC_MODULE_DEF_REFS.Add(VENDOR_SPECIFIC_MODULE_DEF_REF);
            BSW_IMPLEMENTATION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root.Add(BSW_IMPLEMENTATION);

            /* Arrange */
            document.Add(root);


            XElement childpackages = new XElement("AR-PACKAGES");
            XElement childpackage = new XElement("AR-PACKAGE");
            XElement childpackageShortName = new XElement("SHORT-NAME", "childPackage");
            childpackage.Add(childpackageShortName);

            XElement root1 = new XElement("ELEMENTS");
            XElement BSW_MODULE_DESCRIPTION1 = new XElement("BSW-MODULE-DESCRIPTION");
            XElement short_name1 = new XElement("SHORT-NAME", "LinInternalBehavior1");
            XElement moduleId1 = new XElement("MODULE-ID", "82");
            BSW_MODULE_DESCRIPTION1.Add(short_name1);
            BSW_MODULE_DESCRIPTION1.Add(moduleId1);
            BSW_MODULE_DESCRIPTION1.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root1.Add(BSW_MODULE_DESCRIPTION1);

            XElement BSW_IMPLEMENTATION1 = new XElement("BSW-IMPLEMENTATION");
            XElement shortName21 = new XElement("PROGRAMMING-LANGUAGE", "C");
            XElement SW_VERSION1 = new XElement("SW-VERSION", "1.2.10");
            XElement VENDOR_ID1 = new XElement("VENDOR-ID", "59");
            XElement AR_RELEASE_VERSION1 = new XElement("AR-RELEASE-VERSION", "4.2.2");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REFS1 = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REFS");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REF1 = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REF", "/Renesas/EcucDefs_Lin/Lin");
            BSW_IMPLEMENTATION1.Add(shortName21);
            BSW_IMPLEMENTATION1.Add(SW_VERSION1);
            BSW_IMPLEMENTATION1.Add(VENDOR_ID1);
            BSW_IMPLEMENTATION1.Add(AR_RELEASE_VERSION1);
            BSW_IMPLEMENTATION1.Add(VENDOR_SPECIFIC_MODULE_DEF_REFS1);
            VENDOR_SPECIFIC_MODULE_DEF_REFS1.Add(VENDOR_SPECIFIC_MODULE_DEF_REF1);
            BSW_IMPLEMENTATION1.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root1.Add(BSW_IMPLEMENTATION1);
            childpackage.Add(root1);
            childpackages.Add(childpackage);

            document.Add(childpackages);

            String parenpath = "/";
            /* Act */
            typeof(ParserXML).GetMethod("ParseBswPackage", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { document, parenpath });
            /* Assert */
            Object cdfdata = typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            Object bswdata = typeof(CdfDataDictionary).GetField("bswConfigs", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(cdfdata);
            Dictionary<string, List<BswConfig>> bswdict = (Dictionary<string, List<BswConfig>>)bswdata;
            List<BswConfig> bswList = bswdict.Values.SelectMany(x => x).ToList();
            Assert.AreEqual(bswList.Count, (int)2);
        }
    }


    [TestMethod]
    public void ParseBswPackageTest_189_2()
    {
        using (ShimsContext.Create())
        {
            CdfDataDictionary cdfdatabase = CdfDataDictionary.Instance;

            typeof(CdfDataDictionary).GetField("bswConfigs", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(cdfdatabase, new Dictionary<string, List<BswConfig>>());
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, cdfdatabase);

            XElement document = new XElement("AR-PACKAGE");
			XElement documentShortName = new XElement("SHORT-NAME", "Package");
            document.Add(documentShortName);

            String parenpath = "/";
            /* Act */
            typeof(ParserXML).GetMethod("ParseBswPackage", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { document, parenpath });
            /* Assert */
            Object cdfdata = typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
			Object bswdata =  typeof(CdfDataDictionary).GetField("bswConfigs", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(cdfdata);
			Dictionary<string, List<BswConfig>> bswdict = (Dictionary<string, List<BswConfig>>)bswdata;
            List<BswConfig> bswList = bswdict.Values.SelectMany(x => x).ToList();
            Assert.AreEqual(bswList.Count, (int)0);
        }
    }
}