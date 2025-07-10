using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestRuntimeConfiguration
{
    [TestMethod]
    public void overrideOptionsTest_126_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary91 = new Dictionary<String, String>();
            String dictionary91_h = "False";
            String dictionary91_l = "False";
            String dictionary91_d = "False";
            String dictionary91_o = "U:\\Test_GenTool\\Spi_Output";
            String dictionary91_fr = "Renesas Bosch";
            dictionary91["-h"] = dictionary91_h;
            dictionary91["-l"] = dictionary91_l;
            dictionary91["-d"] = dictionary91_d;
            dictionary91["-o"] = dictionary91_o;
            dictionary91["-fr"] = dictionary91_fr;
            Dictionary<String, String> options = dictionary91;
            /* Act */
            typeof(RuntimeConfiguration).GetMethod("overrideOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{options});
        /* Assert */
        }
    }

    [TestMethod]
    public void overrideOptionsTest_126_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary92 = null;
            Dictionary<String, String> options = dictionary92;
            /* Act */
            typeof(RuntimeConfiguration).GetMethod("overrideOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{options});
        /* Assert */
        }
    }

    [TestMethod]
    public void overrideOptionsTest_126_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary93 = new Dictionary<String, String>();
            String dictionary93_h = "help";
            dictionary93["-h"] = dictionary93_h;
            Dictionary<String, String> options = dictionary93;
            /* Act */
            typeof(RuntimeConfiguration).GetMethod("overrideOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{options});
        /* Assert */
        }
    }
}