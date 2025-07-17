using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trkac : Neprijatelj {

    public float stopUdaljenost;
    float vrijemeNapada;
    public float brzinaAnimacije;

    private void Update() {
        if (igrac != null) {
            if (Vector2.Distance(transform.position, igrac.position) > stopUdaljenost) {
                transform.position = Vector2.MoveTowards(transform.position, igrac.position, brzina * Time.deltaTime);
            } else {
                if (Time.time >= vrijemeNapada) {
                    vrijemeNapada = Time.time + vrijemeIzmeduNapada;
                    Debug.Log("NAPAAAAAAD!");
                    igrac.gameObject.GetComponent<Igrac>().PrimiStetu(steta);
                    //igrac.GetComponent<Igrac>().PrimiStetu(steta);  -> može i ovako
                }
            }
        }
    }
}
