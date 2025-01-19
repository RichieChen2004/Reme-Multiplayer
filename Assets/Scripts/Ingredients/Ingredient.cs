using UnityEngine;

[System.Serializable]
public abstract class Ingredient : MonoBehaviour
{
    public abstract Ingredient improveIngredient();
    public abstract void useIngredient();
}