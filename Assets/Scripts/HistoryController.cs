using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class HistoryController : MonoBehaviour
{

    public TextAsset inkJson;
    public Text textPrefab;
    public Button buttonPrefab;

    private Story story;

    void Start()
    {
        story = new Story(inkJson.text);
        updateUI();
    }

    void updateUI()
    {
        eraseUI();

        Text storyText = Instantiate(textPrefab) as Text;
        string text = loadStory();

        // ------- handle ink tags -------
        List<string> tags = story.currentTags;
        if (tags.Count > 0)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                // check endGame here
            }
        }

        storyText.text = text;
        storyText.transform.SetParent(this.transform, false);

        foreach (Choice choice in story.currentChoices)
        {
            Button choiceButton = Instantiate(buttonPrefab) as Button;
            Text choiceText = buttonPrefab.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
            choiceButton.transform.SetParent(this.transform, false);

            choiceButton.onClick.AddListener(delegate
            {
                chooseStoryChoice(choice);
            });
        }
    }

    void eraseUI()
    {
        for (int i = 1; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }
    }

    void chooseStoryChoice(Choice choice)
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }

        updateUI();
    }

    string loadStory()
    {
        string text = "";
        if (story.canContinue)
        {
            text = story.ContinueMaximally();
        }

        return text;
    }




}
