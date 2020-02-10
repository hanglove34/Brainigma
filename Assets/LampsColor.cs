using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampsColor : MonoBehaviour
{
    public bool isResolve = false;

    public GameObject rightDoor;
    public GameObject leftDoor;

    private GameObject whiteLight;
    private GameObject greenLight;
    private GameObject blueLight;
    private GameObject redLight;

    private bool white = false;
    private bool green = false;
    private bool blue = false;
    private bool red = false;

    void Start()
    {
        whiteLight = GameObject.Find("lampRoom_white");
        greenLight = GameObject.Find("lampRoom_green");
        blueLight = GameObject.Find("lampRoom_blue");
        redLight = GameObject.Find("lampRoom_red");


    }

    // Update is called once per frame
    void Update()
    {
        white = whiteLight.GetComponent<ChangeColor>().isGoodColor;
        green = greenLight.GetComponent<ChangeColor>().isGoodColor;
        blue = blueLight.GetComponent<ChangeColor>().isGoodColor;
        red = redLight.GetComponent<ChangeColor>().isGoodColor;
        if (white && green && blue && red)
        {
            isResolve = true;
        }
        else
        {
            isResolve = false;
        }

        if (isResolve)
        {
            if (leftDoor.transform.localPosition.x > -5.3)
                leftDoor.transform.localPosition -= transform.right * Time.deltaTime;
            if (rightDoor.transform.localPosition.x < 5.3)
                rightDoor.transform.localPosition += transform.right * Time.deltaTime;
        }
    }
}