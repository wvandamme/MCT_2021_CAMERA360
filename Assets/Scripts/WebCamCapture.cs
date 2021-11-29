using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamCapture : MonoBehaviour
{

    public uint webcamid = 0;

    // Start is called before the first frame update
    void Start()
    {
        WebCamTexture LiveTexture = new WebCamTexture();
        WebCamDevice[] devices = WebCamTexture.devices;

        for (uint i = 0; i < devices.Length; ++i)
        {
            Debug.Log("Webcam: " + i + " Name: " + devices[i].name);
        }


        if (devices.Length > webcamid)
        {
            LiveTexture.deviceName = devices[webcamid].name;
            LiveTexture.Play();
        }
        GetComponent<Renderer>().material.mainTexture = LiveTexture;
    }

}
