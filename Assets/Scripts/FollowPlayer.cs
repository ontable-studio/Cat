using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;  
    public Transform pivot;  
    public float smoothSpeed = 0.125f;  
    public Vector2 offset;    

    private Vector3 desiredPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        desiredPosition = new Vector3(pivot.position.x + offset.x, target.position.y + offset.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

 
        smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, offset.y, Mathf.Infinity);

        transform.position = smoothedPosition;
    }
}
