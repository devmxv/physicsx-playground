using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    Rigidbody boxRigidBody;
    Spawner Spawner;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        boxRigidBody = GetComponent<Rigidbody>();
        //InitBoxColor();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //HandleColorsCompare();
        
    }

    private void Move()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, boxRigidBody.velocity.y);

        boxRigidBody.velocity = movement;
    }

    //---OBSOLETE
    //private void InitBoxColor()
    //{
    //    //---Iterate to all the sides of the container
    //    foreach (Transform child in transform)
    //    {
    //        //---Set red color
    //        child.GetComponent<MeshRenderer>().material.color = Color.red;
    //    }
    //}

    //public void HandleColorsCompare()
    //{
    //    //---Box color
    //    var boxColor = GetComponentInChildren<MeshRenderer>().material.color;
    //    //---Ball color
    //    var ballColor = FindObjectOfType<Spawner>().GetBallColor();
    //    //Debug.Log("Ball color in Box.cs: " + ballColor);
    //    if(boxColor == ballColor)
    //    {
    //        Debug.Log("Points!");
    //    } else
    //    {
    //        Debug.Log("No points!");
    //    }
    //    //Spawner.GetBallColor();
    //    //var ballColor = 
    //    //Debug.Log(boxColor);
        
    //}

    
}
