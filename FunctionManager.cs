using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionManager : MonoBehaviour
{
    //public or private void function's name
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is working");
        MyFunction ();
        Debug.Log("Line after my function");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyFunction()
    {
        Debug.Log("This part is the part inside my function");
    }




}
