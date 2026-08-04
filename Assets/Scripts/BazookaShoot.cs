using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BazookaShoot : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform muzzlePoint;
    public float shootForce;

    private XRGrabInteractable grab;
    private bool isGrabbed = false;

    void Start()
    {
        grab = GetComponent<XRGrabInteractable>();

        grab.selectEntered.AddListener(OnGrab);
        grab.selectExited.AddListener(OnRelease);
    }

    void Update()
    {
        if (isGrabbed && Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bomb = Instantiate(bombPrefab, muzzlePoint.position, muzzlePoint.rotation);

        Rigidbody rb = bomb.GetComponent<Rigidbody>();
        rb.AddForce(muzzlePoint.forward * shootForce, ForceMode.Impulse);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        isGrabbed = true;
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        isGrabbed = false;
    }
}