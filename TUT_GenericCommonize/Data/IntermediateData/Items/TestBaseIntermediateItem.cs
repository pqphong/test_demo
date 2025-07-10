using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

[TestClass]
public partial class TestBaseIntermediateItem
{
    private BaseIntermediateItem _target = new BaseIntermediateItem(null, null);
    private BaseIntermediateItem _target1 = new BaseIntermediateItem(null, null, null);
}