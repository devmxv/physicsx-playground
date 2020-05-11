using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Text _scoreCount;

    private Vector3 _mOffset;
    private float _mZCoord;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerator OnTriggerEnter(Collider other)
    //{
    //    yield return new WaitForSeconds(2);
    //    Destroy(this.gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Containers")
        {
            GameSession.Instance.AddToScore(1);
            HandleColorCheck();
            
            Destroy(this.gameObject);
        }
        
    }

    private void HandleColorCheck()
    {
        
        //---Need to check if the ball and the box match the exact same color
        var ballColor = GetComponentInChildren<MeshRenderer>().material.color;
        //Debug.Log(ballColor);

        FindObjectOfType<Container>().GetContainerColor();


        if (ballColor == Color.red)
        {
            Debug.Log("It is a match!");
        }

    }

    //---Drag and Drop funcionality

    private void OnMouseDown()
    {
        _mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        //Store offset = gameObject world pos - mouse world pos
        _mOffset = gameObject.transform.position - GetMouseWorldPos();
        
    }


    //---Get the cursor position
    private Vector3 GetMouseWorldPos()
    {
        //pixel coordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;
        //Z Coordinate of game object on screen
        mousePoint.z = _mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() +_mOffset;
    }

    



}
