using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oruzje : MonoBehaviour {
    public GameObject projektil;
    public GameObject cesticeIspucavanje;
    public Transform mjestoIspucavanja;
    public float brzinaIspucavanja;
    float vrijemeIspucavanja;

    private void Update() {
        Vector2 smjer = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float kut = Mathf.Atan2(smjer.y, smjer.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, kut - 90);

        if (Input.GetMouseButton(0)) {
            if (Time.time >= vrijemeIspucavanja) {
                vrijemeIspucavanja = Time.time + brzinaIspucavanja;
                Instantiate(projektil, mjestoIspucavanja.position, transform.rotation);
                Instantiate(cesticeIspucavanje, mjestoIspucavanja.position, transform.rotation);
            }
        }
    }

}
