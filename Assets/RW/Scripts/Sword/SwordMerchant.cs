using UnityEngine;
using UnityEngine.UI;

public class SwordMerchant : MonoBehaviour
{
    [SerializeField] private Text _name;
    [SerializeField] private Text _description;
    [SerializeField] private Image _icon;
    [SerializeField] private Text _cost;
    [SerializeField] private Text _damage;

    public void UpdateDisplayUI(SwordData swordData)
    {
        _name.text = swordData.GetName;
        _description.text = swordData.GetDescription;
        _icon.sprite = swordData.GetIcon;
        _cost.text = swordData.GetCost.ToString();
        _damage.text = swordData.GetDamage.ToString();
    }
}
