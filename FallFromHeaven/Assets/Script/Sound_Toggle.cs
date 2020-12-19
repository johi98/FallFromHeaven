using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Toggle : MonoBehaviour
{
    public AudioSource bgm;
    public GameObject v;
    public void PanelControl(Toggle toggletest)
    {
        if (toggletest.isOn)
        {
            bgm.Play();
            v.SetActive(true);
        }
        else
        {
            bgm.Stop();
            
            v.SetActive(false);
        }

    }
}
