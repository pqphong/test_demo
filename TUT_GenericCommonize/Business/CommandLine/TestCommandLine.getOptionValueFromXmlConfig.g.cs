using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using System.Xml.Linq;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestCommandLine
{
    [TestMethod]
    public void getOptionValueFromXmlConfigTest_61_1()
    {
        using (ShimsContext.Create())
        {
            int flag = 0;
            System.Xml.Linq.Fakes.ShimXContainer.AllInstances.Descendants = x =>
            {
                return new List<XElement>() {
                    new XElement("HELP","ON"),
                    new XElement("LOG","ON"),
                    new XElement("DRYRUN","OFF")
                };
            };
            /* Arrange */

           
            String string102 = "help";
            String option = string102;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getOptionValueFromXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument), typeof(String) }, null).Invoke(_target, new object[] { new XDocument(), option });
            /* Assert */
            Assert.AreEqual(flag, 0);
            Assert.AreEqual(actualResult, "ON");
        }
    }
    [TestMethod]
    public void getOptionValueFromXmlConfigTest_61_2()
    {
        using (ShimsContext.Create())
        {
            System.Xml.Linq.Fakes.ShimXContainer.AllInstances.Descendants = x =>
            {
                return new List<XElement>() {
                    new XElement("LOG","ON"),
                    new XElement("DRYRUN","OFF")
                };
            };
            
            String string102 = "FILTER-NAME";
            String option = string102;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getOptionValueFromXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument), typeof(String) }, null).Invoke(_target, new object[] { new XDocument(), option });
            /* Assert */
             Assert.AreEqual(actualResult, "");
        }
    }
    [TestMethod]
    public void getOptionValueFromXmlConfigTest_61_3()
    {
        using (ShimsContext.Create())
        {
            int flag = 0;
            System.Xml.Linq.Fakes.ShimXContainer.AllInstances.Descendants = x =>
            {
                return new List<XElement>() {
                    new XElement("FILTER-NAME",""),
                    new XElement("LOG","ON"),
                    new XElement("DRYRUN","OFF")
                };
            };
            /* Arrange */
           
            String string102 = "FILTER-NAME";
            String option = string102;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getOptionValueFromXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument), typeof(String) }, null).Invoke(_target, new object[] { new XDocument(), option });
            /* Assert */
            Assert.AreEqual(flag, 0);
            Assert.AreEqual(actualResult, "");
        }
    }
    
}