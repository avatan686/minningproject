using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
   [SerializeField] private CanvasGroup canvasgroup; 

    private bool _fadein = false; 
    private bool _fadeout = false; 

    
        // Update is called once per frame
        void Update()
        {
            if(_fadein)
            {
            
                if(canvasgroup.alpha < 1)
                {
                    canvasgroup.alpha += Time.deltaTime;
                    if (canvasgroup.alpha >= 1)
                    {
                        _fadein = false; 
                    }
                }
            }
            if(_fadeout)
            {
            
                if(canvasgroup.alpha >= 0)
                {
                    canvasgroup.alpha -= Time.deltaTime;
                    if (canvasgroup.alpha == 1)
                    {
                        _fadeout = false; 
                    }
                }
            }
        }

        public void FadeIn()
        {
          _fadein = true;           
        }
        public void FadeOut()
        {
            _fadeout = true;           
        }

}
