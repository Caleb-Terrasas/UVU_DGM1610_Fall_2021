using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.Writeline(i);
                i++;
            }
        }
    }
}
