using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveablePlatformBehavior : MonoBehaviour
{
    [SerializeField]
    float _horizontalSpeed = 5;
    [SerializeField]
    float _travelDistance = 5;

    Vector3 _startPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(_horizontalSpeed * Time.time, _travelDistance) + _startPosition.x,
                                        transform.position.y);
    }
}
