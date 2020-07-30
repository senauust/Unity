using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpanner : MonoBehaviour
{
    public GameObject boxObject;
	List<GameObject> boxes = new List<GameObject>();
	
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
		{
			Spawn();
		}
		else if(Input.GetMouseButtonDown(1))
		{
			DestroyObject();
		}
		
		
    }
	
	private void DestroyObject()
	{
		Destroy(boxes[boxes.Count -1]);
		boxes.RemoveAt(boxes.Count -1);
		
		
	}
	
	private void Spawn ()
	{
		//Küp vs için yazılabilecek olan kod 
		//GameObject.CreatePrimitive(PrimitiveType.Cube);
		Vector3 randPosition = new Vector3(UnityEngine.Random.Range(-25,25)
		,UnityEngine.Random.Range(2,10),
		,UnityEngine.Random.Range(-25,25));
	 GameObject box = Instantiate(boxObject,randPosition,Quaternion.identity);
	 boxes.Add(box);
	}
	
	
}
