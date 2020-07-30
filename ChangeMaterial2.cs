using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
	MeshRenderer meshRenderer;
	public Material activeMaterial;
	Material oldMaterial;
	
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer=GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
		
		{
			oldMaterial = meshRenderer.material;
			meshRenderer.material = activeMaterial;
		}
		
		else if (Input.GetKeyUp(KeyCode.E))
		{
			meshRenderer.material = oldMaterial;
		}
		
		if (Input.GetMouseDown(0))
			
			{
				Instantiate(gameObject);
				
			}
		if (Input.GetButton("Run"))
			
			{ 
				Debug.Log("RUN");
				
			}
    }
	
	
	
	
}
