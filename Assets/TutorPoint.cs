using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TutorPoint : MonoBehaviour
{

    public bool showDefaultGizmo = true;
    public float sphereSize = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this.name =              Set the name of this object
        // transform.position       The object's current position
        // .ToString                Convert this Vector3 to a string (subtle but important!)
        // ("F1")                   Format the x, y, and z values as floats with one decimal place
        this.name = transform.position.ToString("F1");
    }

    private void OnDrawGizmos()
    {
        if (!showDefaultGizmo) return;
        // First part of a pair - since Gizmos.color will affect
        // other scripts, we want to make sure we don't disrupt anything,
        // so before we clobber it, we preserve its original value
        Color oldColor = Gizmos.color;

        // Have to set the Gizmo color before making a .Draw* call
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(transform.position, sphereSize);

        // Second part of a pair - restoring Gizmos.color
        // to its original value.
        Gizmos.color = oldColor;
    }

    private void OnDrawGizmosSelected()
    {
        Color oldColor = Gizmos.color;

        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, sphereSize);

        Vector3 xy = transform.position, yz = xy, xz = xy;
        xy.z = 0;
        xz.y = 0;
        yz.x = 0;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(yz, transform.position);
        Gizmos.color *= new Color(1, 1, 1, 0.6f);
        Gizmos.DrawCube(yz, new Vector3(0.025f, 0.3f, 0.3f));

        Gizmos.color = Color.green;
        Gizmos.DrawLine(xz, transform.position);
        Gizmos.color *= new Color(1, 1, 1, 0.6f);
        Gizmos.DrawCube(xz, new Vector3(0.3f, 0.025f, 0.3f));

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(xy, transform.position);
        Gizmos.color *= new Color(1, 1, 1, 0.6f);
        Gizmos.DrawCube(xy, new Vector3(0.3f, 0.3f, 0.025f));

        Gizmos.color = oldColor;

    }

}
