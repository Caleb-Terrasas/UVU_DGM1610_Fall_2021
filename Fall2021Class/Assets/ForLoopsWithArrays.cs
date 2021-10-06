using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in cars)
    {
        Console.Writeline(i);
    }
}
static void Main(string[] args)
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    for (int i = 0; i < cars.Length; i++)
    {
        Console.Writeline(cars[i]);
    }
}