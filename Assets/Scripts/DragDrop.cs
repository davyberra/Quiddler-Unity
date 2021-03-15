﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject goDownArea;
    public GameObject discardPile;
    public GameObject playerHandArea;
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private GameObject dropZone;
    private GameObject startParent;
    private Vector2 startPosition;

    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        goDownArea = GameObject.Find("goDownArea");
        discardPile = GameObject.Find("discardPile");
        playerHandArea = GameObject.Find("playerHandArea");
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        return;
        //if (collision.contactCount == 0)
        //{
        //    isOverDropZone = false;
        //    dropZone = null;
        //}
        
    }
    public void StartDrag()
    {
        startPosition = transform.position;
        startParent = transform.parent.gameObject;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
        if (isOverDropZone)
        {
            transform.SetParent(dropZone.transform, false);
            if (dropZone == discardPile)
            {
                transform.position = dropZone.transform.position;
            }
        }
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, true);
        }
    }
}
