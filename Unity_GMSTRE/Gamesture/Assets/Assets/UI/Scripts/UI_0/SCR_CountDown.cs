using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(Button))]
public class SCR_CountDown : MonoBehaviour
{
    public GameObject wrongBtn;                                                         // it avoids to push buttons more than once before its action finishes
    public GameObject panBox;                                                           
    public Button btn2;                                                                 
    public Sprite[] btn_2_sprites;                                                      // btn2 button take the images from here when it needs to change its sprite
    public Animator textDisplace;                                                       
    public TMP_Text aleaSentence;                                                        
    public string[] sentences;                                                          // array for store sentences wich will be choosen in an aleathory way
    public int countDownTime;                                                           
                                                                                        

    public void AleaSentence() { 
        StartCoroutine(ThreeSecondsAleaSentence());                                     // Three seconds aleaTHORY sentence coroutine launcher function
    }

    IEnumerator ThreeSecondsAleaSentence() {

        panBox.SetActive(true);
        aleaSentence.text = sentences[Random.Range(0,3)];                               // find aleathory position in a text array and put its content in aleaSentence Text box. 
        textDisplace.SetTrigger("play");                                                // introduce text box into the screen through Animator
        while (countDownTime > 0){
            yield return new WaitForSeconds(1f);
            btn2.GetComponent<Image>().sprite = btn_2_sprites[(countDownTime-1)];       //change the sprite-image-button every second during the count down.
            countDownTime--;
        }

        textDisplace.SetTrigger("playback");                                            // take the text-box out of the screen through Animator
        yield return new WaitForSeconds(1f);
        panBox.SetActive(false);
        countDownTime = 3;                                                              // restore the count down for the next time
        btn2.image.sprite = btn_2_sprites[(countDownTime-1)];                           // restore the original image button
        wrongBtn.SetActive(false);                                                      // allow push buttons again
    }
}
