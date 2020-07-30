using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
		{
			MakeRaycast();
			
		}	
    }
	private void MakeRaycast()
	{
		RaycastHit hit;
		int range = 10;
		Debug.DrawRay(transform.position,transform.foward * range ,Color.cyan);
		if (Physics.Raycast(transform.position,transform.forward , out hit , ranger ))
		{
			Debug.Log("Objeye çarptım" +hit.transform.name);
		}
	}


}


