using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public Animator anim;
    float movimientoX;
    public object collision;
    
    GameObject coleccionable;
    public GameObject enemigo;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


    }
    private void FixedUpdate()
    {
        float escalaOriginalX = Mathf.Abs(transform.localScale.x);
        transform.localScale = new Vector3(Mathf.Sign(movimientoX) * escalaOriginalX, transform.localScale.y, transform.localScale.z);

    }


    void Update()
    {
        rb.linearVelocity = new Vector2(movimientoX * speed, rb.linearVelocity.y);

        if (coleccionable != null)
        {
            Destroy(coleccionable);
            Puntos.instance.SumaPuntos();
        }
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movimientoX = movementVector.x;
        if (movimientoX != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }



}
