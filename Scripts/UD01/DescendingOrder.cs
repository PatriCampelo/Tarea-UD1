using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    //Create an array to put the 3 numbers
    public int[] numbers = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        //Use bool to know if it is true ef the numbers were introduce in descending order 
        bool isDescending = numbers[0] > numbers[1] && numbers[1] > numbers[2];
        Debug.Log("Numbers in descending order? " + isDescending);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
