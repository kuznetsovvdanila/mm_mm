using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class field : MonoBehaviour
{
    public GameObject template;
    public int room_x = 16;
    public int room_z = 16;

    void Start()
    {
        List<List<GameObject>> plates = new List<List<GameObject>>();
        float sx = template.transform.localScale.x;
        float sz = template.transform.localScale.z;
        Vector3 v = new Vector3(0, 0, 0);
        for (int k = 0; k < room_z; k++){
            v.z = k*sz;
            plates.Add(new List<GameObject>());
            for (int i = 0; i < room_x; i++){
                v.x = i*sx;
                plates[k].Add(Instantiate(template, parent:this.transform));
                plates[k][i].transform.position = v;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
