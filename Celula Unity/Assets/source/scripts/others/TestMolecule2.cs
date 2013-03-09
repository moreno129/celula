using UnityEngine;
using System.Collections;


public class TestMolecule2 : MonoBehaviour {
	public float CurveSpeed = 5;
	public float MoveSpeed = 1;
	 
	float fTime = 0;
	Vector3 vLastPos = Vector3.zero;
 
// Use this for initialization
void Start ()
	{
	}
 
// Update is called once per frame
void Update ()
	{
		vLastPos = transform.position;
		 
		fTime += Time.deltaTime * CurveSpeed;
		 
		Vector3 vSin = new Vector3(Mathf.Sin(fTime), Mathf.Sin(fTime));
		Vector3 vLin = new Vector3(1, 0, 0);
		 
		transform.position += (vLin+vSin) * Time.deltaTime;
		 
	}
}
        //rigidbody.AddRelativeForce(Vector3.right * Mathf.Sin (Mathf.PI)); 
    
	