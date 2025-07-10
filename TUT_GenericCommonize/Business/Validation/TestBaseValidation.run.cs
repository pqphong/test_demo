using System;
using System.Reflection;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestBaseValidation
{
    [TestMethod]
    public void runTest_108_1()
    {
        using (ShimsContext.Create())
        {
            // Arrange
            bool info = false;
            bool warn = false;
            bool error = false;

            IUserInterface ui = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface
            {
                ErrorCountGet = () => { return 1; },
                InfoInt32Int32StringObjectArray = (id, e, m, p) => { info = true; },
                WarnInt32Int32StringObjectArray = (id, e, m, p) => { warn = true; },
                ErrorInt32Int32StringObjectArray = (id, e, m, p) => { error = true; },
                ExitInt32 = (exitCode) => { },
                Exit = () => { }
            };
            _target.GetType().GetField("UserInterface", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, ui);

            // Act
            invokeRun(_target, true);

            // Assert
            Assert.AreEqual(true, info);
            Assert.AreEqual(true, warn);
            Assert.AreEqual(false, error);
        }
    }

    [TestMethod]
    public void runTest_108_2()
    {
        // Arrange
        bool info = false;
        bool warn = false;
        bool error = false;

        IUserInterface ui = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface
        {
            InfoInt32Int32StringObjectArray = (id, e, m, p) => { info = true; },
            WarnInt32Int32StringObjectArray = (id, e, m, p) => { warn = true; },
            ErrorInt32Int32StringObjectArray = (id, e, m, p) => { error = true; },
            ExitInt32 = (exitCode) => { },
            Exit = () => { }
        };
        _target.GetType().GetField("UserInterface", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, ui);

        // Act
        invokeRun(_target, false);

        // Assert
        Assert.AreEqual(true, info);
        Assert.AreEqual(true, warn);
        Assert.AreEqual(true, error);
    }

    private void invokeRun(BaseValidation target, bool runPre)
    {
        target.GetType().BaseType
            .GetMethod("run", BindingFlags.NonPublic | BindingFlags.Instance)
            .Invoke(target, new object[] { runPre });
    }
}
