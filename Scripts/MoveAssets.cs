using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAssets : MonoBehaviour
{
    public GameObject gameObjectToMove;
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;

    public void MoveGameObject()
    {
        gameObjectToMove.transform.position = new Vector3(15, 0, 7);
        
    }

}
