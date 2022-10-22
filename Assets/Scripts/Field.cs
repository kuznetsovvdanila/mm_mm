using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject template;
    public int room_x;
    public int room_z;

    void RectangleGenerator()
    {
        List<List<GameObject>> plates = new List<List<GameObject>>();
        float sx = template.transform.localScale.x;
        float sz = template.transform.localScale.z;
        Vector3 v = new Vector3(0, 0, 0);
        room_x = Random.Range(7, 15);
        room_z = Random.Range(7, 15);
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

    void OtherShapeGenerator()
    {
        
    }

    void Start()
    {
        // field type
        Debug.Log("asfsfgdgh");
        int fieldType = Random.Range(0, 1);
        if (!(fieldType > 0))
        {
            RectangleGenerator();
        }
        else { OtherShapeGenerator(); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
