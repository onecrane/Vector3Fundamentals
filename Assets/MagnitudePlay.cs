using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnitudePlay : MonoBehaviour
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
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(startPos, startPos + displacement.normalized);
        Gizmos.color *= new Color(0.6f, 0.6f, 0.6f, 0.6f);
        Gizmos.DrawLine(startPos, endPos);

        Gizmos.color = oldColor;


    }

    float factor = 1.0f;
    private void OnGUI()
    {

        string strFactor = GUI.TextField(new Rect(800, 80, 80, 20), factor.ToString("0.000"));
        float oldFactor = factor;
        if (!float.TryParse(strFactor, out factor)) factor = oldFactor;

        if (GUI.Button(new Rect(800, 105, 70, 20), "Scale"))
        {
            Vector3 displacement = end.transform.position - start.transform.position;
            displacement *= factor;
            end.transform.position = start.transform.position + displacement;
        }

    }
}
