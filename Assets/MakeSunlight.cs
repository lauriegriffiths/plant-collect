using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSunlight : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public float interval;
    float elapsed = 0f;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
    }
 void Update() {
     elapsed += Time.deltaTime;
     if (elapsed >= interval) {
         elapsed = elapsed % interval;
         MakeLightDrop();
     }
 }
 void MakeLightDrop() {
        var position = this.gameObject.transform.position;
        Instantiate(myPrefab, position, Quaternion.identity);
        // Instantiate(myPrefab, new Vector2(0, 0), Quaternion.identity);
 }
}
