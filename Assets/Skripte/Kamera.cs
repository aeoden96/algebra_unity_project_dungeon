using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {

    public Transform igrac;
    public float brzina;
    public float minX, maxX, minY, maxY;

    private void LateUpdate() {
        if (igrac != null) {
            transform.position = Vector2.Lerp(transform.position, igrac.position, brzina * Time.deltaTime);
        }
    }

}
