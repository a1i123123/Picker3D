using System.Collections.Generic;
using Signals;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Sirenix.OdinInspector;

public class LevelPanelController : MonoBehaviour
{
   #region Self Variables

   #region Serialized Variables

   [SerializeField] private List<TextMeshProUGUI> levelTexts = new List<TextMeshProUGUI>();
   [Space]
   [SerializeField] private List<Image> stageImages = new List<Image>();

   #endregion

   #endregion
   private void OnEnable()
   {
      SubscribeEvents();
   }
   private void SubscribeEvents()
   {
      UISignals.Instance.onSetNewLevelValaue += onSetNewLevelValue;
      UISignals.Instance.onSetStageColor += OnSetStageColor;
   }
   private void UnSubscriptionEvents()
   {
      UISignals.Instance.onSetNewLevelValaue -= onSetNewLevelValue;
      UISignals.Instance.onSetStageColor -= OnSetStageColor;
   }
   private void OnDisable()
   {
      UnSubscriptionEvents();
   }
   private void onSetNewLevelValue(int levelValue)
   {
      if (levelValue <= 0) levelValue = 1;
      
      levelTexts[0].text = levelValue.ToString();
      var value = ++levelValue;
      levelTexts[1].text = value.ToString();
   }
   [Button("OnStageColor")]
   private void OnSetStageColor(int stageValue)
   {
      stageImages[stageValue].DOColor(Color.red, .35f).SetEase(Ease.Linear);
   }
}
