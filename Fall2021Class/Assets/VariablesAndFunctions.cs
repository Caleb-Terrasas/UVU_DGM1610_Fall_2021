using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myINt = 5;

    void Start ()
    {
        myInt = MultiplyByTwo(myINt);
        Debug.Log (myInt);
    }


    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
