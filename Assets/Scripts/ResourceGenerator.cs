using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    int amt = 25;
    private void OnMouseDown()
    {
        CoinScript adder = FindObjectOfType<CoinScript>();
        adder.addcoins(amt);
        Destroy(gameObject);
    }
}
