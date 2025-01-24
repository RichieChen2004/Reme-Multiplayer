using UnityEngine;

[System.Serializable]
public abstract class Interactable : MonoBehaviour
{
    public abstract void executeAction(PlayerController player);
}
