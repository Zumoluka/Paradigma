using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Movimiento lateral del jugador
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveInput * speed * Time.deltaTime);

        // Interactuar con enemigos al presionar la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 5f); // Ajusta el radio según necesites
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
