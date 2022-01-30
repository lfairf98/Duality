using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    int pts = 0;
    float ptsDecimal;
    public Text scoreText;

    void Update()
    {
        ptsDecimal += 50 * Time.deltaTime;
;       pts = Mathf.RoundToInt(ptsDecimal);
        
        scoreText.text = pts.ToString();
        Debug.Log(pts);
    }
}