using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TutorPointDirection : MonoBehaviour
{

    public float magnitude;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        magnitude = transform.position.magnitude;
    }

    private void OnDrawGizmosSelected()
    {
        Color oldColor = Gizmos.color;

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(Vector3.zero, transform.position);

        Gizmos.color = new Color(1, 0, 1, 1);
        Gizmos.DrawLine(Vector3.zero, transform.position.normalized);


        Gizmos.color *= new Color(1, 1, 1, 0.8f);
        Gizmos.DrawSphere(transform.position.normalized, 0.1f);


        Gizmos.color = oldColor;

    }
}
