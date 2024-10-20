using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string multiples = "";
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                multiples += i + " ";
            }
        }
        Debug.Log("Multiples of 3 and 2 betwen 0 and 100: " + multiples);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
