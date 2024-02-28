using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pepper : Vegetable
{
    public Pepper()
    {
        Debug.Log("1st Pepper Constructor Called");
    }

    //These methods are overrides and therefore
    //can override any virtual methods in the parent
    //class.
    public override void Chop()
    {
        base.Chop();
        Debug.Log("The Pepper has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am a Pepper.");
    }
}
