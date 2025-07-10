using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Presentation.MainEntry;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestMainEntry
{
    [TestMethod]
    public void unhandledExceptionHandlerTest_3_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object91 = new Object();
            Object sender = object91;
            TargetInvocationException ex = new TargetInvocationException("TargetInvocationException", new MissingFieldException("missing field"));
            UnhandledExceptionEventArgs unhandledexceptioneventargs102 = new UnhandledExceptionEventArgs(ex, false);
            UnhandledExceptionEventArgs e = unhandledexceptioneventargs102;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, errorCode) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(MainEntry).GetMethod("unhandledExceptionHandler", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { typeof(Object), typeof(UnhandledExceptionEventArgs) }, null).Invoke(_target, new object[] { sender, e });
            /* Assert */
            Assert.AreEqual((Int32)43, (Int32)flag);
        }
    }

    
    [TestMethod]
    [ExpectedException(typeof(TargetInvocationException))]
    public void unhandledExceptionHandlerTest_3_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object91 = new Object();
            Object sender = object91;
            TargetInvocationException t = new TargetInvocationException("", new NullReferenceException());
            UnhandledExceptionEventArgs unhandledexceptioneventargs102 = new UnhandledExceptionEventArgs(t, false);
            UnhandledExceptionEventArgs e = unhandledexceptioneventargs102;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, errorCode) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(MainEntry).GetMethod("unhandledExceptionHandler", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { typeof(Object), typeof(UnhandledExceptionEventArgs) }, null).Invoke(_target, new object[] { sender, e });
            /* Assert */
        }
    }

    [TestMethod]
    public void unhandledExceptionHandlerTest_3_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object91 = new Object();
            Object sender = object91;
            TargetInvocationException ex = new TargetInvocationException("TargetInvocationException", new TypeInitializationException("missing field",null));
            UnhandledExceptionEventArgs unhandledexceptioneventargs102 = new UnhandledExceptionEventArgs(ex, false);
            UnhandledExceptionEventArgs e = unhandledexceptioneventargs102;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, errorCode) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(MainEntry).GetMethod("unhandledExceptionHandler", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { typeof(Object), typeof(UnhandledExceptionEventArgs) }, null).Invoke(_target, new object[] { sender, e });
            /* Assert */
            Assert.AreEqual((Int32)43, (Int32)flag);
        }
    }

    [TestMethod]
    public void unhandledExceptionHandlerTest_3_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object91 = new Object();
            Object sender = object91;
            TargetInvocationException ex = new TargetInvocationException("TargetInvocationException", new MissingMethodException("missing method"));
            UnhandledExceptionEventArgs unhandledexceptioneventargs102 = new UnhandledExceptionEventArgs(ex, false);
            UnhandledExceptionEventArgs e = unhandledexceptioneventargs102;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, errorCode) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(MainEntry).GetMethod("unhandledExceptionHandler", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { typeof(Object), typeof(UnhandledExceptionEventArgs) }, null).Invoke(_target, new object[] { sender, e });
            /* Assert */
            Assert.AreEqual((Int32)43, (Int32)flag);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(TargetInvocationException))]
    public void unhandledExceptionHandlerTest_3_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object91 = new Object();
            Object sender = object91;
            Exception ex = new Exception("TargetInvocationException", new MissingMethodException("missing method"));
            UnhandledExceptionEventArgs unhandledexceptioneventargs102 = new UnhandledExceptionEventArgs(ex, false);
            UnhandledExceptionEventArgs e = unhandledexceptioneventargs102;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, errorCode) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(MainEntry).GetMethod("unhandledExceptionHandler", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { typeof(Object), typeof(UnhandledExceptionEventArgs) }, null).Invoke(_target, new object[] { sender, e });
            /* Assert */
            Assert.AreEqual((Int32)43, (Int32)flag);
        }
    }

}