using UnityEngine;

public class CookedMeat : Ingredient
{
    public CookedMeat()
    {
        name = "Cooked Meat";
    }
    public override Ingredient improveIngredient()
    {
        return this; 
    }

    public override void useIngredient()
    {
        Debug.Log("Using cooked meat.");
    }

    public override Ingredient GetIngredient()
    {
        return new CookedMeat();
    }
}
