using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnistiMe : MonoBehaviour {

    public float trajanje;

    private void Start() {
        Destroy(gameObject, trajanje);
    }
}
