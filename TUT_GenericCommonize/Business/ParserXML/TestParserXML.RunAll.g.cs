using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;

public partial class TestParserXML
{
    [TestMethod]
    public void RunAllTest_37_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.LoadFile = (ParserXML instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseCDFs = (ParserXML instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.CheckRequiredModules = (ParserXML instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseTranslationFile = (ParserXML instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.UpdateBasicConfigurationIfNeeded = (ParserXML instance) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(ParserXML).GetMethod("RunAll", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
        /* Assert */
        }
    }
}