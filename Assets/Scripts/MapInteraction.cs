using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;

public class MapInteraction : MonoBehaviour
{
    public Text uiText; // JSON verilerini göstereceðimiz UI Text referansý

    IEnumerator GetJsonData(string url)
    {
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("Hata: " + request.error);
            }
            else
            {
                string json = request.downloadHandler.text;
                TodoData data = JsonUtility.FromJson<TodoData>(json);

                // UI'da veriyi göster??????
                uiText.text = "Title: " + data.title;
            }
        }
    }

    public void OnCountryClicked(string url)
    {
        StartCoroutine(GetJsonData(url));
    }
}

[System.Serializable]
public class TodoData
{
    public int userId;
    public int id;
    public string title;
    public bool completed;
}
