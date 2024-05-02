using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SendScore : MonoBehaviour
{
    [SerializeField] InputField userInput;

    public void BuildScoreAndSend()
    {
        int collectiblesAmount = 0;
        if (Collectibles.IsCollectedPostalCard) collectiblesAmount++;
        if (Collectibles.IsCollectedLuge) collectiblesAmount++;
        if (Collectibles.IsCollectedMedal) collectiblesAmount++;
        if (Collectibles.IsCollectedHoodie) collectiblesAmount++;
        if (Collectibles.IsCollectedTrophy) collectiblesAmount++;
        Score score = new(collectiblesAmount, userInput.text);
        string url = GetUrl();
        StartCoroutine(Post(url, JsonUtility.ToJson(score)));
    }

    private string GetUrl()
    {
        string savedJson = File.ReadAllText("config/config.json");
        Config config = JsonUtility.FromJson<Config>(savedJson);
        return config.url;
    }

    IEnumerator Post(string url, string bodyJsonString)
    {
        var request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(bodyJsonString);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();
        Debug.Log("Status Code: " + request.responseCode);
        Destroy(gameObject);
    }
}
