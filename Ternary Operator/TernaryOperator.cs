using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    int x = 10;
    string message;

    private void Start()
    {
        message = x > 0 ? "health below 0" : x==0 ? "health is 0" : "health under 0";
        
    }
}
