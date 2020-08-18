using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionManager : MonoBehaviour
{
    //public or private void function's name
    // Start is called before the first frame update
    public Game Object[] player ;

    private void Start()
    {
       player = GetAllThePlayers();
    }


    void Update()
    {

    }

    GameObject [] GetAllThePlayers()
    {
        GameObject [] AllThePlayer = GameObject.FindGamesWithTag("Player");

        foreach (var p in AllThePlayer)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color (Random.value , Random.value , Random.value);
        }
    return AllThePlayer;
    
    
    }



}
