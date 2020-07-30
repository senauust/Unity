using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public int speed=3;
	CharacterController characterController;
	
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }
	
	Vector3 moveVector;
	
	private void MoveCharacter()
	{
		
		moveVector = new Vector3((Input.GetAxis("Horizontal") * speed * Time.deltaTime ,0, Input.GetAxis("Vertical") * speed * Time.deltaTime );
		characterController.Move(moveVector);
		
	}	


}

