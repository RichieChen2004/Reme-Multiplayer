using UnityEngine;

public class Dough : Ingredient
{
    public override Ingredient improveIngredient()
    {
        return this; 
    }

    public override void useIngredient()
    {
        Debug.Log("Using dough.");
    }
}
