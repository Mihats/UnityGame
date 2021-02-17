using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Dead : MonoBehaviour
{
     public GameObject respawn;
    private void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4014701", false);
        }
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show("Interstitial_Android");
            }
            other.transform.position = respawn.transform.position;
        }
    }
}
