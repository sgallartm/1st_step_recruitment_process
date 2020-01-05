using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SCR_PopUpSystem : MonoBehaviour
{
    public GameObject wrongBtn;                     // it avoids to push buttons more than once before its action finishes
    public GameObject popUpBox;             
    public Animator Animator;
    public TMP_Text popUpText;

    public void PopUp(string text){
            popUpBox.SetActive(true);
            popUpText.text = text;                  // fill the text box with the text that you pass to the function
            Animator.SetTrigger("pop");
    }
    public void PopDown(){
            Animator.SetTrigger("close");
            wrongBtn.SetActive(false);              // allow push buttons again
}
    


}
