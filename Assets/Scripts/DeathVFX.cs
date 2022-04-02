using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathVFX : MonoBehaviour
{
public void DestroyVFX()
    {
        Destroy(gameObject,0.3f);
    }
}
