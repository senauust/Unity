using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTriggerState : MonoBehaviour
{
	Collider collider ; 
	
	public bool isTrigger ;
	
    // Start is called before the first frame update
    void Start()
    {
        collider=GetComponent<Collider<();
		
		collider.isTrigger = isTrigger ;
		
	}
	

    // Update is called once per frame
    void Update()
    {
        
    }
}
