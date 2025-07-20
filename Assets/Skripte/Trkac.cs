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
                    StartCoroutine(Napad());
                    igrac.gameObject.GetComponent<Igrac>().PrimiStetu(steta);
                    //igrac.GetComponent<Igrac>().PrimiStetu(steta);  -> može i ovako
                }
            }
        }
    }

    IEnumerator Napad() {
        Vector2 pocetnaPozicija = transform.position;
        Vector2 krajnjaPozicija = igrac.position;

        float postotak = 0;
        while (postotak <= 1) {
            postotak += Time.deltaTime * brzinaAnimacije;
            float t = (-postotak * postotak + postotak) * 4;
            transform.position = Vector2.Lerp(pocetnaPozicija, krajnjaPozicija, t);
            yield return null;   //zaustavi izvođenje korutine i nastavi u idućem frejmu
        }
    }
}
