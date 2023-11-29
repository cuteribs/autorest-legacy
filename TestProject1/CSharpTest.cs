using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.CSharp;
using AutoRest.CSharp.Model;
using AutoRest.Modeler;

namespace TestProject1;

public class CSharpTest
{
	[Fact]
	public void Test1()
	{
		var path = @"C:\git\dnv\ApiClients\assets\DataValidatorApi.json";
		var swagger = File.ReadAllText(path);
		var serviceDefinition = SwaggerParser.Parse(swagger);
		var modeler = new SwaggerModeler();
		var codeModelT = modeler.Build(serviceDefinition);
		Assert.NotNull(codeModelT);

		var codeModel = new CodeModelCs();
		codeModel.AddRange(codeModelT.EnumTypes.Select(x => {
			var result = new EnumTypeCs();
			result.SetName(x.Name.FixedValue);
			return result;
		}));

		var gen = new CodeGeneratorCs();
		gen.Generate(codeModel);
	}
}
