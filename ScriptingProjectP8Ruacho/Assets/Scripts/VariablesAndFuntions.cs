using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFuntions : MonoBehaviour
{
    //Create a variable of type interger
    int myInt = 10;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run myInt thru my function to multiply it by two
        myInt = MultiplyByTwo(myInt);

        //i'M Going to print the reusluts to the console
        Debug.Log(myInt);

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    //Creating a function that takes a int parameter and multiplies it by 2
    int MultiplyByTwo(int number)
    {
        //Creating a variable to store my results
        int results;
        //multiplying the passed parameter by 2
        results = number * 2;

        //Returning the results 
        return results;
    } 
}
