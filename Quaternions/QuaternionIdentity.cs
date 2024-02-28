using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionIdentity : MonoBehaviour
{
    void Start()
    {
        transform.rotation = Quaternion.identity;
    }
}
