using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInController : MonoBehaviour {

    public RawImage image;
    public Text text;
    public Button play;
    public Button quit;

    // Start is called before the first frame update
    void Start() {
        image.canvasRenderer.SetAlpha(0.0f);

        Color c = text.color;
        c.a = 0f;

        text.color = c;

        Image playImage = play.GetComponent<Image>();
        Text playButtonText = play.GetComponentInChildren<Text>();
        Image quitImage = quit.GetComponent<Image>();
        Text quitButtonText = quit.GetComponentInChildren<Text>();

        playImage.color = c;
        quitImage.color = c;
        playButtonText.color = c;
        quitButtonText.color = c;

        FadeIn();
        StartTextFading();
    }

    IEnumerator TextFadeIn() {
        for (float i = 0.05f; i < 1; i += 0.05f) {
            Color c = text.color;

            Image playImage = play.GetComponent<Image>();
            Text playButtonText = play.GetComponentInChildren<Text>();
            Image quitImage = quit.GetComponent<Image>();
            Text quitButtonText = quit.GetComponentInChildren<Text>();

            c.a = i;
            text.color = c;
            playImage.color = c;
            quitImage.color = c;
            playButtonText.color = c;
            quitButtonText.color = c;

            yield return new WaitForSeconds(0.05f);
        }
    }

    public void StartTextFading() {
        StartCoroutine("TextFadeIn");
    }

    // Update is called once per frame
    void FadeIn() {
        image.CrossFadeAlpha(1, 1.5f, false);
    }
}
