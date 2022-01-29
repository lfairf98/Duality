using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float pts = 0f;
 
    void Update()
    {
        pts += 50 * Time.deltaTime;
        Debug.Log(pts);
    }
}