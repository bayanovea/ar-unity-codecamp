using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject cube;

    VirtualButtonBehaviour vbutton;

    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false);

        vbutton = GetComponentInChildren<VirtualButtonBehaviour>();

        vbutton.RegisterOnButtonPressed(onButtonPressed);
        vbutton.RegisterOnButtonReleased(onButtonReleased);
    }

    void onButtonPressed(VirtualButtonBehaviour vbutton) {
        cube.SetActive(true);
    }

    void onButtonReleased(VirtualButtonBehaviour vbutton) {
        cube.SetActive(false);
    }
}
