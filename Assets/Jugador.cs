using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public Animator anim;
    float movimientoX;


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

    }
   

}
