using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Field : MonoBehaviour
{
    public Platform platform;
    public GameObject wall;
    public Unit player;
    public int roomX;
    public int roomX1;
    public int roomZ;
    public int roomZ1;
    public List<List<Platform>> platforms = new List<List<Platform>>();

    void RectangleGenerator()
    {
        Vector3 vector3 = new Vector3(0, 0, 0);
        roomX = Random.Range(7, 15);
        roomZ = Random.Range(7, 15);
        for (int k = 0; k < roomZ; k++)
        {
            vector3.z = k*platform.transform.localScale.z;
            platforms.Add(new List<Platform>());
            for (int i = 0; i < roomX; i++) 
            {
                vector3.x = i*platform.transform.localScale.x;
                platforms[k].Add(Instantiate(platform));
                bool isActive = !(((i==0) || (i==roomX-1)) || ((k==0) || (k==roomZ-1)));
                platforms[k][i].SetPlatform(this, vector3, isActive);
            }
        }
    }

    void OtherShapeGenerator()
    {
        Vector3 vector3 = new Vector3(0, 0, 0);
        roomX = Random.Range(9, 14);
        roomZ = Random.Range(9, 14);
        roomX1 = Random.Range(4, 6);
        roomZ1 = Random.Range(4, 6);
        int rX1 = roomX1;
        for (int k = 0; k < roomZ; k++)
        {
            vector3.z = k * platform.transform.localScale.z;
            platforms.Add(new List<Platform>());
            if (k == roomZ1){
                rX1 = 0;
            }
            for (int i = rX1; i < roomX; i++) 
            {
                vector3.x = i * platform.transform.localScale.x;
                platforms[k].Add(Instantiate(platform));
                bool isActive = !((rX1 == i) ||  (i == roomX - 1) || (k == 0) || (k == roomZ - 1) || ((i <= roomX1) && (k == roomZ1)));
                platforms[k][i-rX1].SetPlatform(this, vector3, isActive);
            }
        }
    }

    void Start()
    {
        // field type
        int fieldType = Random.Range(1, 2);
        if (!(fieldType > 1))
        {
            RectangleGenerator();
        }
        else { OtherShapeGenerator(); }
        player = Unit.Instantiate(player);
        player.setStartPosition(platforms[1][1].transform.position.x, platforms[1][1].transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
