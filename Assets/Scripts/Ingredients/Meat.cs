using UnityEngine;

public class Meat : Ingredient
{
    public override Ingredient improveIngredient()
    {
        return this; 
    }

    public override void useIngredient()
    {
        Debug.Log("Using meat.");
    }
}
