using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {
    public Light lamp;

    bool switchedOn = false;
    float _intensity;

    private void Awake()
    {
        _intensity = lamp.intensity;
        if (!switchedOn)
            lamp.intensity = 0f;
    }

    public void ToggleSwitch()
    {
        switchedOn = !switchedOn;
        if (switchedOn)
        {
            lamp.intensity = _intensity;
        }
        else
        {
            lamp.intensity = 0f;
        }
    }
}
