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
    public void ProcessCommandLineTest_66_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.DisplayCmdInformation = (CommandLine instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.parseAndValidateOptions = (CommandLine instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.PrintToolInfo = (CommandLine instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.showInvalidOutputPath = (CommandLine instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.showInvalidInputPath = (CommandLine instance) =>
            {
                return;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("ProcessCommandLine", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
        /* Assert */
        }
    }
}