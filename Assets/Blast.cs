using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour {
    public GameObject afterhit1;
    public GameObject afterhit2;
    public GameObject afterhit3;
    public GameObject bronze;
    public Collider collider;
    public GameObject particle;
    private int hitTime = 0;
	// Use this for initialization
	void Start () {
        particle.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if(hitTime == 1)
        {
            afterhit1.SetActive(false);
        }
        if (hitTime == 2)
        {
            afterhit2.SetActive(false);
        }
        if (hitTime == 3)
        {
            afterhit3.SetActive(false);
        }
        if (hitTime >= 3)
        {
            bronze.transform.Translate(new Vector3(0.0f, 0.01f, 0.0f));
            bronze.GetComponent<Rigidbody>().isKinematic = false;
            bronze.GetComponent<Rigidbody>().useGravity = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("axe"))
        {
            particle.SetActive(false);
            particle.SetActive(true);

            hitTime++;
        }
    }
}
