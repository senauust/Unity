using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
	public MeshRenderer targetMeshRenderer;
	public Material activeMaterial;
	Material oldMaterial;
	
    private void OnTriggerEnter(Collider other)
	{
		oldMaterial = targetMeshRenderer.material;
		targetMeshRenderer.material = activeMaterial;
		
	}
	private void OnTriggerExit(Collider other)
	
	{
		targetMeshRenderer.material = oldMaterial;
		
	}
	
}
