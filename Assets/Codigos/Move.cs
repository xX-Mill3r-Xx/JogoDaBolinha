using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //public float _velocidadeFrente;
    //public float _velocidadeTras;
    //public float _velocidadeGirar;

    public float velocidade;
    public float girar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region
        //if (Input.GetKey("w"))
        //{
        //    transform.Translate(0, 0,(_velocidadeFrente * Time.deltaTime));
        //}

        //if (Input.GetKey("s"))
        //{
        //    transform.Translate(0, 0, (- _velocidadeTras * Time.deltaTime));
        //}

        //if (Input.GetKey("a"))
        //{
        //    transform.Rotate(0, (-_velocidadeGirar * Time.deltaTime), 0);
        //}

        //if (Input.GetKey("d"))
        //{
        //    transform.Rotate(0, (_velocidadeGirar * Time.deltaTime), 0);
        //}
        #endregion

        float translate = (Input.GetAxis("Vertical") * velocidade) * Time.deltaTime;
        float rotate = (Input.GetAxis("Horizontal") * girar) * Time.deltaTime;

        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotate, 0);
    }
}
