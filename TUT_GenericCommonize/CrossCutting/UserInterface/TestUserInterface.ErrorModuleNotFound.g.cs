using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestUserInterface
{
    [TestMethod]
    public void ErrorModuleNotFoundTest_47_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            Int32 int32113 = 0;
            Int32 code = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoErrorCodeInt32 = (UserInterface instance, Int32 errorcode) =>
            {
                code = errorcode;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimEnvironmentWrapper.ExitInt32 = (Int32 exitCode) =>
            {
                return;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("ErrorModuleNotFound", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)(-1), (Int32)code);
        }
    }
}