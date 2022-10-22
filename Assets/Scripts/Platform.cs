using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Material material;
    private Material standart_material {get;set;}
    private bool isActive {get; set;}
    private void OnMouseEnter() {
        standart_material = this.GetComponent<MeshRenderer>().material; 
        this.GetComponent<MeshRenderer>().material = material;
    }
    private void OnMouseExit() {
        this.GetComponent<MeshRenderer>().material = standart_material;
    }
    public void SetPlatform(Field Parent, Vector3 vector3, bool isActive){
        this.transform.parent = Parent.transform;
        this.transform.position = vector3;
        this.isActive = isActive;
        if (!isActive) {
            this.GetComponent<MeshRenderer>().material = material; 
        }
    }
}