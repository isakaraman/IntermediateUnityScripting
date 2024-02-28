using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetable : MonoBehaviour
{
    public Vegetable()
    {
        Debug.Log("1st Vegetable Constructor Called");
    }

    //These methods are virtual and thus can be overriden
    //in child classes
    public virtual void Chop()
    {
        Debug.Log("The vegetable has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a vegetable.");
    }
}
