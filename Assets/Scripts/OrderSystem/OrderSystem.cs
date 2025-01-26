using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OrderSystem : Interactable
{
    public float orderFrequency = 5f; // Frequency in seconds to add a new order
    public List<Order> availableOrders; 
    public List<Order> currentOrders; 

    public void Start()
    {
        // Start the coroutine to add orders at regular intervals
        StartCoroutine(AddOrdersCoroutine());
    }

    IEnumerator AddOrdersCoroutine()
    {
        while (true) // Infinite loop to continuously add orders
        {
            yield return new WaitForSeconds(orderFrequency); // Wait for the specified frequency

            AddRandomOrder(); // Add a random order
        }
    }

    public void AddRandomOrder()
    {
        Debug.Log("Adding");
        if (availableOrders.Count == 0)
        {
            Debug.LogWarning("No available orders to add!");
            return;
        }

        // Pick a random order from availableOrders
        int randomIndex = Random.Range(0, availableOrders.Count);
        Order randomOrder = availableOrders[randomIndex];

        // Add the new order to currentOrders
        currentOrders.Add(randomOrder);

        Debug.Log("Added a new order to currentOrders.");
    }

    public override void executeAction(PlayerController player)
    {  
        // Ensure player has held item
        if (player.heldIngredient != null)
        {
            Debug.Log("Player is holding an item");
            for (int i = 0; i < currentOrders.Count; i++)
            {
                // Check if the player is holding the correct plate for the order
                // Shit way of doing this maybe change if optimisations needed
                if (currentOrders[i].isOrderComplete(player.heldIngredient))
                {
                    currentOrders.Remove(currentOrders[i]);
                    break; 
                }
            }
        }
        else{
            Debug.LogWarning("you dont have anything lol");
        }
        Debug.Log("Intereact");
    }

    // public void completeOrder(Order order)
    // {
    //     // Remove the order from currentOrders
    //     currentOrders.Remove(order);

    //     Debug.Log("Completed order");
    // }
}
