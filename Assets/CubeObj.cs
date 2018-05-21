using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider))]
public class CubeObj : MonoBehaviour {

    public GameObject current; //non highlighted object
    public GameObject highlighted; //highlighted object
    public bool isPanelUp; // by default it is 0 since it is a field/class member.

    private Vector3 dragPosition;

    private Vector3 screenPoint;
    private Vector3 offset;


    void OnMouseEnter()
    {
        // if panel is NOT up then go ahead and switch sprites!
        if (!isPanelUp)
        {
            current.SetActive(false);
            highlighted.SetActive(true);

           
        }
    }

    void OnMouseExit()
    {
        // if panel is NOT up then go ahead and switch sprites!
        if (!isPanelUp)
        {
            highlighted.SetActive(false);
            current.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {

        //transform.position = dragPosition;
    }


 
        private float _lockedYPosition;

        void OnMouseDown()
        {
            //screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); // I removed this line to prevent centring 
            _lockedYPosition = screenPoint.y;
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        // Screen.showCursor = false;



        }

        void OnMouseDrag()
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            curPosition.x = _lockedYPosition;
            //transform.position = curPosition;
        }

        void OnMouseUp()
        {
        // Screen.showCursor = true;

    }

    void getObjectWidth(GameObject myObj, GameObject myLabel)
    {
        Renderer renderer = myObj.GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;
        float width = bounds.size.x;

        Debug.Log(width);

        var wallWidth = myLabel.GetComponentInChildren<Text>();
        wallWidth.text = "x: " + width.ToString();
    }

    void getObjectHeight(GameObject myObj, GameObject myLabel)
    {
        Renderer renderer = myObj.GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;
        float height = bounds.size.y;

        Debug.Log(height);

        var wallWidth = myLabel.GetComponentInChildren<Text>();
        wallWidth.text = "y: " + height.ToString();
    }

    void get2DObjectDimensions(GameObject myObj, GameObject myLabel)
    {
        Renderer renderer = myObj.GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;
        float width = bounds.size.x;
        float height = bounds.size.y;

        var wallWidth = myLabel.GetComponentInChildren<Text>();
        wallWidth.text = "w:" + width.ToString() + "y" + height.ToString();
    }

    public void get3DObjectDimensions(GameObject myObj, GameObject myLabel)
    {
        Renderer renderer = myObj.GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;
        float width = bounds.size.x;
        float height = bounds.size.y;
        float z = bounds.size.z;

        var wallWidth = myLabel.GetComponentInChildren<Text>();
        wallWidth.text = "W: " + width.ToString() + "\tY " + height.ToString() + "\tZ " + z.ToString();
    }
}
