using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Consumable
{
    public float saturation;

    public override void Consume()
    {
        if(usesLeft > 0)
        {
            usesLeft--;
            Debug.Log("You consumed " + itemName + " and you gained " + saturation + " saturation, you now have " + usesLeft + " uses left");
        } else
        {
            Debug.Log("You have no uses left of that item");
        }

        base.Consume();
    }

    private void Start()
    {
        usesLeft = maxUses;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Consume();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(itemName + " costs " + GetPricePerWeight(weight, priceValue) + " per weight");
        }
    }
}
