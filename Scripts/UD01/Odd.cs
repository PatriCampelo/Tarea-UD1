using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string odds = "";
        for (int i = 1; i < 100; i += 2)
        {
            odds += i + " ";
        }
        Debug.Log("Odd numbers betwen 0 and 100: " + odds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
