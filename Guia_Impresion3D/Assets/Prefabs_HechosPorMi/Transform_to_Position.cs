using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_to_Position : MonoBehaviour
{

    public Transform target;
    public Transform camara;
    public float coord_x;
    public float coord_y;
    public float coord_z;

    public void setOrigin()
    {
            transform.position = target.position;
        
    }

    public void mover()
    {
        transform.position = target.position + new Vector3(coord_x, coord_y, coord_z);

    }

}
