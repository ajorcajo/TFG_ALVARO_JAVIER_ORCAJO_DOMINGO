using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_to_Rotation : MonoBehaviour
{

    public Transform target;
    
    public void setOrigin()
    {
            transform.rotation = target.rotation;
        
    }

}
