﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePlatfrom : MonoBehaviour
{

    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nexPos;

    [SerializeField] private float speed;

    [SerializeField] private Transform childTransform;

    [SerializeField] private Transform transformB;

    void Start()
    {
        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        nexPos = posB;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        Move();

    }

    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);

        if (Vector3.Distance(childTransform.localPosition, nexPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    private void ChangeDestination()
    {
        nexPos = nexPos != posA ? posA : posB;
    }

    public void allowMovement()
    {
        gameObject.SetActive(true);
    }
}