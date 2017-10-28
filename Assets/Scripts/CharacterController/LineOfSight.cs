using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class LineOfSight : MonoBehaviour
{
    public float raylentgh;

    private RaycastHit vision;

    private void Start()
    {
        raylentgh = 4.0f;
    }

    private void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * raylentgh, Color.green, 0.5f);
        bool isInRange = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out vision, raylentgh);

        if (isInRange)
        {
            bool isPlayerPunching = (Input.GetKeyDown(KeyCode.Mouse0));
            bool isPunchable = (vision.rigidbody != null);
            
            if (isPlayerPunching && isPunchable)
            {
                vision.rigidbody.AddForce(vision.normal * -10000);
            }
        }
    }
}