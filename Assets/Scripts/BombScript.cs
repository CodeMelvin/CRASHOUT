using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject explosion;
    public float force, radius;

    private void OnCollisionEnter(Collision other)
    {
        GameObject exp = Instantiate(explosion, transform.position, transform.rotation);

        AudioSource expSFX = exp.GetComponent<AudioSource>();
        if (expSFX != null)
        {
            expSFX.Play();
        }

        Destroy(exp, 10);
        knockback();
        Destroy(gameObject);
    }

    void knockback()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider col in colliders)
        {
            Rigidbody rig = col.GetComponent<Rigidbody>();

            if (rig != null)
            {
                rig.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}