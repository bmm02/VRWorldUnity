using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerrockfallscript : MonoBehaviour
{
    private Animator _rockAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _rockAnimator = GetComponent<Animator>();
    }
    private void OnTriggerCollider(Collider other)
    {
        if (other.tag == "Key")
        {
            Debug.Log("Key entered the trigger.");
            _rockAnimator.SetTrigger("Open");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
