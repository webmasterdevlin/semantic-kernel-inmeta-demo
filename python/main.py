import config.add_completion_service
import semantic_kernel as sk
from plugins.MathPlugin.Math import Math
from semantic_kernel.planning.basic_planner import BasicPlanner


async def main():
    kernel = sk.Kernel()
    kernel.add_completion_service()

    plugins_directory = "./plugins"
    food_plugin = kernel.import_semantic_skill_from_directory(plugins_directory, "FoodPlugin")

    query = "bulalo"
    recipe = await kernel.run_async(food_plugin["DishRecipe"], input_str=query)
    print("Recipe helper results:")
    print(recipe)


    kernel.import_skill(Math(), "MathPlugin")

    ask = "My monthly gross salary is 9000 USD and the tax is 35 percent, how much would I have every month if I have a monthly food cost of 1300 USD and 900 USD for rent?";
    planner = BasicPlanner()
    plan = await planner.create_plan_async(ask, kernel)
    result = await planner.execute_plan_async(plan, kernel)
    print("Plan results:")
    print(result)


# Run the main function
if __name__ == "__main__":
    import asyncio

    asyncio.run(main())
