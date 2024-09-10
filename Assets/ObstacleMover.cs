using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{

    [SerializeField] private float moveDistance = 96f; 
    [SerializeField] private float moveSpeed = 12f; 


    private Vector3 startingPosition;
    private bool movingRight = true;

    private void Start()
    {

        startingPosition = transform.position;
    }

    private void Update()
    {
        MoveWall();
    }


    private void MoveWall()
    {

        float targetX = movingRight ? startingPosition.x + moveDistance : startingPosition.x - moveDistance;


        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);


        if (transform.position.x == targetX)
        {
            movingRight = !movingRight;
        }
    }
}
