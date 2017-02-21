
using UnityEngine;

public class PranchaMove : MonoBehaviour {
    public float velocidade;
	
	void Start () {
		
	}
	
	
	void Update () {
        Vector3 velocidadevetorial = Vector3.left * velocidade;

        transform.position = transform.position + velocidadevetorial * Time.deltaTime;
	}
}
