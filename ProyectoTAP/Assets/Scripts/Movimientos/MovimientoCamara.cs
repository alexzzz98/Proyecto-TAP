using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {

    public float velocidadCamara;
    public Camera camara;

    float h;
    float v;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        h = Input.GetAxis("Mouse X") * velocidadCamara;
        v = Input.GetAxis("Mouse Y") * velocidadCamara;

        transform.Rotate(0, h, 0);
        camara.transform.Rotate(-v, 0, 0);
    }
}
