using UnityEngine;

public class MeatStorage : Storage
{
    public override Ingredient getIngredient()
    {
        Debug.Log("Picked up Meat!");
        return new Meat(); 
    }
}
