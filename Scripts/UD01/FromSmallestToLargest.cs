using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Create an array for the 3 numbers
    public int[] numbers = new int[3];


    // Start is called before the first frame update
    void Start()
    {
        //Use System.Array.Sort to order the numbers from smallest to largest
        System.Array.Sort(numbers);
        Debug.Log("Numbers in order from smallest to largest: " + string.Join(", ", numbers));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
