using UnityEngine;


    public GameObject refPlayar;
    public Transform spawnPoint;
    public GameObject refPrefab;
    // Startpublic class chao : MonoBehaviour
{ is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.R)){

           refPlayar.SetActive(true);

        }


        
        if(Input.GetMouseButtonDown(0)){
            Destroy(refPlayar);
        
           
           
        }   
       
        if(Input.GetKeyDown(KeyCode.M)){

           Instantiate(refPrefab, spawnPoint);
           ScoreManager.circleCount++;
      
        }
      
      
      //refPlayar.SetActive(true)


    }
   
    

}