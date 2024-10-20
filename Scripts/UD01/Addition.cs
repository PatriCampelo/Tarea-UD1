using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
        Debug.Log("The sum of the numbers from 1 to " + number + " is: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
