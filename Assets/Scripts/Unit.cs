using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private float Health = 10;
    private float Damage = 10;
    private float Defence = 5;

    public void setStartPosition(float x, float z)
    {
        Vector3 vector = new Vector3(x, 10, z);
        transform.position = vector;
    }

    // public playerMove(float x, float z)
    // {
    //     
    // }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
