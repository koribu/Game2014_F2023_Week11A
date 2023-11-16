using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveablePlatformBehavior : MonoBehaviour
{
    
    public PlatformerMovementTypes _type;

    [SerializeField]
    float _horizontalSpeed = 5;
    [SerializeField]
    float _verticalSpeed = 5;

    [SerializeField]
    float _horizontalTravelDistance = 5;
    [SerializeField]
    float _verticalTravelDistance = 3;

    Vector3 _startPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        switch(_type)
        {
            case PlatformerMovementTypes.HORIZONTAL:
                transform.position = new Vector2(Mathf.PingPong(_horizontalSpeed * Time.time, _horizontalTravelDistance) + _startPosition.x,
                                        transform.position.y);
                break;
            case PlatformerMovementTypes.VERTICAL:
                transform.position = new Vector2(transform.position.x,
                                                 Mathf.PingPong(_verticalSpeed * Time.time, _verticalTravelDistance) + _startPosition.y);
                break;
            case PlatformerMovementTypes.DIAGONAL_RIGHT:
                transform.position = new Vector2(Mathf.PingPong(_horizontalSpeed * Time.time, _horizontalTravelDistance) + _startPosition.x,
                                                 Mathf.PingPong(_verticalSpeed * Time.time, _verticalTravelDistance) + _startPosition.y);

                break;
            case PlatformerMovementTypes.DIAGONAL_LEFT:
                transform.position = new Vector2(_startPosition.x - Mathf.PingPong(_horizontalSpeed * Time.time, _horizontalTravelDistance),
                                                  Mathf.PingPong(_verticalSpeed * Time.time, _verticalTravelDistance) + _startPosition.y);
                break;
            case PlatformerMovementTypes.CUSTOM:
                break;
        }
    }

}
