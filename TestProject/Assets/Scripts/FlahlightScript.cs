using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlahlightScript : MonoBehaviour
{
    [SerializeField]
    private GameObject playerlight;

    [SerializeField]
    private bool isOn;

    private new Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = playerlight.GetComponent<Light>();
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flashlight"))
        {
            isOn = !isOn;
        }
        if (isOn == true)
        {
            light.enabled = true;
        }
        else
        {
            light.enabled = false;
        }
    }
}
