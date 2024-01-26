using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateProjectile : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
 
}
