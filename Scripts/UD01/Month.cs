using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Create the variable to get the number you want to know the month
    public int monthNumber;

    // Start is called before the first frame update
    void Start()
    {
        //Call the method to get the name of each month
        string monthName = GetMonthName(monthNumber);
        Debug.Log(monthName);
    }

    //Method to get the name for each month
    string GetMonthName(int month)
    {
        switch (month) 
        {
            case 1: return "January";
            case 2: return "February";
            case 3: return "March";
            case 4: return "April";
            case 5: return "May";
            case 6: return "June";
            case 7: return "July";
            case 8: return "August";
            case 9: return "September";
            case 10: return "October";
            case 11: return "November";
            case 12: return "December";
            default: return "Invalid number";
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
