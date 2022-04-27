using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMergeScript : MonoBehaviour
{


    void OnCollisionStay(Collision collisionInfo)
        {
            // Debug-draw all contact points and normals
            foreach (ContactPoint contact in collisionInfo.contacts)
            {
                Debug.DrawRay(contact.point, contact.normal, Color.red);
            }
        }
}
