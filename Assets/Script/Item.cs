using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

    /* https://unity3d.com/jp/learn/tutorials/projects/hajiuni/creating-the-game-ui?playlist=45986 */
}
