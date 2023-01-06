using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] materials;

    public void Red() {
        foreach (Renderer material in materials) {
            material.material.color = colors[0];
        }
    }

    public void Black() {
        foreach (Renderer material in materials) {
            material.material.color = colors[1];
        }
    }

    public void Blue() {
        foreach (Renderer material in materials) {
            material.material.color = colors[2];
        }
    }

    public void Yellow() {
        foreach (Renderer material in materials) {
            material.material.color = colors[3];
        }
    }
}
