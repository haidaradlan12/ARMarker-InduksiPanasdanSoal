using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public GameObject BMute, BUnmute;
    public GameObject BMute1, BUnmute1;
    public GameObject BMute2, BUnmute2;
    public GameObject BMute3, BUnmute3;
    public GameObject BMute4, BUnmute4;
    public GameObject BMute5, BUnmute5;
    public GameObject BMute6, BUnmute6;
    public GameObject BMute7, BUnmute7;
    public GameObject BMute8, BUnmute8;
    public GameObject BMute9, BUnmute9;
    public GameObject BMute10, BUnmute10;
    public GameObject BMute11, BUnmute11;
    public GameObject BMute12, BUnmute12;
    public GameObject BMute13, BUnmute13;
    public GameObject BMute14, BUnmute14;
    public GameObject BMute15, BUnmute15;
    public GameObject BMute16, BUnmute16;
    public GameObject BMute17, BUnmute17;
    public GameObject BMute18, BUnmute18;
    int h;
    // Start is called before the first frame update
    void Start()
    {
        h = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (h==1) //klik tombol Unmute
        {
            BMute.SetActive(true);
            BMute1.SetActive(true);
            BMute2.SetActive(true);
            BMute3.SetActive(true);
            BMute4.SetActive(true);
            BMute5.SetActive(true);
            BMute6.SetActive(true);
            BMute7.SetActive(true);
            BMute8.SetActive(true);
            BMute9.SetActive(true);
            BMute10.SetActive(true);
            BMute11.SetActive(true);
            BMute12.SetActive(true);
            BMute13.SetActive(true);
            BMute14.SetActive(true);
            BMute15.SetActive(true);
            BMute16.SetActive(true);
            BMute17.SetActive(true);
            BMute18.SetActive(true);

            BUnmute.SetActive(false);
            BUnmute1.SetActive(false);
            BUnmute2.SetActive(false);
            BUnmute3.SetActive(false);
            BUnmute4.SetActive(false);
            BUnmute5.SetActive(false);
            BUnmute6.SetActive(false);
            BUnmute7.SetActive(false);
            BUnmute8.SetActive(false);
            BUnmute9.SetActive(false);
            BUnmute10.SetActive(false);
            BUnmute11.SetActive(false);
            BUnmute12.SetActive(false);
            BUnmute13.SetActive(false);
            BUnmute14.SetActive(false);
            BUnmute15.SetActive(false);
            BUnmute16.SetActive(false);
            BUnmute17.SetActive(false);
            BUnmute18.SetActive(false);
        }
        else if (h==0) //klik tombol Mute
        {
            BMute.SetActive(false);
            BMute1.SetActive(false);
            BMute2.SetActive(false);
            BMute3.SetActive(false);
            BMute4.SetActive(false);
            BMute5.SetActive(false);
            BMute6.SetActive(false);
            BMute7.SetActive(false);
            BMute8.SetActive(false);
            BMute9.SetActive(false);
            BMute10.SetActive(false);
            BMute11.SetActive(false);
            BMute12.SetActive(false);
            BMute13.SetActive(false);
            BMute14.SetActive(false);
            BMute15.SetActive(false);
            BMute16.SetActive(false);
            BMute17.SetActive(false);
            BMute18.SetActive(false);

            BUnmute.SetActive(true);
            BUnmute1.SetActive(true);
            BUnmute2.SetActive(true);
            BUnmute3.SetActive(true);
            BUnmute4.SetActive(true);
            BUnmute5.SetActive(true);
            BUnmute6.SetActive(true);
            BUnmute7.SetActive(true);
            BUnmute8.SetActive(true);
            BUnmute9.SetActive(true);
            BUnmute10.SetActive(true);
            BUnmute11.SetActive(true);
            BUnmute12.SetActive(true);
            BUnmute13.SetActive(true);
            BUnmute14.SetActive(true);
            BUnmute15.SetActive(true);
            BUnmute16.SetActive(true);
            BUnmute17.SetActive(true);
            BUnmute18.SetActive(true);
        }
    }

    public void Hidup()
    {
        h = 0;
    }
    public void Mati()
    {
        h = 1;
    }
}
