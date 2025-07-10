using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;

public partial class TestCommandLine
{
    [TestMethod]
    public void checkMissingValueForOptionTest_59_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String[] string91 = new String[2];
            String string91_0 = "-o";
            String string91_1 = "-fr";
            string91[0] = string91_0;
            string91[1] = string91_1;
            String[] options = string91;
            CommandLineInput commandlineinput102 = new CommandLineInput();
            Dictionary<String, String> commandlineinput102_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput102_OptionsWithValues_c = "can.cfgxml";
            String commandlineinput102_OptionsWithValues_fr = "";
            commandlineinput102.OptionsWithValues = commandlineinput102_OptionsWithValues;
            commandlineinput102_OptionsWithValues["-c"] = commandlineinput102_OptionsWithValues_c;
            commandlineinput102_OptionsWithValues["-fr"] = commandlineinput102_OptionsWithValues_fr;
            CommandLineInput userInputs = commandlineinput102;
            /* Act */
            Boolean actualResult = (Boolean)_target.GetType().GetMethod("checkMissingValueForOption", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String[]), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{options, userInputs});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void checkMissingValueForOptionTest_59_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String[] string93 = new String[2];
            String string93_0 = "-c";
            String string93_1 = "-fr";
            string93[0] = string93_0;
            string93[1] = string93_1;
            String[] options = string93;
            CommandLineInput commandlineinput104 = new CommandLineInput();
            Dictionary<String, String> commandlineinput104_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput104_OptionsWithValues_c = "can.cfgxml";
            String commandlineinput104_OptionsWithValues_fr = "Bosch";
            commandlineinput104.OptionsWithValues = commandlineinput104_OptionsWithValues;
            commandlineinput104_OptionsWithValues["-c"] = commandlineinput104_OptionsWithValues_c;
            commandlineinput104_OptionsWithValues["-fr"] = commandlineinput104_OptionsWithValues_fr;
            CommandLineInput userInputs = commandlineinput104;
            /* Act */
            Boolean actualResult = (Boolean)_target.GetType().GetMethod("checkMissingValueForOption", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String[]), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{options, userInputs});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}