﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverMonsterTooltip : MonoBehaviour
{   
    public CombatController combatController;
    [Header("Tooltip Objects")]
    public GameObject monster1ToolTip;
    public GameObject monster2ToolTip;
    public GameObject HPP1;
    public GameObject HPP2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableMonsterToolTip(GameObject HPPlate){
        if(HPPlate == HPP1){
            monster1ToolTip.SetActive(true);
            monster1ToolTip.transform.Find("Img_type1").GetComponent<Image>().sprite = TypeUtils.spriteByType(combatController.player1Monster.type1);
            if(combatController.player1Monster.type2 == Type.NONE){
                monster1ToolTip.transform.Find("Img_type2").GetComponent<Image>().sprite = null;
            }else{
            monster1ToolTip.transform.Find("Img_type2").GetComponent<Image>().sprite = TypeUtils.spriteByType(combatController.player1Monster.type2);
            }
            monster1ToolTip.transform.Find("TextName").GetComponent<Text>().text =    combatController.player1Monster.name;
            monster1ToolTip.transform.Find("TextHP").GetComponent<Text>().text =    combatController.player1Monster.HP.value.ToString();
                SetStatBarLength(monster1ToolTip.transform.Find("HPStatMeter").GetComponent<Image>(), combatController.player1Monster.HP.value);
            monster1ToolTip.transform.Find("TextAtk").GetComponent<Text>().text =   combatController.player1Monster.ATK.value.ToString();
                SetStatBarLength(monster1ToolTip.transform.Find("AtkStatMeter").GetComponent<Image>(), combatController.player1Monster.HP.value);
            monster1ToolTip.transform.Find("TextDef").GetComponent<Text>().text =   combatController.player1Monster.DEF.value.ToString();
                SetStatBarLength(monster1ToolTip.transform.Find("DefStatMeter").GetComponent<Image>(), combatController.player1Monster.HP.value);
            monster1ToolTip.transform.Find("TextSpAtk").GetComponent<Text>().text = combatController.player1Monster.spATK.value.ToString();
                SetStatBarLength(monster1ToolTip.transform.Find("SpAtkStatMeter").GetComponent<Image>(), combatController.player1Monster.HP.value);
            monster1ToolTip.transform.Find("TextSpDef").GetComponent<Text>().text = combatController.player1Monster.spDEF.value.ToString();
                SetStatBarLength(monster1ToolTip.transform.Find("SpDefStatMeter").GetComponent<Image>(), combatController.player1Monster.HP.value);
            monster1ToolTip.transform.Find("TextSpe").GetComponent<Text>().text =   combatController.player1Monster.SPEED.value.ToString();
                SetStatBarLength(monster1ToolTip.transform.Find("SpeStatMeter").GetComponent<Image>(), combatController.player1Monster.HP.value);    

        }else if(HPPlate == HPP2){
            monster2ToolTip.SetActive(true);
            monster2ToolTip.transform.Find("Img_type1").GetComponent<Image>().sprite = TypeUtils.spriteByType(combatController.player2Monster.type1);
            if(combatController.player2Monster.type2 == Type.NONE){
                monster2ToolTip.transform.Find("Img_type2").GetComponent<Image>().sprite = null;
            }else{
            monster2ToolTip.transform.Find("Img_type2").GetComponent<Image>().sprite = TypeUtils.spriteByType(combatController.player2Monster.type2);
            }
            monster2ToolTip.transform.Find("TextName").GetComponent<Text>().text =  combatController.player2Monster.name;
            monster2ToolTip.transform.Find("TextHP").GetComponent<Text>().text =    combatController.player2Monster.HP.value.ToString();
                SetStatBarLength(monster2ToolTip.transform.Find("HPStatMeter").GetComponent<Image>(), combatController.player2Monster.HP.value);
            monster2ToolTip.transform.Find("TextAtk").GetComponent<Text>().text =   combatController.player2Monster.ATK.value.ToString();
                SetStatBarLength(monster2ToolTip.transform.Find("AtkStatMeter").GetComponent<Image>(), combatController.player2Monster.HP.value);
            monster2ToolTip.transform.Find("TextDef").GetComponent<Text>().text =   combatController.player2Monster.DEF.value.ToString();
                SetStatBarLength(monster2ToolTip.transform.Find("DefStatMeter").GetComponent<Image>(), combatController.player2Monster.HP.value);
            monster2ToolTip.transform.Find("TextSpAtk").GetComponent<Text>().text = combatController.player2Monster.spATK.value.ToString();
                SetStatBarLength(monster2ToolTip.transform.Find("SpAtkStatMeter").GetComponent<Image>(), combatController.player2Monster.HP.value);
            monster2ToolTip.transform.Find("TextSpDef").GetComponent<Text>().text = combatController.player2Monster.spDEF.value.ToString();
                SetStatBarLength(monster2ToolTip.transform.Find("SpDefStatMeter").GetComponent<Image>(), combatController.player2Monster.HP.value);
            monster2ToolTip.transform.Find("TextSpe").GetComponent<Text>().text =   combatController.player2Monster.SPEED.value.ToString();
                SetStatBarLength(monster2ToolTip.transform.Find("SpeStatMeter").GetComponent<Image>(), combatController.player2Monster.HP.value); 
        }
    }

    
    public void DisableMoveToolTip(GameObject HPPlate){
        if(HPPlate == HPP1){
            monster1ToolTip.SetActive(false);
            UnsetStatBarLength(monster1ToolTip.transform.Find("HPStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster1ToolTip.transform.Find("AtkStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster1ToolTip.transform.Find("DefStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster1ToolTip.transform.Find("SpAtkStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster1ToolTip.transform.Find("SpDefStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster1ToolTip.transform.Find("SpeStatMeter").GetComponent<Image>());
        }else if(HPPlate == HPP2){
            monster2ToolTip.SetActive(false);
            UnsetStatBarLength(monster2ToolTip.transform.Find("HPStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster2ToolTip.transform.Find("AtkStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster2ToolTip.transform.Find("DefStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster2ToolTip.transform.Find("SpAtkStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster2ToolTip.transform.Find("SpDefStatMeter").GetComponent<Image>());
            UnsetStatBarLength(monster2ToolTip.transform.Find("SpeStatMeter").GetComponent<Image>());
        }
    } 

    public void ToolTipSnapToCursor(GameObject HPPlate){
      //  moveToolTip.transform.position = new Vector3(Input.mousePosition.x + 6, Input.mousePosition.y + 6, Input.mousePosition.z);
    }

    public void SetStatBarLength(Image img, int stat){
            float aux = img.GetComponent<Image> ().rectTransform.localScale.x;
            img.GetComponent<Image>().rectTransform.localScale = new Vector3((stat * aux / 200), 0.5f, 0.5f);

            img.GetComponent<Image> ().color = new Color32 (42, 134, 46, 255);

            if (img.GetComponent<Image> ().rectTransform.localScale.x < 0.35f) {
                img.GetComponent<Image> ().color = new Color32 (252, 232, 0, 255);
                return;
            }
            if (img.GetComponent<Image> ().rectTransform.localScale.x < 0.2f) {
                img.GetComponent<Image> ().color = new Color32 (255, 153, 0, 255);
                return;

            }
            if (img.GetComponent<Image> ().rectTransform.localScale.x < 0.15f) {
                img.GetComponent<Image> ().color = new Color32 (255, 0, 0, 255);
                return;

            }
    }
    
    public void UnsetStatBarLength(Image img){
            img.GetComponent<Image>().rectTransform.localScale = new Vector3(0.7f, 0.5f , 0.5f);
    }
}
