using UnityEngine;

public class Goal : MonoBehaviour
{
    private Collision2D _collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch()
    {
        OnCollisionEnter2D(_collision);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) Debug.Log("Finish!");
        
        else Debug.Log("Finish without Tag Player");
    }
}
