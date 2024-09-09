using UnityEngine;

public class CountryClickHandler : MonoBehaviour
{
    // API isteði -- ülkeye týklandýðýnda --
    string apiUrl = "https://jsonplaceholder.typicode.com/todos/1";

    void OnMouseDown()
    {
        // MapInteraction sýnýfýndaki metodu çaðýrarak bu API'ye istek gönderiyoruz
        FindObjectOfType<MapInteraction>().OnCountryClicked(apiUrl);
    }
}

