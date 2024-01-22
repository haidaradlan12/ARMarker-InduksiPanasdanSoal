using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuAtas,MenuKiri, PanelButton, MenuLain, PanelLesson, PIsiL0, PIsiL1, PIsiL2, PIsiL3, PanelAbout, PanelGuide;
    public RectTransform PanelQuixBack, PanelSoal1, PanelSoal2, PanelSoal3, PanelSoal4, PanelSoal5, PanelSoal6, PanelSoal7, PanelSoal8, PanelSoal9, PanelSoal10, PanelNilai;
    public GameObject SB, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10;
    // Start is called before the first frame update
    void Start()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f); 
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonKembali()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonLesson()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonLesson_0()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonLesson_1()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonLesson_2()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonLesson_3()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonAbout()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonGuide()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal1()
    {
        SB.SetActive(true);
        S1.SetActive(true);
        S2.SetActive(true);
        S3.SetActive(true);
        S4.SetActive(true);
        S5.SetActive(true);
        S6.SetActive(true);
        S7.SetActive(true);
        S8.SetActive(true);
        S9.SetActive(true);
        S10.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal2()
    {
        SB.SetActive(true);
        S1.SetActive(true);
        S2.SetActive(true);
        S3.SetActive(true);
        S4.SetActive(true);
        S5.SetActive(true);
        S6.SetActive(true);
        S7.SetActive(true);
        S8.SetActive(true);
        S9.SetActive(true);
        S10.SetActive(true);
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal3()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal4()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal5()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal6()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal7()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal8()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal9()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonSoal10()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonNilai()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelButton.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        MenuLain.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelLesson.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL0.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PIsiL3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelAbout.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelGuide.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelQuixBack.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void ButtonResetSoal()
    {
        SB.SetActive(true);
        S1.SetActive(true);
        S2.SetActive(false);
        S3.SetActive(false);
        S4.SetActive(false);
        S5.SetActive(false);
        S6.SetActive(false);
        S7.SetActive(false);
        S8.SetActive(false);
        S9.SetActive(false);
        S10.SetActive(false);
        PanelQuixBack.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonKembaliSoal()
    {
        SB.SetActive(false);
        S1.SetActive(false);
        S2.SetActive(false);
        S3.SetActive(false);
        S4.SetActive(false);
        S5.SetActive(false);
        S6.SetActive(false);
        S7.SetActive(false);
        S8.SetActive(false);
        S9.SetActive(false);
        S10.SetActive(false);
        PanelQuixBack.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelSoal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PanelNilai.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
}