using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projektil : MonoBehaviour {

    public float brzina;
    public int steta;
    public float vrijemeTrajanja;
    public GameObject cesticeEksplozija;

    private void Start() {
        Invoke(nameof(UnistavanjeProjektila), vrijemeTrajanja);
    }

    void UnistavanjeProjektila() {
        Instantiate(cesticeEksplozija, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void Update() {
        transform.Translate(Vector2.up * brzina * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        //ako projektil udari neprojatelja, uništi projektil i zadaj štetu neprijatelju
        if (collision.tag == "Neprijatelj") {
            //zadaj štetu neprijatelju
            Destroy(gameObject);
        }
    }
}
