using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    int day = 2;
    switch (day)
    {
        case 1:
            Console.Writeline("Monday");
            break;
        case 2: 
            Console.Writeline("Tuesday");
            break;
    }
}
