using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoASDW : MonoBehaviour {

    public float velocidad;
    public float sprint;

    bool temp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            temp = true;
            velocidad *= sprint;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.1f * velocidad);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f * velocidad);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f * velocidad, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f * velocidad, 0, 0);
        }

        if (temp)
        {
            velocidad /= sprint;
            temp = false;
        }
    }
}
