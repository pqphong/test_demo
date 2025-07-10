using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using System.Diagnostics;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;

public partial class TestUserInterface
{
    [TestMethod]
    public void getCallerClassTest_43_1()
    {
        using (ShimsContext.Create())
        {
            int flag = 0;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, exitcode) =>
            {

                flag = exitcode;
            };

            IUserInterface ui = ObjectFactory.GetInstance<IUserInterface>();
            ui.Exit();
            Assert.AreEqual(0, flag);

        }
    }
}