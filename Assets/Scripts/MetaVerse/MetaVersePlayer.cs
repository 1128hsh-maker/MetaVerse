using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaVersePlayer : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector2 movement = Vector2.zero;
    public int Speed;
    protected Anime anime;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Anime>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleAction();
        Movement(movement);

    }
    protected void HandleAction()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        movement = new Vector2(horizontal, vertical).normalized;

    }

    private void Movement(Vector2 direction)
    {
        direction = direction * Speed;

        direction *= 5;
        _rigidbody.velocity = direction;
        anime.Move(direction);
    }
}
