using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float CameraMoveSpeed;
    [SerializeField] float zoomSensitivity = 1.0f;
    [SerializeField] float minSize = 5, maxSize = 10;
    public bool CanMove = true;
    void Update(){
        if(CanMove){
            transform.position = new Vector3(transform.position.x + CameraMoveSpeed*Input.GetAxisRaw("Horizontal")*Time.deltaTime, transform.position.y + CameraMoveSpeed*Input.GetAxisRaw("Vertical")*Time.deltaTime, transform.position.z);
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize + Input.mouseScrollDelta.y * zoomSensitivity * -1.0f, minSize, maxSize);
        }
    }
}
