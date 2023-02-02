using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rBody; // リジッドボディを使うための宣言
    Vector3 velo = Vector3.zero;
    float speed=15;

    //上0 左1 下2 右3
    // public IReadOnlyReactiveProperty<PlayerLookDirection> Direction => _dire;
    // private readonly ReactiveProperty<PlayerLookDirection> _dire = new ReactiveProperty<PlayerLookDirection>();

    void Start()
    {
        rBody = this.gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rBody.velocity = velo;
    }

    private void Update()
    {
        var move = GetInputMove();

        if (move.x != 0)
        {
            velo = new Vector3(move.x * speed, 0,0);
            // if (move.x > 0)    _dire.Value = PlayerLookDirection.Right;
            // else                _dire.Value = PlayerLookDirection.Left;
        }
        else if (move.z != 0)
        {
            velo = new Vector3(0,0, move.z * speed);
            // if (move.y > 0)    _dire.Value = PlayerLookDirection.Top;
            // else                _dire.Value = PlayerLookDirection.Bottom;
        }
        else
        {
            velo = Vector3.zero;
        }
    }

    (float x, float z) GetInputMove()
    {
        return (
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
    }
    
}
