using UnityEngine;
using System.Collections;




/*              y
 *             |
 *             |
 *             |_________ x
 *            /
 *           /
 *          / z
 * 
 */

public class DraggableObject : MonoBehaviour
{
    //Plane movePlane;
    //float fixedDistance = 2f;
    //float hitDist, t;
    //Ray camRay;
    //Color origColor;
    //Vector3 startPos, point, corPoint;
    //private bool isSelected = false;
    //[SerializeField]
    //Color selectedColor = Color.yellow;
    //[SerializeField]
    //Color colidingColor = Color.red;
    //private int rotationDegrees;
    //Vector3 originalPosition;
    //int nrColiders;

    //CubeObj co = new CubeObj();
    //void OnMouseDown()
    //{
    //    originalPosition = transform.position;
    //    Debug.Log("MouseDown");
    //    Renderer rend = GetComponent<Renderer>();
    //    if (rend == null)
    //    {
    //        foreach (Renderer r in GetComponentsInChildren<Renderer>())
    //        {
    //            r.material.color = selectedColor;
    //        }
    //    }
    //    else
    //    {
    //        rend.material.color = selectedColor;
    //    }
    //    startPos = transform.position; // save position in case draged to invalid place
    //    movePlane = new Plane(-Camera.main.transform.forward, transform.position); // find a parallel plane to the camera based on obj start pos;
    //    if(!isSelected)
    //        GameObject.Find("Main Camera").GetComponent<SceneManager>().SetSelectObject(gameObject);
    //    isSelected = true;
    //    //GetComponent<Rigidbody>().isKinematic = false;

    //    var wLabel = GameObject.Find("objDimension");

    //   // co.get3DObjectDimensions(gameObject, wLabel);


    //}

    ////rigidbody.MovePosition instead of transform.position.
    //void OnMouseDrag()
    //{
    //    camRay = Camera.main.ScreenPointToRay(Input.mousePosition); // shoot a ray at the obj from mouse screen point

    //    if (movePlane.Raycast(camRay, out hitDist))
    //    { // finde the collision on movePlane
    //        point = camRay.GetPoint(hitDist); // define the point on movePlane
    //        t = -(fixedDistance - camRay.origin.y) / (camRay.origin.y - point.y); // the x,y or z plane you want to be fixed to
    //        corPoint.x = camRay.origin.x + (point.x - camRay.origin.x) * t; // calculate the new point t futher along the ray
    //        corPoint.z = camRay.origin.z + (point.z - camRay.origin.z) * t;
    //        //transform.position = corPoint;
    //        GetComponent<Rigidbody>().MovePosition(corPoint);           

    //    }
    //}

    //public void deselect()
    //{
    //    Renderer rend = GetComponent<Renderer>();
    //    if (rend == null)
    //    {
    //        foreach (Renderer r in GetComponentsInChildren<Renderer>())
    //        {
    //            r.material.color = origColor;
    //        }
    //    }
    //    else
    //    {
    //        rend.material.color = origColor;
    //    }
        
    //    isSelected = false;
    //}

    //private void OnMouseUp()
    //{
    //    if (nrColiders > 0)
    //        GetComponent<Rigidbody>().MovePosition(originalPosition);
    //    //GetComponent<Rigidbody>().MovePosition(corPoint);
    //    //GetComponent<Rigidbody>().isKinematic = true;
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    //transform.position = new Vector3(0, 0, 0);
    //    Debug.Log("b;a");
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Renderer rend = GetComponent<Renderer>(); 
    //    if (rend == null)
    //    {
    //        foreach (Renderer r in GetComponentsInChildren<Renderer>())
    //        {
    //            r.material.color = colidingColor;
    //        }
    //    }
    //    else
    //    {
    //        rend.material.color = colidingColor;
    //    }
    //    nrColiders++;

    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    Renderer rend = GetComponent<Renderer>();
    //    //if (rend == null)
    //    //    rend = GetComponentInChildren<Renderer>();
    //    nrColiders--;
    //    if (nrColiders > 0)
    //        return;
    //    if (rend == null)
    //    {
    //        foreach (Renderer r in GetComponentsInChildren<Renderer>())
    //        {
    //            if (isSelected)
    //                r.material.color = selectedColor;
    //            else
    //            {
    //                r.material.color = origColor;
    //            }
    //        }
    //    }
    //    else
    //    {
    //        if (isSelected)
    //            rend.material.color = selectedColor;
    //        else
    //        {
    //            rend.material.color = origColor;
    //        }
    //    }
       
        
    //}

    //public void Rotate(float degrees)
    //{
    //    rotationDegrees = (int)degrees;
    //    transform.Rotate(Vector3.up,   (degrees*45) - transform.rotation.eulerAngles.y, Space.World);


    //}

    //public void Delete(GameObject go)
    //{
    //    //if (isSelected)
    //        //Destroy(go);
    //}

    //private void Start()
    //{
    //    corPoint = transform.position;
    //    Renderer rend = GetComponent<Renderer>();
    //    if(rend == null)
    //    {
    //        rend = GetComponentInChildren<Renderer>();
    //    }
    //    origColor = rend.material.color;
    //    GetComponent<Rigidbody>().freezeRotation = true;
    //    nrColiders = 0;
    //}

    //public int getRotationDegrees()
    //{
    //    return rotationDegrees;
    //}
}