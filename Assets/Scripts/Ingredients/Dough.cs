using UnityEngine;

public class Dough : Ingredient
{
    public Dough()
    {
        name = "Dough";
    }
    public override Ingredient improveIngredient()
    {
        return this; 
    }

    public override void useIngredient()
    {
        Debug.Log("Using dough.");
    }

    public override Ingredient GetIngredient()
    {
        return new Dough();
    }
}
