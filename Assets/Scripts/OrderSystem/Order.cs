using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Order : MonoBehaviour
{
    public List<Ingredient> ingredients = new List<Ingredient>();

    public bool isOrderComplete(Ingredient heldIngredient)
    {
        // Loop through ingredients
        foreach (var ingredient in ingredients)
        {
            // Check if the player is holding the correct ingredient for the order
            if (ingredient == heldIngredient)
            {
                // Return true if the order is complete
                return true;
            }
        }
        
        // Return false if no matching ingredient is found
        return false;
    }

    public void getOrder()
    {
        // Implementation for getOrder
    }
}