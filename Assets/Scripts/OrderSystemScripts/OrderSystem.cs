using UnityEngine;
using System.Collections.Generic;

public class OrderSystem : MonoBehaviour
{

    public float orderFrequency = 5f;
    public List<Order> availableOrders;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Order createOrder(List<Ingredient> Ingredients)
    {
        return new Order(Ingredients);
    }
}
