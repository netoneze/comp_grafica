using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float unidadesT, unidadesR;
    public float vT, vR;
    // Start is called before the first frame update
    void Start()
    {
        vT = 2.5f;
        vR = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        unidadesT = Input.GetAxis("Vertical") * vT * Time.deltaTime;
        unidadesR = Input.GetAxis("Horizontal") * vR * Time.deltaTime;
        transform.Translate(0,0,unidadesT);
        transform.Rotate(0,unidadesR,0);
    }
}
