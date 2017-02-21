
using UnityEngine;

public class PranchaMove : MonoBehaviour {
    public float velocidade;
    public float limite;
    public float retorno;
	
	void Start () {
		
	}
	
	
	void Update () {
        Vector3 velocidadevetorial = Vector3.left * velocidade;

        transform.position = transform.position + velocidadevetorial * Time.deltaTime;

        if (transform.position.x <= limite)
        {
            transform.position = new Vector3(retorno, transform.position.y, transform.position.z);
        }
	}
}
