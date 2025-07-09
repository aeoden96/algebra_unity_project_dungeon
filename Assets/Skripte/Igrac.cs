using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igrac : MonoBehaviour {

    public float brzina;
    Rigidbody2D rb;
    Animator anim;
    Vector2 micanjeBrzina;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update() {
        float micanjeX = Input.GetAxisRaw("Horizontal");
        float micanjeY = Input.GetAxisRaw("Vertical");
        Vector2 micanjeUlaz = new Vector2(micanjeX, micanjeY);
        Debug.Log(micanjeUlaz);
    }
}
