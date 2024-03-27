using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    public GameObject SnakeOsChar, SnakeFsChar, SnakeNormal;
    public  bool SnakeOs, SnakeFs;
    bool EquipedOs, EquipedFs = false;
    public GameObject CharacterPanel, ShopPanel, ExtraItemsPanel, ButEquipOs, ButBuyOs, ButBuyFs, ButEquipFs, ButBuyitOs, ButBuyitFs, YouCantUnlockedThisItems, YouUnlockedThisChar;
    public static int Coin = 10000;
    public int Speed, Heart =0;
    public Text txtCoin, txt_Heart, txt_Speed;
    void Start()
    {

    }
    public void test()
    {
         SnakeFsChar.SetActive(true);
         SnakeNormal.SetActive(false);
         ButEquipFs.SetActive(true);
    }
    public void EquipedButOs()
    {
       ActiveCharOs();
       EquipedOs = true;
       ButEquipOs.SetActive(true);
         if (EquipedFs = true)
         {
            EquipedFs = false;
            ButBuyitFs.SetActive(true);
            ButEquipFs.SetActive(false);
            SnakeFsChar.SetActive(false);
         }
    }
    public void EquipedButFs()
    {
       ActiveCharFs();
       EquipedFs = true;
       ButEquipFs.SetActive(true);
         if (EquipedOs = true)
         {
            EquipedOs = false;
            ButBuyitOs.SetActive(true);
            ButEquipOs.SetActive(false);
            SnakeOsChar.SetActive(false);
         }

    }
      public void OffMessage()
    {
        YouUnlockedThisChar.SetActive(false);
        YouCantUnlockedThisItems.SetActive(false);
    }
     public void BuyflowerSnake()
     {
       if (Coin >= 2500)
       {
             SnakeFs = true;
             Coin -=2500;
             txtCoin.text = "" + Coin;
             YouUnlockedThisChar.SetActive(true);
             ButBuyFs.SetActive(false);         
             ButBuyitFs.SetActive(true);
       } 
       else{
        YouCantUnlockedThisItems.SetActive(true);
       }
     }
      public void BuyOrangeSnake()
     {
       if (Coin >= 3587)
       {
             SnakeOs = true;
             Coin -=3587;
             txtCoin.text = "" + Coin;
             YouUnlockedThisChar.SetActive(true);
             ButBuyOs.SetActive(false);
             ButBuyitOs.SetActive(true);
       } 
       else{
        YouCantUnlockedThisItems.SetActive(true);
       }
     }
  public void OffShop()
  {
    Time.timeScale = 1f;
     ShopPanel.SetActive(false);
  }
  public void OnShop()
  {
    Time.timeScale = 0f;
     ShopPanel.SetActive(true);
  }
    public void OnShopExtraItems()
  {
     ExtraItemsPanel.SetActive(true);
     CharacterPanel.SetActive(false);
  }
    public void OnShopCharacter()
  {
     ExtraItemsPanel.SetActive(false);
     CharacterPanel.SetActive(true);
  }
    public void BuyAddHeart()
    {
       if (Coin >= 1000)
       {
             Coin -=1000;
             txtCoin.text = "" + Coin;
             Heart+= 1;
             txt_Heart.text = "" + Heart;
       } 
       else{
                YouCantUnlockedThisItems.SetActive(true);
       }
    }
        public void BuyAddSpeed()
    {
       if (Coin >= 250)
       {
             Coin -=250;
             txtCoin.text = "" + Coin;
             Speed+= 1;
             txt_Speed.text = "" + Speed;
       } 
       else{
                YouCantUnlockedThisItems.SetActive(true);
       }
    }
    public void ActiveCharFs()
    {
         SnakeOsChar.SetActive(false);
         SnakeFsChar.SetActive(true);
         SnakeNormal.SetActive(false);
    }
    public void ActiveCharOs()
    {
         SnakeOsChar.SetActive(true);
         SnakeFsChar.SetActive(false);
         SnakeNormal.SetActive(false);
    }
    public void ActiveCharNormal()
    {
         SnakeOsChar.SetActive(false);
         SnakeFsChar.SetActive(false);
         SnakeNormal.SetActive(true);
    }

}
