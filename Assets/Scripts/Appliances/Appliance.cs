[System.Serializable]
public class Appliance : Interactable
{
    public bool canUseIngredient(Ingredient ingredient) {
        return false;
    }
    public override void executeAction(PlayerController player) {
        return;
    }
}