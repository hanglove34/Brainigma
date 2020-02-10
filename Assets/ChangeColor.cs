using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGoodColor = false;
    public Light mylight;
    private GameObject lights;

    private Color whiteLight;
    private Color greenLight;
    private Color blueLight;
    private Color redLight;

    private Color goodLight;
    private int stepLight = 0;

    void Start()
    {
        lights = GameObject.Find("Spotlight_white");
        whiteLight = lights.GetComponent<Light>().color;

        lights = GameObject.Find("Spotlight_blue");
        blueLight = lights.GetComponent<Light>().color;

        lights = GameObject.Find("Spotlight_red");
        redLight = lights.GetComponent<Light>().color;

        lights = GameObject.Find("Spotlight_green");
        greenLight = lights.GetComponent<Light>().color;

        switch (this.gameObject.name)
        {
            case "lampRoom_white":
                goodLight = whiteLight;
                break;
            case "lampRoom_green":
                goodLight = greenLight;
                break;
            case "lampRoom_red":
                goodLight = redLight;
                break;
            case "lampRoom_blue":
                goodLight = blueLight;
                break;
            default:
                break;
        }

        mylight.color = whiteLight;


    }

    // Update is called once per frame
    void Update()
    {
        switch (stepLight)
        {
            case 0:
                mylight.color = whiteLight;
                break;
            case 1:
                mylight.color = greenLight;
                break;
            case 2:
                mylight.color = redLight;
                break;
            case 3:
                mylight.color = blueLight;
                break;
            default:
                break;
        }

        if (mylight.color == goodLight)
        {
            isGoodColor = true;
        }
        else
        {
            isGoodColor = false;
        }
    }
    void OnMouseDown()
    {
        if (stepLight <= 3)
            stepLight += 1;
        if (stepLight == 4)
            stepLight = 0;

    }

}
