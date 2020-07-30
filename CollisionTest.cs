using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
	
	// OnCollisionEnter çarpışma başladığı zaman 
    private void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Ana Obje" + this.gameObject.name + "çarpan:" + collision.gameObject.name);
		
	}
	
	// OnCollisionStay çapışma devam ediyorsa
	// OnCollisionExit çarpışma bittiği zaman
	
	private void OnCollisionStay(Collision collision)
	
	{
		Debug.Log(collision.gameObject.name + "ile çarpışma devam ediyor");
	}
}
