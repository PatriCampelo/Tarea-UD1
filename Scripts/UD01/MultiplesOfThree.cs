using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string multiples = "";
        for (int i = 0; i <= 100; i += 3)
        {
            multiples += i + " ";
        }
        Debug.Log("Multiples of 3 betwen 0 and 100: " + multiples);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
