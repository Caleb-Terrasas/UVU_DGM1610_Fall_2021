using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    Array.Sort(cars);
    foreach (string i in cars)
    {
        Console.Writeline(i);
    }
}
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in cars)
    {
        Console.Writeline(i);
    }
}
