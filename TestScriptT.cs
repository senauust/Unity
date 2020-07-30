using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptT : MonoBehaviour
{
	private void Awake()
	{ 
		Debug.Log("Awake Çalıştı.");
	}
	
	

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start çalıştı");
    }

	private void OnEnable()
	{
		print("On Enable Çalıştı.");
	}
	
    // Update is called once per frame
    void Update()
    {
        print ("Update Çalıştı");
		
    }
	private void LateUpdate()
	
	{ 
		print("Late Update");
		
	}
	
	private void FixedUpdate()
	{
		print("Fiziksel Çalıştı");
	}
	
	private void OnDisable()
	{
		print("Disable Çalıştı");
		
	}



}

