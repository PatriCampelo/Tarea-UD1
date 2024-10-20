using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string evens = "";
        for (int i = 0; i <= 100; i += 2)
        {
            evens += i + " ";
        }
        Debug.Log("Even numbers betwen 0 y 100: " + evens);
    }
}
