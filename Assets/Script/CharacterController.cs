using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update



    
    [SerializeField]
    GameObject deathPanel;

    [SerializeField]
    GameObject jumpSoundPrefab;

    public bool oldumMu = false;


    public float jumpingForce=0.5f;


       [SerializeField] bool yereBasıyoMuyum = true;
     

    [SerializeField] Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D =  GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {

     
        if(Input.GetKeyDown(KeyCode.Space)   && yereBasıyoMuyum){
            Jump();

        }

        if(Input.GetKeyDown(KeyCode.R) && oldumMu){
            Restart();
        }
        
      
    }





    IEnumerator ucFrameDeBir(){

        Debug.Log("Yazı");
       for(int i=0;i< 60;i++){
        yield return null;
       }
         
        StartCoroutine(ucFrameDeBir()); 


    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")){
            yereBasıyoMuyum = false;
           

        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")){
            yereBasıyoMuyum = true;

        }
    }




    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Obstacle")){
            GameOver();

        }
    }
    


    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver(){
        Debug.Log("Game Over");
        oldumMu = true;
        deathPanel.SetActive(true);
        rigidbody2D.isKinematic = true;

        ScoreManager.instance.UpdateHighscore();
    }

    void Jump(){
        rigidbody2D.AddForce( Vector2.up* jumpingForce, ForceMode2D.Impulse);

         GameObject spawnedSound =    Instantiate(jumpSoundPrefab, transform.position, Quaternion.identity);
         Destroy(spawnedSound,1f);
    }
}
