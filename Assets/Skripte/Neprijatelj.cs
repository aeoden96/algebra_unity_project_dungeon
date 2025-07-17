using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neprijatelj : MonoBehaviour {

    public int zivoti;
    public float brzina;
    //[HideInInspector]
    public Transform igrac;
    public int steta;
    public float vrijemeIzmeduNapada;
    public GameObject efektSmrti;

    private void Start() {
        igrac = GameObject.FindWithTag("Igrac").transform;
    }

    public void PrimiStetu(int kolicinaStete) {
        zivoti -= kolicinaStete;   //zivoti = zivoti - kolicinaStete;
        if (zivoti <= 0) {
            Instantiate(efektSmrti, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
