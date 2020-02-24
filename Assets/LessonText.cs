using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonText : MonoBehaviour
{

    public GUIStyle textStyle;

    public string[] lessonText;

    public int textWidth = 350, textHeight = 400;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool showLesson = false;
    private void OnGUI()
    {
        if (GUILayout.Button(showLesson ? "Hide Text" : "Show Text")) showLesson = !showLesson;
        if (showLesson)
        {
            GUILayout.BeginArea(new Rect(0, 30, textWidth, textHeight), textStyle);
            for (int i = 0; i < lessonText.Length; i++)
            {
                GUILayout.Label(lessonText[i]);
            }
            GUILayout.EndArea();
        }

    }
}
