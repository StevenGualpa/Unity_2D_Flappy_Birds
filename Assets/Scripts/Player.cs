using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

    public float strength = 5f;
    public float gravity = -9.8f;
    public float tilt = 5f;

    private Vector3 direccion;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direccion = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            direccion = Vector3.up * strength;
        }

        // Apply gravity and update the position
        direccion.y += gravity * Time.deltaTime;
        transform.position += direccion * Time.deltaTime;

         // Tilt the bird based on the direction
        Vector3 rotation = transform.eulerAngles;
        rotation.z = direccion.y * tilt;
        transform.eulerAngles = rotation;
        
    }
    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0) {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /*
        if (other.gameObject.CompareTag("Obstaculo")) {
            FindObjectOfType<GameManager>().GameOver();
        } else if (other.gameObject.CompareTag("Puntaje")) {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
        */
    }

}
