using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public int DamageAmount = 10;

    void Update()
    {

        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveInput * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.R))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 5f);
            float minDistance = float.MaxValue;
            GameObject nearestEnemy = null;
            foreach (Collider col in hitColliders)
            {
                float distance = Vector3.Distance(transform.position, col.transform.position);
                if (distance < minDistance && col.CompareTag("Enemy"))
                {
                    minDistance = distance;
                    nearestEnemy = col.gameObject;
                }
                if (col.CompareTag("Enemy"))
                {
                    ITakeDamage damageReceiver = col.GetComponent<ITakeDamage>();
                    if (damageReceiver != null)
                    {
                        damageReceiver.TakeDamage(DamageAmount);
                    }
                }

                if (nearestEnemy != null)
                {
                    IPresentation presentation = nearestEnemy.GetComponent<IPresentation>();
                    if (presentation != null)
                    {
                        presentation.Action();
                    }
                }

            }
        }
    }
}
