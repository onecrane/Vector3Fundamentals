using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLabels : MonoBehaviour
{
    public GUIStyle style;
    public int labelWidth = 60, labelHeight = 24, heightAdjust = 10;

    public Vector3[] points;

    public GameObject pointMarker;

    public bool showPointLabels = false;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < points.Length; i++)
        {
            GameObject marker = Instantiate(pointMarker, transform);
            marker.transform.position = points[i];
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {

        if (GUI.Button(new Rect(500, 0, 150, 20), (showPointLabels ? "Hide" : "Show") +  " point labels")) showPointLabels = !showPointLabels;

        if (!showPointLabels) return;
        for (int i = 0; i < points.Length; i++)
        {
            Vector3 source = points[i];
            Vector3 camLoc = Camera.main.WorldToScreenPoint(source + source.normalized);
            Rect surround = new Rect(camLoc.x - labelWidth / 2, Screen.height - (camLoc.y - labelHeight / 2) + heightAdjust, labelWidth, labelHeight);
            GUI.Label(surround, source.ToString("F0"), style);
        }
    }


}
