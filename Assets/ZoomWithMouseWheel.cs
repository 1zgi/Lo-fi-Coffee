using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ZoomWithMouseWheel : MonoBehaviour
{
    [SerializeField] private Camera ZoomCamera;
    [SerializeField] private bool IsOrthograpicZoom;
    private float zoom;
    private Vector3 mouseWorldPosStart;

    public float minFOV;
    public float maxFOV;
    public float sensitivity;
    public float FOV;
    public GameObject currentHitGameObject;
    void Start()
    {
       
    }

    public bool zooming;
    public float zoomSpeed;
    

    /*void Update()
    {
        RaycastHit hit;
        Ray ray = ZoomCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            if (zooming)
            {
                
                float zoomDistance = zoomSpeed * Input.GetAxis("Vercial") * Time.deltaTime;
                ZoomCamera.transform.Translate(ray.direction * zoomDistance, Space.World);
            }
        }
    }*/

     void Update()
     {

         //var ray = ZoomCamera.ScreenPointToRay(Input.mousePosition);
         //RaycastHit hit;

         //var fwd = transform.TransformDirection(Vector3.forward);
         //mouseWorldPosStart = ZoomCamera.ScreenToWorldPoint(Input.mousePosition);

        //if (Physics.Raycast(ray,out hit,100)){//       currentHitGameObject = hit.transform.gameObject;
        //  var pos  = currentHitGameObject.transform.TransformDirection(Vector3.forward); }



                 if (Input.mouseScrollDelta.y > 0)
                 {
                    // Vector3 mouseWorldPosDiff = mouseWorldPosStart - pos;
                     //transform.position += mouseWorldPosDiff;
                     float zoomChangeAmout = 2f;
                     FOV = ZoomCamera.orthographicSize;
                     FOV -= zoomChangeAmout * Time.deltaTime;
                     FOV += (Input.GetAxis("Mouse ScrollWheel") * sensitivity) * -1;
                     FOV = Mathf.Clamp(FOV, minFOV, maxFOV);
                     ZoomCamera.orthographicSize = FOV;

                 }

                 if (Input.mouseScrollDelta.y < 0)
                 {
                     // Vector3 mouseWorldPosDiff = mouseWorldPosStart + pos;
                     // transform.position += mouseWorldPosDiff;
                     float zoomChangeAmout = 2f;
                     FOV = ZoomCamera.orthographicSize;
                     FOV += zoomChangeAmout * Time.deltaTime;
                     FOV += (Input.GetAxis("Mouse ScrollWheel") * sensitivity) * -1;
                     FOV = Mathf.Clamp(FOV, minFOV, maxFOV);
                     ZoomCamera.orthographicSize = FOV;

                 }

            
     }
    

}
