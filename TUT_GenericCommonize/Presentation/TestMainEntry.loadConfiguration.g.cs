using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Presentation.MainEntry;

public partial class TestMainEntry
{
    [TestMethod]
    public void loadConfigurationTest_4_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Assembly assembly = ReflectionWrapper.LoadFrom(@"U:\external\X2x\common\generic\generator\dlls\E2x\CanE2x.dll") ;
            /* Act */
            typeof(MainEntry).GetMethod("loadConfiguration", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(Assembly)}, null).Invoke(_target, new object[]{assembly});
            /* Assert */
            IBasicConfiguration configuration = ObjectFactory.GetInstance<IBasicConfiguration>();
            Assert.AreEqual(configuration.ModuleName, "Can");

        }
    }
}