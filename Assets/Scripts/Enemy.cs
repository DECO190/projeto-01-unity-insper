using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;
    public float speed = 4;
    
    private AudioSource audio;
    private SpriteRenderer spriteRenderer;

    private bool canDamage
    {
        get
        {
            return damageCooldown <= 0;
        }
    }
    private float damageCooldown = 0;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        audio = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (damageCooldown > 0)
        {
            damageCooldown -= Time.deltaTime;
            
            Color color = spriteRenderer.color;
            spriteRenderer.color = new Color(color.r, color.g, color.b, 0.3f);
        }
        else
        {
            Color color = spriteRenderer.color;
            spriteRenderer.color = new Color(color.r, color.g, color.b, 1f);
        }
            
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canDamage)
        {
            GameController.heartCount--;
            audio.Play();

            damageCooldown = 3f;
        }
    }
    
}