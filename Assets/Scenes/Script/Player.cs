using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int life = 40;
    public float speed = 5f;
    private Vector2 direction;

    public Vector2 _direction
    {
        get { return this.direction;} 
        set { this.direction = value;} 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Inicio da Cena");
        
       
    }

    // Update is called once per frame
    void Update()
    {
            Vector2 direction = Vector2.zero;
            transform.position += (Vector3)Mover(direction) * (speed * Time.deltaTime);     
    }
    
    Vector3 Mover(Vector2 direction)
    {
        this.direction = Vector2.zero;
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) 
            this.direction.y = 1f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) 
            this.direction.y = -1f;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) 
            this.direction.x = -1f;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) 
            this.direction.x = 1f;
        return (Vector3)this.direction.normalized;
    }
}