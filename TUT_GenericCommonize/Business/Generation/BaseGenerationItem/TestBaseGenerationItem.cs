using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

[TestClass]
public partial class TestBaseGenerationItem
{
    private BaseGenerationItem _target = new BaseGenerationItem(null, null, null, null, null);
}