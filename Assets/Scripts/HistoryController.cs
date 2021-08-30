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
    public GameObject endgamePanel;

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

        //-------handle ink tags -------
        List<string> tags = story.currentTags;
        if (tags.Count > 0)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                Debug.Log(tags[i]);
                if (tags[i] == "Endgame")
                {
                    endgamePanel.SetActive(true);
                    Transform messageText = endgamePanel.transform.Find("Message");
                    Text messageContent = messageText.GetComponent<Text>();
                    if (tags[1] == "BankRobed")
                    {
                        messageContent.text = "You couldn't help him. The bank has been robed!";
                    }
                    else messageContent.text = "You helped him. The bank has not been robed!";
                }
            }
        }

        storyText.text = text;
        storyText.transform.SetParent(this.transform, false);

        if (story.currentChoices.Count > 0)
        {
            foreach (Choice choice in story.currentChoices)
            {
                Button choiceButton = Instantiate(buttonPrefab) as Button;
                Text choiceText = choiceButton.GetComponentInChildren<Text>();
                choiceText.text = "";
                choiceText.text = choice.text;
                choiceButton.transform.SetParent(this.transform, false);

                choiceButton.onClick.AddListener(delegate
                {
                    chooseStoryChoice(choice);
                });
            }
        }
    }

    void eraseUI()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }
    }

    void chooseStoryChoice(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);

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
