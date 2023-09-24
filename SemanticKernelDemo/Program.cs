using System.Text.Json;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Planning;

using Math = SemanticKernelDemo.plugins.MathPlugin.Math;


var kernel = new KernelBuilder().WithCompletionService().Build();

var pluginsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "plugins");
var foodPlugin = kernel.ImportSemanticSkillFromDirectory(pluginsDirectory, "FoodPlugin");

var query = "adobo";
var recipe = await kernel.RunAsync(query, foodPlugin["DishRecipe"]);
Console.WriteLine("Recipe helper results:");
Console.WriteLine(recipe);


kernel.ImportSkill(new Math(), "MathPlugin");

var planner = new SequentialPlanner(kernel);

var ask = "My monthly gross salary is 9000 USD and the tax is 35 percent, how much would I have every month if I have a monthly food cost of 1300 USD and 900 USD for rent?";
var plan = await planner.CreatePlanAsync(ask);

/*  AI plans are to multiply first (9000 x 0.35), 
    then subtract (9000 - 3150), 
    then add (1300 + 900), 
    then subtract (5850 - 2200).
    Check the serialized object in console logs to see the whole plan. */
Console.WriteLine("Plan object:\n");
Console.WriteLine(JsonSerializer.Serialize(plan, new JsonSerializerOptions { WriteIndented = true }));

var result = (await kernel.RunAsync(plan)).Result;

Console.WriteLine("Plan results:");
Console.WriteLine(result.Trim());