using UnityEngine;

public class Meat : Ingredient
{
    public Meat()
    {
        name = "Meat";
    }
    public override Ingredient improveIngredient()
    {
        return new CookedMeat(); 
    }

    public override void useIngredient()
    {
        Debug.Log("Using meat.");
    }
    public override Ingredient GetIngredient()
    {
        return new Meat();
    }
}
