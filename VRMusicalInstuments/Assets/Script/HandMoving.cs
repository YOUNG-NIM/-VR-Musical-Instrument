using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMoving : MonoBehaviour
{

    void OnMouseDrag() //�巡�� �̺�Ʈ
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

    }

}