using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    //Create an array for the 3 numbers
    public int[] numbers = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        //Use System.Array.Sort to order the numbers smallest to largest
        System.Array.Sort(numbers);

        //Use System.Array.Reverse to reverse the order (largest to smallest)
        System.Array.Reverse(numbers);
        Debug.Log("Numbers in order from largest to smallest: " + string.Join(", ", numbers));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
