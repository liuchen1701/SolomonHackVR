using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellowsInteraction : MonoBehaviour
{
    public AudioClip c;
    public OVRInput.Controller con;

    public ParticleSystem ps;
    private int fireCounter;
    // Use this for initialization
    void Start()
    {
        ps = GetComponent<ParticleSystem>();

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Bellows")
        {
            if (con == OVRInput.Controller.LTouch)
                OVRHaptics.Channels[0].Mix(new OVRHapticsClip(c)); fireCounter++;

            if (con == OVRInput.Controller.RTouch)
                OVRHaptics.Channels[1].Mix(new OVRHapticsClip(c)); fireCounter++;


            //if(fireCounter == 1)
            //{
              //  ps.emm

            //}

            //OVRHapticsClip vibrate = new OVRHapticsClip(100);
            //for (int i = 0; i < 100; i++)
            //{
            //    vibrate.Samples[i] = i % 2 == 0 ? (byte)0 : (byte)255;
            //}
            //vibrate = new OVRHapticsClip(vibrate.Samples, vibrate.Samples.Length);

            //var channel = OVRHaptics.RightChannel;
            //if (controllerMask == OVRInput.Controller.LTouch)
            //    channel = OVRHaptics.LeftChannel;

            //print("vib");

            //channel.Preempt(vibrate);
        }
    }

    
}
