using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class moving : MonoBehaviour
{


    private void Start()
    {
    }
    int goodDegs = 1; // degrees per second
    int badDegs = -1; // degrees per second


    void LateUpdate()
    {
        if (Input.GetKey("left") || (Input.GetKey("a")))
        {
            for (var n = 0; n < 90; n++)
            {
                transform.Rotate(0, badDegs * Time.deltaTime, 0);
            }
        }
        if (Input.GetKey("right") || (Input.GetKey("d")))
        {
            for (var m = 0; m < 90; m++)
            {
                transform.Rotate(0, goodDegs * Time.deltaTime, 0);
            }
        }
        if (Input.GetKey("up") || (Input.GetKey("w")))
        {
            for (var m = 0; m < 90; m++)
            {
                transform.Rotate(badDegs * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetKey("down") || (Input.GetKey("s")))
        {
            for (var m = 0; m < 90; m++)
            {
                transform.Rotate(goodDegs * Time.deltaTime, 0, 0);
            }
        }
    }
}