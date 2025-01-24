using UnityEngine;

[System.Serializable]
public class Storage : Interactable
{
    public GameObject ingredient;

    public void getIngredient(Collider2D other)
    {
        other.GetComponent<PlayerController>().heldIngredient = ingredient.GetComponent<Ingredient>();
    }

    public override void executeAction(PlayerController player)
    {
        if (ingredient != null)
        {
            player.heldIngredient = ingredient.GetComponent<Ingredient>();
            Debug.Log("Picked up " + ingredient.name + "!");
        }
    }
}
