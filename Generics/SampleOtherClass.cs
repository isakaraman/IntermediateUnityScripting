using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleOtherClass : MonoBehaviour
{
    void Start()
    {
        SampleClass myClass = new SampleClass();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}
