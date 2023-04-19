using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollisionAction
{
    Beamline CollisionEvent(Beamline beamline);
}
