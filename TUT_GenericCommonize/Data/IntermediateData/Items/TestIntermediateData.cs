using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;

[TestClass]
public partial class TestIntermediateData
{
    private IntermediateData _target = IntermediateData.Instance;
}