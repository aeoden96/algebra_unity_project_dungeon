using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Neprijatelj : MonoBehaviour {

    public int zivoti;  //20
    public float brzina;
    //[HideInInspector]
    public Transform igrac;
    public int steta;
    public float vrijemeIzmeduNapada;
    public GameObject efektSmrti;

    public Slider slajderHP;

    private void Start() {
        igrac = GameObject.FindWithTag("Igrac").transform;
        slajderHP.gameObject.SetActive(false);
        slajderHP.maxValue = zivoti;
        slajderHP.value = zivoti;
    }

    public void PrimiStetu(int kolicinaStete) {
        zivoti -= kolicinaStete;   //zivoti = zivoti - kolicinaStete;
        Debug.Log(zivoti);
        slajderHP.gameObject.SetActive(true);
        slajderHP.value = zivoti;
        if (zivoti <= 0) {
            Instantiate(efektSmrti, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
