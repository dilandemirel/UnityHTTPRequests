using UnityEngine;

public class CountryClickHandler : MonoBehaviour
{
    // API isteði -- ülkeye/simdilik kita/ tiklandiginda --
    string apiUrl = "https://jsonplaceholder.typicode.com/todos/1";

    void OnMouseDown()
    {
        // MapInteraction sinifindaki metodu çagirarak bu API'ye istek gönderiyoruz
        FindObjectOfType<MapInteraction>().OnCountryClicked(apiUrl);
    }
}

