using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Lamp : MonoBehaviour
{
    [SerializeField] Color disabledColor;
    [SerializeField] Color activstedColor;
    SpriteRenderer spriteRenderer;
    bool isActivated;
    public void Interact()
    {
        if (isActivated)
        {
            isActivated = false;
            spriteRenderer.color = disabledColor;
        }
        else
        {
            isActivated = true;
            spriteRenderer.color = disabledColor;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
