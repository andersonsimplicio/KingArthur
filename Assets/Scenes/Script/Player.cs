using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int life = 40;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Inicio da Cena");
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;
            Debug.Log($"Inicio da Cena {direction}");
         transform.position += Mover(direction) * (speed * Time.deltaTime);
      
    }

    Vector3 Mover(Vector2 direction)
    {
        direction = Vector2.zero;
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) 
            direction.y = 1f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) 
            direction.y = -1f;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) 
            direction.x = -1f;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) 
            direction.x = 1f;
        return (Vector3)direction.normalized;
    }
}