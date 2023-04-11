using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atoms : MonoBehaviour
{
    private int atoms;
    public Text atomCount;
    public Slider atomSlider;

    public void AtomCollected()
    {
        atoms++;
        atomCount.text = "Atoms: " + atoms.ToString() + "/5";
        atomSlider.value = atoms;
    }
}
