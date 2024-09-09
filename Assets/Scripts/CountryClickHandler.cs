using UnityEngine;

public class CountryClickHandler : MonoBehaviour
{
    // API iste�i -- �lkeye t�kland���nda --
    string apiUrl = "https://jsonplaceholder.typicode.com/todos/1";

    void OnMouseDown()
    {
        // MapInteraction s�n�f�ndaki metodu �a��rarak bu API'ye istek g�nderiyoruz
        FindObjectOfType<MapInteraction>().OnCountryClicked(apiUrl);
    }
}

