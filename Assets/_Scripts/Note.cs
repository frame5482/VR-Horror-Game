using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] Outline outline;

    private void Start()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FirePit"))
        {
            GameManager.Instance.OnCollectNote();
            this.gameObject.SetActive(false);
            
        }
    }

    public void ToggleHighlight(bool value)
    {
        outline.enabled = value;
    }
}
