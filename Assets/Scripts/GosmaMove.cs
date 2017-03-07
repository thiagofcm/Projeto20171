using UnityEngine;
using System.Collections;


public class GosmaMove : MonoBehaviour
{

    public float velocidadeh;
    public float velocidadev;
    public float min;
    public float max;
    public float espera;

    //Use this for inialization
    void Start()
    {
        StartCoroutine(Move(max));
    }

    IEnumerator Move(float destino)
    {
        while (Mathf.Abs(destino - transform.localPosition.y) > 0.2f)
        {
            Vector3 direcaov = (destino == max) ? Vector3.up : Vector3.down;
            Vector3 velocidadeVetorial = direcaov * velocidadeh;
            transform.localPosition = transform.localPosition + velocidadeVetorial * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(espera);

        destino = (destino == max) ? min : max;
        StartCoroutine(Move(destino));
    }

    void Update()
    {
        Vector3 velocidadevetorialh = Vector3.left * velocidadev;

        transform.position = transform.position + velocidadevetorialh* Time.deltaTime;

       
    }

}
