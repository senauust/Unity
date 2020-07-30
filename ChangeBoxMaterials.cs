using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBoxMaterials : MonoBehaviour
{
	public Material material;
    // Start is called before the first frame update
    void Start()
    {
		GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
		for ( int i = 0 ; i < boxes.Length; i++)
		{
			boxes[i].GetComponent<MeshRenderer>().material = material;
		}
		
      /*GameObject YellowCube = GameObject.Find("YellowCube");
	  GameObject GreenCube = GameObject.Find("GreenCube");
	  YellowCube.GetComponent<MeshRenderer>().material= material;
	  GreenCube.GetComponent<MeshRenderer>().material = material; 
	  */
	  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
