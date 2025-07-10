using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestParserXML
{


    
    [TestMethod]
    public void CheckAutosarVersionTest_12_1()
    {
        using (ShimsContext.Create())
        {
            int errorCode1 = 0;
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackages.Add(arPackage);
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            root.Add(arPackages);
            document.Add(root);
            Dictionary<string, XDocument> result = new Dictionary<string, XDocument>();
            result.Add("file1", document);
            typeof(ParserXML).GetField("CdfFiles",
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, result);
            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "can";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            BswConfig bswconfig106 = new BswConfig();
            String bswconfig106_ArReleaseVersion = "4.3.1";
            bswconfig106.ArReleaseVersion = bswconfig106_ArReleaseVersion;
            BswConfig bswConfig = bswconfig106;
            Int32 int321111 = 0;
            Int32 errorCode = int321111;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.Exit = () =>
            {
                errorCode1 = 29;
                return;
            }

            ;
            ObjectFactory.SupportedVariants.Add("E2x", new List<string>() { "R7F702002AEABA" });
            // Prevent impact from others test case.
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (instance) =>
            {

                return "R7F702002AEABA";
            };

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            /* Act */
            typeof(ParserXML).GetMethod("CheckAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BswConfig) }, null).Invoke(_target, new object[] { bswConfig });
            /* Assert */
            Assert.AreEqual((Int32)29, (Int32)errorCode1);
        }
    }

    

    [TestMethod]
    public void CheckAutosarVersionTest_12_2()
    {
        using (ShimsContext.Create())
        {
            int errorCode1 = 0;
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackages.Add(arPackage);
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            root.Add(arPackages);
            document.Add(root);
            Dictionary<string, XDocument> result = new Dictionary<string, XDocument>();
            result.Add("file1", document);
            typeof(ParserXML).GetField("CdfFiles",
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, result);
            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "can";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);
           
            BswConfig bswconfig1014 = new BswConfig();
            String bswconfig1014_ArReleaseVersion = "4.2.2";
            bswconfig1014.ArReleaseVersion = bswconfig1014_ArReleaseVersion;
            BswConfig bswConfig = bswconfig1014;
            Int32 int321115 = 0;
            Int32 errorCode = int321115;
            var userinterface128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface128.Exit = () =>
            {
                errorCode1 = 29;
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface128);
            // Prevent inpact from other test cases.
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (instance) =>
            {
                return "R7F702011EABA";

            };


            /* Act */
            typeof(ParserXML).GetMethod("CheckAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BswConfig) }, null).Invoke(_target, new object[] { bswConfig });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void CheckAutosarVersionTest_12_3()
    {
        using (ShimsContext.Create())
        {
            int errorCode1 = 0;
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            root.Add(arPackages);
            document.Add(root);
            Dictionary<string, XDocument> result = new Dictionary<string, XDocument>();
            result.Add("file1", document);
            typeof(ParserXML).GetField("CdfFiles",
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, result);
            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "can";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            BswConfig bswconfig106 = new BswConfig();
            String bswconfig106_ArReleaseVersion = "4.3.1";
            bswconfig106.ArReleaseVersion = bswconfig106_ArReleaseVersion;
            BswConfig bswConfig = bswconfig106;
            Int32 int321111 = 0;
            Int32 errorCode = int321111;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.Exit = () =>
            {
                errorCode1 = 29;
                return;
            }

            ;
            // Prevent impact from others test case.
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (instance) =>
            {

                return "";
            };

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            /* Act */
            typeof(ParserXML).GetMethod("CheckAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BswConfig) }, null).Invoke(_target, new object[] { bswConfig });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }
	
	[TestMethod]
    public void CheckAutosarVersionTest_12_4()
    {
        using (ShimsContext.Create())
        {
            int errorCode1 = 0;
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            root.Add(arPackages);
            document.Add(root);
            Dictionary<string, XDocument> result = new Dictionary<string, XDocument>();
            result.Add("file1", document);
            typeof(ParserXML).GetField("CdfFiles",
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, result);
            IBasicConfiguration ibasicconfiguration135 = BasicConfiguration.Instance;
            String ibasicconfiguration135_ModuleName = "can";
            ibasicconfiguration135.ModuleName = ibasicconfiguration135_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration135);

            BswConfig bswconfig106 = new BswConfig();
            String bswconfig106_ArReleaseVersion = "4.8.0";
            bswconfig106.ArReleaseVersion = bswconfig106_ArReleaseVersion;
            BswConfig bswConfig = bswconfig106;
            Int32 int321111 = 0;
            Int32 errorCode = int321111;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.Exit = () =>
            {
                errorCode1 = 29;
                return;
            }

            ;
            // Prevent impact from others test case.
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (instance) =>
            {

                return "R7F70254xFABG";
            };

            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            /* Act */
            typeof(ParserXML).GetMethod("CheckAutosarVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BswConfig) }, null).Invoke(_target, new object[] { bswConfig });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }
}