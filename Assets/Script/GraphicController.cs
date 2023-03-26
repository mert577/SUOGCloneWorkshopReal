using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GraphicController : MonoBehaviour
{


   [SerializeField] Transform graphicTransform;
    // Start is called before the first frame update
    void Start()
    {
        //bobbing animation
      graphicTransform.DOLocalMoveY(0.2f, 0.12f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
