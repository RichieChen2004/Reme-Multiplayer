using UnityEngine;

public class DoughStorage : Storage
{
    public override Ingredient getIngredient()
    {
        return new Dough(); 
    }
}
