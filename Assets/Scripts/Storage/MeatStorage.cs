using UnityEngine;

public class MeatStorage : Storage
{
    public override Ingredient getIngredient()
    {
        return new Meat(); 
    }
}
