using UnityEngine;

public class Elevation_Entry : MonoBehaviour
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

        if(colision.gameObject.tag == "Player"){
            foreach(var elevacao in moutainColliders){
                    elevacao.enabled = false;
            }
           
           colision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
          Debug.Log("Limites: "+limiteLevel);
          foreach(var limite in limiteLevel){
                   limite.enabled = true;
            } 
        
        }

    }
}
