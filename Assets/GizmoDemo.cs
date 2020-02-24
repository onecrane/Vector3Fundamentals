using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoDemo : MonoBehaviour
{
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
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(Vector3.zero, 0.4f);
        Gizmos.color = oldColor;
    }


}
