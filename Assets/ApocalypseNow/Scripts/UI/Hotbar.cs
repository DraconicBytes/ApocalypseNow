using UnityEngine;
using UnityEngine.UI;

public class Hotbar : MonoBehaviour {

    public GameObject[] Fields;

    public bool HightlightField(int field, bool hightlighted)
    {
        if (field < 0 || field > Fields.Length)
            return false;

        if (Fields[field].GetComponent<Image>() == null)
            return false;

        Fields[field].GetComponent<Image>().color = hightlighted ? Color.red : Color.white;
        return true;
    }

    public bool SetPreview(int field, Sprite picture)
    {
        if (field < 0 || field > Fields.Length)
            return false;

        if (Fields[field].GetComponentInChildren<Image>() == null)
            return false;

        Fields[field].GetComponentInChildren<Image>().sprite = picture;
        return true;
    }
}
