using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Gem");
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Debug.LogError("GameObject \"Gem\" could not be found");
        }
        else
        {
            Debug.Log("Moving");
            this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, moveSpeed);
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Defeated");
        Destroy(this.gameObject);
        ScoreManager.IncreaseScore(1);
    }

}
