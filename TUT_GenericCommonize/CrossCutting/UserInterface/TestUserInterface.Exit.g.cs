using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestUserInterface
{
    [TestMethod]
    public void ExitTest_44_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.getCallerClass = (UserInterface instance) =>
            {
                Type type91 = null;
                return type91;
            }

            ;
            Int32 int32102 = 0;
            Int32 code = int32102;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, exitCode) =>
            {
                code = exitCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("Exit", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)code);
        }
    }

    [TestMethod]
    public void ExitTest_44_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.getCallerClass = (UserInterface instance) =>
            {
                return typeof(ObjectFactory);                
            };
            Int32 int32105 = 0;
            Int32 code = int32105;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, exitCode) =>
            {
                code = exitCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("Exit", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)code);
        }
    }

    [TestMethod]
    public void ExitTest_44_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.getCallerClass = (UserInterface instance) =>
            {
                return typeof(IIntermediate);
                ;
            }

            ;
            Int32 int32108 = 0;
            Int32 code = int32108;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, exitCode) =>
            {
                code = exitCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("Exit", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)2, (Int32)code);
        }
    }
}