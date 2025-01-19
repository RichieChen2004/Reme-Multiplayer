using UnityEngine;

public class DoughStorage : Storage
{
    public override Ingredient getIngredient()
    {
        Debug.Log("Picked up Dough!");
        return new Dough(); 
    }
}
