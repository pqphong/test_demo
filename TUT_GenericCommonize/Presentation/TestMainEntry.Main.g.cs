using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Presentation.MainEntry;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using static Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.ObjectFactory;
using System.IO;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;

public partial class TestMainEntry
{
    [TestMethod]
    public void MainTest_1_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.registerAssemblyTypes = () =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.printInfoIfNeed = () =>
            {
                return;
            }

            ;
            
            String[] string113 = new String[3];
            String string113_0 = "";
            String string113_1 = "-m";
            String string113_2 = "can";
            string113[0] = string113_0;
            string113[1] = string113_1;
            string113[2] = string113_2;
            String[] args = string113;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.ProcessCommandLine = (CommandLine instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParser.AllInstances.RunAll = (Parser instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.ValidatePreIntermediate = (BaseValidation instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.ValidatePostIntermediate = (BaseValidation instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Intermediate.Fakes.ShimBaseIntermediate.AllInstances.ComputeAll = (BaseIntermediate instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Generation.Fakes.ShimGeneration.AllInstances.GenerateOuput = (Generation instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (UserInterface instance) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
            {
                var intermediate = new IntermediateClassTest();
                var cmd = new CommandLineClassTest();
                var validation = new ValidationClassTest();
                var generation = new GenerationClassTest();
                var parser = new ParserXMLClassTest();
                var userInterface = new UserInterfaceClassTest();
                var repo = new RepositoryLinQTest1();
                var basicConfiguration = new BasicConfigurationTest();
                basicConfiguration.NumberOfInstances = 1;
                if (type == typeof(IIntermediate))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IIntermediate), intermediate),
                    };
                }
                if (type == typeof(ICommandLine))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(ICommandLine), cmd),
                    };
                }
                if (type == typeof(IValidation))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IValidation), validation),
                    };
                }
                if (type == typeof(IGeneration))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IGeneration), generation),
                    };
                }
                if (type == typeof(IParser))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IParser), parser),
                    };
                }
                if (type == typeof(IUserInterface))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IUserInterface), userInterface),
                    };
                }
                if(type == typeof(IRepository))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IRepository), repo),
                    };
                }
                if (type == typeof(IBasicConfiguration))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IBasicConfiguration), basicConfiguration),
                    };
                }
                else
                {
                    return new List<CacheObject>();
                }
            };

            /* Act */
            typeof(MainEntry).GetMethod("Main", BindingFlags.Static | BindingFlags.Public, null, new Type[] {  }, null).Invoke(_target, new object[] {  });
            /* Assert */
        }
    }

    [TestMethod]
    public void MainTest_1_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.registerAssemblyTypes = () =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.printInfoIfNeed = () =>
            {
                return;
            }

            ;
            String[] string113 = new String[3];
            String string113_0 = "";
            String string113_1 = "-m";
            String string113_2 = "can";
            string113[0] = string113_0;
            string113[1] = string113_1;
            string113[2] = string113_2;
            String[] args = string113;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.ProcessCommandLine = (CommandLine instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParser.AllInstances.RunAll = (Parser instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.ValidatePreIntermediate = (BaseValidation instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.ValidatePostIntermediate = (BaseValidation instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Intermediate.Fakes.ShimBaseIntermediate.AllInstances.ComputeAll = (BaseIntermediate instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Generation.Fakes.ShimGeneration.AllInstances.GenerateOuput = (Generation instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (UserInterface instance) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
            {
                var intermediate = new IntermediateClassTest();
                var cmd = new CommandLineClassTest();
                var validation = new ValidationClassTest();
                var generation = new GenerationClassTest();
                var parser = new ParserXMLClassTest();
                var userInterface = new UserInterfaceClassTest();
                var repo = new RepositoryLinQTest2();
                var basicConfiguration = new BasicConfigurationTest();
                if (type == typeof(IIntermediate))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IIntermediate), intermediate),
                    };
                }
                if (type == typeof(ICommandLine))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(ICommandLine), cmd),
                    };
                }
                if (type == typeof(IValidation))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IValidation), validation),
                    };
                }
                if (type == typeof(IGeneration))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IGeneration), generation),
                    };
                }
                if (type == typeof(IParser))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IParser), parser),
                    };
                }
                if (type == typeof(IUserInterface))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IUserInterface), userInterface),
                    };
                }
                if (type == typeof(IRepository))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IRepository), repo),
                    };
                }
                if (type == typeof(IBasicConfiguration))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IBasicConfiguration), basicConfiguration),
                    };
                }
                else
                {
                    return new List<CacheObject>();
                }
            };

            /* Act */
            typeof(MainEntry).GetMethod("Main", BindingFlags.Static | BindingFlags.Public, null, new Type[] {  }, null).Invoke(_target, new object[] {  });
            /* Assert */
        }
    }
}

public class IntermediateClassTest : IIntermediate
{
    public void ComputeAll()
    {

    }
}

public class CommandLineClassTest : ICommandLine
{
    public void DisplayCmdInformation()
    {
    }

    public string GetAndValidateModuleName()
    {
        return "";
    }

    public void PrintToolInfo()
    {
    }

    public void ProcessCommandLine()
    {
    }
}

public class ValidationClassTest : IValidation
{
    public void ValidatePostIntermediate()
    {
    }

    public void ValidatePreIntermediate()
    {
    }
}

public class GenerationClassTest : IGeneration
{
    public void GenerateOuput()
    {
    }
}

public class ParserXMLClassTest : IParser
{
    public void RunAll()
    {
    }
}

public class RepositoryLinQTest1 : IRepository
{
    public void UpdateBasicConfig()
    {
    }

    public BaseIntermediateItem ComputeDemEventParams(Dictionary<string, string> demEventParamsGroup)
    {
        throw new NotImplementedException();
    }

    public BaseIntermediateItem ComputeOnOffParams(Dictionary<string, string> onOffParamsGroup)
    {
        return null;
    }

    public string GetAddressByMacroDefinition(string renesasMacroName)
    {
        return "";
    }

    public string GetAddressTypeByMacroDefinition(string renesasMacroName)
    {
        return "";
    }

    public Dictionary<string, IList<Container>> GetAllInstancesContainersByDefName(string moduleName, string defName, int sortOption = 0, string variantID = "")
    {
        return null;
    }

    public string GetCdfFileName(string shortName)
    {
        return "";
    }

    public IList<Container> GetChilds(string moduleName, string shortName, string variantID = "")
    {
        return null;
    }
    public Configuration GetConfiguration(string moduleName)
    {
        return new Configuration() { ShortName = "", DefinitionRef = "", ModuleDescriptionRef = "", Uuid = "" };
    }

    public IList<Configuration> GetConfigurations(string moduleName)
    {

        return new List<Configuration>() { new Configuration() { ShortName="Can0", DefinitionRef="/Renesas/autosar/can"},
        new Configuration() { ShortName="Can1", DefinitionRef="/Renesas/autosar/can"},
            new Configuration() { ShortName ="fls0", DefinitionRef="/Renesas/autosar/fls"} };
    }

    public Container GetContainerByDefName(string moduleName, string defName, int sortType = 0, string variantID = "")
    {
        return null;
    }

    public Container GetContainerByShortNamePath(string moduleName, string path, string variantID = "")
    {
        return null;
    }

    public IList<Container> GetContainers(string moduleName = "")
    {
        return null;
    }

    public IList<Container> GetContainersByDefName(string moduleName, string defName, int sortOption = 0, string variantID = "")
    {
        return null;
    }

    public string GetMacroAddressValue(string renesasMacroName)
    {
        return null;
    }

    public string GetMacroLabelValue(string renesasMacroName)
    {
        return null;
    }

    public ItemValue GetParameterValue(string moduleName, string defName, string variantID = "")
    {
        return null;
    }

    public IList<ItemValue> GetParameterValues(string moduleName, string defName, string variantID = "")
    {
        return null;
    }

    public ItemValue GetReferenceValue(string moduleName, string defName, string variantID = "")
    {
        return null;
    }

    public List<ItemValue> GetReferenceValues(string defName, string moduleName = "", string variantID = "")
    {
        return null;
    }

    public string GetStartOfDbToc()
    {
        return "";
    }

    public string GetVersionInformation(string name, string module = "")
    {
        return "";
    }

    public BaseIntermediateItem GetVersionInformation()
    {
        return null;
    }

    public bool IsExistedPath(string path, string moduleName = "")
    {
        return true;
    }

    public bool IsExistModuleName(string moduleName)
    {
        return true;
    }

    public bool IsRegisterExist(string renesasMacroDefinition)
    {
        return true;
    }

    public void PrepareInstance(int instanceIndex)
    {

    }
    public bool CheckVariantParameterSupported(string moduleName, string parameterName)
    {
        return true;
    }

    public bool CheckVariantContainerSupported(string moduleName, string containerName)
    {
        return true;
    }
    public List<string> GetAllVariantConfiguration(string moduleName)
    {
        return null;
    }
    public Dictionary<string, string> GetShortNameVariantConfig(string moduleName)
    {
        return null;
    }
}

public class RepositoryLinQTest2 : IRepository
{
    public void UpdateBasicConfig()
    {
    }
    public BaseIntermediateItem ComputeDemEventParams(Dictionary<string, string> demEventParamsGroup)
    {
        throw new NotImplementedException();
    }

    public BaseIntermediateItem ComputeOnOffParams(Dictionary<string, string> onOffParamsGroup)
    {
        return null;
    }

    public string GetAddressByMacroDefinition(string renesasMacroName)
    {
        return "";
    }

    public string GetAddressTypeByMacroDefinition(string renesasMacroName)
    {
        return "";
    }

    public Dictionary<string, IList<Container>> GetAllInstancesContainersByDefName(string moduleName, string defName, int sortOption = 0, string variantID = "")
    {
        return null;
    }

    public string GetCdfFileName(string shortName)
    {
        return "";
    }

    public IList<Container> GetChilds(string moduleName, string shortName, string variantID = "")
    {
        return null;
    }
    public Configuration GetConfiguration(string moduleName)
    {
        return new Configuration() { ShortName = "", DefinitionRef = "", ModuleDescriptionRef = "", Uuid = "" };
    }

    public IList<Configuration> GetConfigurations(string moduleName)
    {

        return new List<Configuration>() { new Configuration() { ShortName="Can0", DefinitionRef="/Renesas/autosar/can"} };
    }

    public Container GetContainerByDefName(string moduleName, string defName, int sortType = 0, string variantID = "")
    {
        return null;
    }

    public Container GetContainerByShortNamePath(string moduleName, string path, string variantID = "")
    {
        return null;
    }

    public IList<Container> GetContainers(string moduleName = "")
    {
        return null;
    }

    public IList<Container> GetContainersByDefName(string moduleName, string defName, int sortOption = 0, string variantID = "")
    {
        return null;
    }

    public string GetMacroAddressValue(string renesasMacroName)
    {
        return null;
    }

    public string GetMacroLabelValue(string renesasMacroName)
    {
        return null;
    }

    public ItemValue GetParameterValue(string moduleName, string defName, string variantID = "")
    {
        return null;
    }

    public IList<ItemValue> GetParameterValues(string moduleName, string defName, string variantID = "")
    {
        return null;
    }

    public ItemValue GetReferenceValue(string moduleName, string defName, string variantID = "")
    {
        return null;
    }

    public List<ItemValue> GetReferenceValues(string defName, string moduleName = "", string variantID = "")
    {
        return null;
    }

    public string GetStartOfDbToc()
    {
        return "";
    }

    public string GetVersionInformation(string name, string module = "")
    {
        return "";
    }

    public BaseIntermediateItem GetVersionInformation()
    {
        return null;
    }

    public bool IsExistedPath(string path, string moduleName = "")
    {
        return true;
    }

    public bool IsExistModuleName(string moduleName)
    {
        return true;
    }

    public bool IsRegisterExist(string renesasMacroDefinition)
    {
        return true;
    }

    public void PrepareInstance(int instanceIndex)
    {

    }

    public bool CheckVariantParameterSupported(string moduleName, string parameterName)
    {
        return true;
    }

    public bool CheckVariantContainerSupported(string moduleName, string containerName)
    {
        return true;
    }
    public List<string> GetAllVariantConfiguration(string moduleName)
    {
        return null;
    }
    public Dictionary<string, string> GetShortNameVariantConfig(string moduleName)
    {
        return null;
    }
}


public class BasicConfigurationTest : IBasicConfiguration
{
    public string VendorApiInfix { get; set; } = "";
    public int NumberOfInstances { get; set; } = 0;
    public bool MultiInstanceWithInfix { get; set; } = false;
    public string ModuleName { get; set; } = "can";
    public string MicroFamilyName { get; set; }
    public string AutoSARVersion { get; set; } = "4.2.2";
    public List<string> DeviceNames { get; set; }
    public int VendorId { get; set; }
    public string ExeDirectory { get; set; }
    public int ModuleId { get; set; }
    public string OutputFolder { get; set; }
    public string ExecutionName { get; set; }
    public string ExecutionVersion { get; set; }
    public List<string> ModuleRequired { get; set; }
    public string ProjectTitle { get; set; }
    public int InstanceIndex { get; set; }
    public bool HasInstanceSetting { get; set; }
    public InstanceOutputType InstanceOutType { get; set; } = InstanceOutputType.DEFAULT;
    public string DeviceVariant { get; set; }
    public string AppendInstanceToFileName(string fileName)
    {
        return "";
    }

    public string ToInstanceValue(AppendType type = AppendType.FULL_UPPER)
    {
        return "";
    }
    public string AppendInstanceToMacro(string name , AppendType type = AppendType.FULL_UPPER)
    {
        return "";
    }

}
public class UserInterfaceClassTest : IUserInterface
{
    public int ErrorCount => 0;

    public int WarningCount => 0;

    public void Error(int moduleId, int errorCode, string message, params object[] parameters)
    {
    }

    public void ErrorFileNotFound(string fileName)
    {
    }

    public void ErrorModuleNotFound()
    {
    }

    public void Exit()
    {
    }

    public void Exit(int exitCode)
    {
    }

    public void Info(int moduleId, int errorCode, string message, params object[] parameters)
    {
    }

    public void InfoErrorCode(int errorcode)
    {
    }

    public StreamWriter OpenFile(string path)
    {
        return null;
    }

    public void Warn(int moduleId, int errorCode, string message, params object[] parameters)
    {
    }
}