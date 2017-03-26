using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Manages getting and posting scores to the remote database on the server
public class ScoreService : MonoBehaviour {
    
    public void getTopTenScores()
    {
        string url = "http://52.72.17.21:3000/cs503";
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
    }

    public void postScore()
    {
        string url = "http://52.72.17.21:3000/cs503";

        WWWForm form = new WWWForm();
        form.AddField("username", "TestUsername"); // do not change, for now
        form.AddField("score", 1000);
        WWW www = new WWW(url, form);

        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log(www.text);
        }
        else
        {
            Debug.Log("Error: " + www.error);
        }
    }

    
}
