using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCheck : MonoBehaviour
{
    [Header("¼ì²â²ÎÊý")]
    public float checkRadius;
    public Vector2 bottomOffset;
    public LayerMask groundLayer;

    [Header("×´Ì¬")]
    public bool isGround;

    public void Check()
    {
        isGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, checkRadius, groundLayer);
    }

    


}
