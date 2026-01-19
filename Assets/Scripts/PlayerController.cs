using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;
    private bool isGrounded = true;
    private GameManager gameManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        // Movimiento constante hacia la derecha
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);

        // Salto con barra espaciadora o clic izquierdo
        if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si choca con el suelo, vuelve a estar en el piso
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        // Si choca con un obstáculo, Game Over
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (gameManager != null)
            {
                gameManager.GameOver();
            }
            else
            {
                Debug.LogWarning("GameManager no encontrado en la escena.");
            }
        }
    }
}
