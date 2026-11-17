using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the
    //MonoBehaviour is created

    public GameObject bulletPrefab;

    public Transform firePoint;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    void Attack()
    {


        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    void Shoot()
    {

        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

}