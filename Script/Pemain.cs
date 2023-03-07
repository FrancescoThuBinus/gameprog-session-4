using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject RawImageVideo;
    public GantiScene gs;

    void Start()
    {
        RawImageVideo.SetActive(false);
    }


    public void playerAttack()
    {
        playerAnimator.SetTrigger("isAttack");
    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }

    public void playVideo()
    {
        RawImageVideo.SetActive(true);
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(11.0f);
        gs.ChangeMyScene("MainMenu");
    }


}
