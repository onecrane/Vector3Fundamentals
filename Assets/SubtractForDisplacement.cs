using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtractForDisplacement : MonoBehaviour
{

    public EmptyObjectSphereGizmo start, end;


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

        Vector3 endPos = end.transform.position;
        Vector3 startPos = start.transform.position;
        Vector3 displacement = endPos - startPos;


        // Displacement plus direction
        Gizmos.color = Color.yellow ;
        Gizmos.DrawLine(startPos, startPos + displacement.normalized);
        Gizmos.DrawLine(Vector3.zero, displacement.normalized);
        Gizmos.color *= new Color(0.6f, 0.6f, 0.6f, 0.6f);
        Gizmos.DrawLine(startPos, endPos);
        Gizmos.DrawLine(Vector3.zero, displacement);


        Gizmos.color = start.gizmoColor;
        Gizmos.DrawLine(displacement, displacement + startPos.normalized);
        Gizmos.DrawLine(Vector3.zero, startPos.normalized);
        Gizmos.color *= new Color(0.6f, 0.6f, 0.6f, 0.6f);
        Gizmos.DrawLine(displacement, endPos);
        Gizmos.DrawLine(Vector3.zero, startPos);


        Gizmos.color = oldColor;
    }
}
