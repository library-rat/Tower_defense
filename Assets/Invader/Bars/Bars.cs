using UnityEngine;
using UnityEngine.UI;public class Bars : MonoBehaviour
{
  public GameObject invader;

  public Image InnerHealth;

  public Image InnerFear;

  public void UpdateHealthBar() {
    float health = invader.GetComponent<Stats>().get_health();
    float maxhealth = invader.GetComponent<Stats>().get_maxhealth();
    
    InnerHealth.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1f);
  }

  public void UpdateFearBar(){
    float fear = invader.GetComponent<Stats>().get_fear();
    float maxfear = invader.GetComponent<Stats>().get_maxfear();
    
    InnerFear.fillAmount = Mathf.Clamp(fear / maxfear, 0, 1f);
  }
}