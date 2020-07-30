using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnıtyEngine.AI;


public class MoveToClick : MonoBehaviour
{
	UnityEngine.AI.NavMeshAgent navMeshAgent;
	
    // Start is called before the first frame update
    void Start()
    {
       navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
		{ 
			MoveToPosition();
		}
		
    }
	
	private void MoveToPosition()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray,out hit))
		{
			navMeshAgent.SetDestination(hit.point);
		
		}
	}	
}
