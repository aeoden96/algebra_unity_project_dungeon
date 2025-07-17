using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {

    public Transform igrac;
    public float brzina;
    public float minX, maxX, minY, maxY;

    float ograniceniX;
    float ograniceniY;
    Vector2 kretanjeKamere;

    private void LateUpdate() {
        if (igrac != null) {
            ograniceniX = Mathf.Clamp(igrac.position.x, minX, maxX);
            ograniceniY = Mathf.Clamp(igrac.position.y, minY, maxY);
            kretanjeKamere = new Vector2(ograniceniX, ograniceniY);
            //Debug.Log(oganiceniX + ", " + oganiceniY);
            transform.position = Vector2.Lerp(transform.position, kretanjeKamere, brzina * Time.deltaTime);
        }
    }

}
