using UnityEngine;

public class UrlOpen : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
    }
   
}
