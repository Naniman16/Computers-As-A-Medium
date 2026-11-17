using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;

    public Sprite BackofPlayer;

    public Sprite FrontofPlayer;

    public Sprite LeftofPlayer;

    public Sprite RightofPlayer;

    public Transform weaponsTransform;
    // Start is called once before the first execution of Update after the
    //MonoBehaviour is Created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = LeftofPlayer;
            weaponsTransform.localRotation = Quaternion.Euler(-180, 0, -180);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = RightofPlayer;
            weaponsTransform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            speedX = 0;
        }
        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = BackofPlayer;
            weaponsTransform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = FrontofPlayer;
            weaponsTransform.localRotation = Quaternion.Euler(0, 0, -90);
        }
        else
        {
            speedY = 0;
        }
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}