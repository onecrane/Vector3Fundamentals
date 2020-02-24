using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyObjectSphereGizmo : MonoBehaviour
{

    public Color gizmoColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Color oldColor = Gizmos.color;

        Gizmos.color = gizmoColor;
        Gizmos.DrawSphere(transform.position, 0.3f);

        Gizmos.color = oldColor;
    }
}
