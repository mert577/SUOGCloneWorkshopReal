using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingGround : MonoBehaviour
{

    [SerializeField] Renderer myRenderer;
    [SerializeField] float scrollSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRenderer.material.mainTextureOffset += new Vector2(0.01f, 0) * Time.deltaTime* scrollSpeed;
    }
}
