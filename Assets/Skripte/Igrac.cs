using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igrac : MonoBehaviour {

    public float brzina;
    Rigidbody2D rb;
    Animator anim;
    Vector2 micanjeUlaz;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update() {
        float micanjeX = Input.GetAxisRaw("Horizontal");
        float micanjeY = Input.GetAxisRaw("Vertical");
        micanjeUlaz = new Vector2(micanjeX, micanjeY);
        micanjeUlaz.Normalize();
        //micanjeUlaz = micanjeUlaz.normalized;

        //transform.Translate(micanjeUlaz * brzina * Time.deltaTime);
        //Debug.Log(micanjeUlaz.magnitude);

        if (micanjeUlaz.magnitude == 0) {
            anim.SetBool("aktivirajHodanje", false);
        } else {
            anim.SetBool("aktivirajHodanje", true);
        }
    }

    private void FixedUpdate() {
        rb.MovePosition(rb.position + micanjeUlaz * brzina * Time.fixedDeltaTime);
    }
}
