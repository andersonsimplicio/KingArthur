using UnityEngine;

public class ExitElebation : MonoBehaviour
{
    public Collider2D[] moutainColliders;
    public Collider2D[] limiteLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {

        if(colision.gameObject.CompareTag("Player")){
            foreach(var elevacao in moutainColliders){
                    elevacao.enabled = true;
            }
                    
          foreach(var limite in limiteLevel){
                   limite.enabled = false;
            } 
            colision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;

        }

    }
}
