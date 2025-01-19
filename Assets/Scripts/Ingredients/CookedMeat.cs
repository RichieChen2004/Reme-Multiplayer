using UnityEngine;

public class CookedMeat : Ingredient
{
    public override Ingredient improveIngredient()
    {
        return this; 
    }

    public override void useIngredient()
    {
        Debug.Log("Using cooked meat.");
    }
}
