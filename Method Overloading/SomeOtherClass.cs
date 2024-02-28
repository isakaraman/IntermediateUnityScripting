using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    
    void Start()
    {
        SomeClass someClass = new SomeClass();
        someClass.Add(1, 2);
        someClass.Add("Hello", "World");
    }
}
