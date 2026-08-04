using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    [Header("Settings")]
    public GameObject treePrefab;
    public int treeCount = 500;
    public float rayHeight = 100f;
    public LayerMask groundMask;
    public LayerMask obstacleMask;

    [Header("References")]
    public Transform planeTransform;

    private Vector3 planeCenter;
    private Vector2 planeSize;

    void Start()
    {
        if (treePrefab == null || planeTransform == null)
        {
            Debug.LogError("Tree prefab or Plane has not been assigned!");
            return;
        }

        planeSize = new Vector2(
            planeTransform.localScale.x * 10f,
            planeTransform.localScale.z * 10f
        );

        planeCenter = planeTransform.position;

        int spawned = 0;
        int attempts = 0;

        while (spawned < treeCount && attempts < treeCount * 10)
        {
            attempts++;

            Vector3 randomPos = new Vector3(
                planeCenter.x + Random.Range(-planeSize.x / 2, planeSize.x / 2),
                planeCenter.y + rayHeight,
                planeCenter.z + Random.Range(-planeSize.y / 2, planeSize.y / 2)
            );

            if (Physics.Raycast(randomPos, Vector3.down, out RaycastHit hit, rayHeight * 2, groundMask))
            {
                if (hit.collider.transform == planeTransform)
                {
                    bool blocked = Physics.CheckSphere(hit.point + Vector3.up * 0.5f, 1f, obstacleMask);
                    if (!blocked)
                    {
                        Instantiate(treePrefab, hit.point, Quaternion.identity, transform);
                        spawned++;
                    }
                }
            }
        }

        Debug.Log($"Spawned {spawned} trees across the entire plane (after {attempts} attempts)");
    }
}
