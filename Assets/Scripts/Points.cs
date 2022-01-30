using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    float pts = 0f;
    public Text scoreText;

    void Update()
    {
        pts += 50 * Time.deltaTime;
        Debug.Log(pts);
    }
}