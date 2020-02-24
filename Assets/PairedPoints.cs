using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PairedPoints : MonoBehaviour
{

    public EmptyObjectSphereGizmo from, to;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = from.transform.position + to.transform.position;
        transform.name = "Sum: "  + transform.position.ToString("F1");
    }

    private void OnDrawGizmos()
    {
        Color oldColor = Gizmos.color;

        Vector3 f = from.transform.position, t = to.transform.position, final = f + t;

        Gizmos.color = from.gizmoColor;
        Gizmos.DrawLine(Vector3.zero, from.transform.position.normalized);
        Gizmos.DrawLine(t, t + (final - t).normalized);
        Gizmos.color *= new Color(0.6f, 0.6f, 0.6f, 0.6f);
        Gizmos.DrawLine(Vector3.zero, from.transform.position);
        Gizmos.DrawLine(t, final);


        Gizmos.color = to.gizmoColor;
        Gizmos.DrawLine(Vector3.zero, to.transform.position.normalized);
        Gizmos.DrawLine(f, f + (final - f).normalized);
        Gizmos.color *= new Color(0.9f, 0.9f, 0.9f, 0.3f);
        Gizmos.DrawLine(Vector3.zero, to.transform.position);
        Gizmos.DrawLine(f, final);


        Gizmos.color = from.gizmoColor + to.gizmoColor;
        Gizmos.DrawSphere(from.transform.position + to.transform.position, 0.3f);


        Gizmos.color = oldColor;
    }
}
