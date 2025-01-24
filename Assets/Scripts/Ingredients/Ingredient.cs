using UnityEngine;

[System.Serializable]
public abstract class Ingredient : MonoBehaviour
{
    public new string name;
    public abstract Ingredient improveIngredient();
    public abstract void useIngredient();
    public abstract Ingredient GetIngredient();
}