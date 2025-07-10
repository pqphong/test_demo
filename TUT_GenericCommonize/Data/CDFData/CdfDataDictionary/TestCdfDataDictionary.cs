using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

[TestClass]
public partial class TestCdfDataDictionary
{
    private CdfDataDictionary _target = CdfDataDictionary.Instance;
}