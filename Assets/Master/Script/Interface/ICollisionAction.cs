using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollisionAction
{
    Vector3 CollisionEvent(Collision collision);
}
