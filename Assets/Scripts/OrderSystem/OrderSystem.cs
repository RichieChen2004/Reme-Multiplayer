using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OrderSystem : MonoBehaviour
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
}
