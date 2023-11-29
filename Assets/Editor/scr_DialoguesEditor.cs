using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CustomEditor(typeof(scChapter1))]
public class scr_DialoguesEditor : Editor
{

    private scChapter1 myTarget;





    private void OnEnable()
    {
        myTarget = (scChapter1)target;
   
}

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Faces"), true);

        EditorGUILayout.PropertyField(serializedObject.FindProperty("tsLucky"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("vpLucky"), true);

        EditorGUILayout.PropertyField(serializedObject.FindProperty("tsTristan"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("vpTristan"), true);

        EditorGUILayout.PropertyField(serializedObject.FindProperty("tsKrypto"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("vpKrypto"), true);

        EditorGUILayout.PropertyField(serializedObject.FindProperty("tsAirom"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("vpAirom"), true);

        EditorGUILayout.PropertyField(serializedObject.FindProperty("tsMila"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("vpMila"), true);

        EditorGUILayout.PropertyField(serializedObject.FindProperty("tsProt"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("vpProt"), true);


        myTarget.currentTab = GUILayout.Toolbar(myTarget.currentTab, new string[] { "Chapter 1", "Chapter 2" });
        switch (myTarget.currentTab)
        {
            case 0:
                {

                    GUILayout.Box("ORDER\nLUCKY1 > TRISTAN1 > KRYPTO1 > LUCKY2 > AIROM1 > KRYPTO2 > MILA1 > AIROM2");
                    myTarget.currentSubTab = GUILayout.Toolbar(myTarget.currentSubTab, new string[] { "Lucky", "Tristan", "Krypto", "Airom", "Mila" });

                    switch (myTarget.currentSubTab)
                    {
                        case 0:
                            {
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d1"), true);


                               

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("doption"), true);

                              



                                EditorGUILayout.PropertyField(serializedObject.FindProperty("dodump"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("dotruth"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("dolie"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("dochance"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d2"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_dumptruth"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_dumplie"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_dumpnext"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_dumpnext_yes"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_dumpnext_no"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_dumpnext2"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_l_timeself"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_l_dating"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_dating_4"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_l_tattoo"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_l_bar"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_4"), true);




                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_l_chance"), true);

                                break;
                            }

                        case 1:
                            {
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("dtristan1"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("doraise"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("donoraise"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("dtristan2"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_ignore"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_confront"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_tristan_3"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_t_mechanic_raise"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_t_mechanic_noraise"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_t_miner_raise"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_t_miner_noraise"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_tristan_4"), true);

                                break;
                            }

                        case 2:
                            {
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_krypto_1"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_k_redblue"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_krypto_2_red"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_k_radiovstv"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_krypto_2_blue"), true);
                                break;
                            }
                        case 3:
                            {



                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_1"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_cold"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_fasting"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_2"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_sword"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_kickboxing"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_3"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_movie"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_salt"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_sweet"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_party"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_techno"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_a_hiphop"), true);




                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_4_holosword"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_4_kickboxing"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_5"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_6_party"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_airom_6_throwparty2"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_airom_6_noparty2"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_6_movie"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_airom_6_warsim"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_airom_6_swim"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_7_dating"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_7_personal"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_7_arxl"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_8"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_airom_preworkout"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("do_airom_testbooster"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_airom_9"), true);
                                break;
                            }
                        case 4:
                            {
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_1"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_1_op1"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_1_op1_yes"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_1_op1_no"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_1_op2"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_1_op2_galaxy"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_1_op2_grassfield"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_2"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_2_op1"), true);
                                //if vuelterp

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_2_op1_varpredicted"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_2_op2"), true);
                                //if straightforward

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_2_op2_varpredicted"), true);


                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_3"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_3_yes"), true);
                                //es yes + like metaphoric + long

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_3_yes_weird"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_3_yes_varpredicted"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_3_no"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_3_novarpredicted"), true);

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("d_m_4"), true);


                                break;
                            }
                    }
                    
                    break;
                }

            case 1:
                {
                    GUILayout.Box("ORDER\nTRISTAN1 > MILA1 > KRYPTO1 > KRYPTO2 > AIROM1 > MILA2 > TRISTAN2 > LUCKY1");

                    myTarget.currentSubTab = GUILayout.Toolbar(myTarget.currentSubTab, new string[] { "Tristan", "Mila", "Krypto", "Airom", "Lucky" });
                    switch (myTarget.currentSubTab)
                    {
                        case 0:
                            {
                                
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_tristan_1_MechwithRaise"), true);
                                GUILayout.Label("- any + raise");
                                
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_tristan_1_Mining"), true);
                                GUILayout.Label("- miner + no raise");

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_tristan_2_Brokeup"), true);
                                GUILayout.Label("- lucky break up");
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_o_tristan_2_Brokeup_Talk"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_o_tristan_2_Brokeup_Avoid"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_tristan_2_NoBrokeup"), true);
                                GUILayout.Label("- lucky one more chance");
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_o_tristan_2_NoBrokeup_Let"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_o_tristan_2_NoBrokeup_Divorce"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_tristan_3"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_tristan_3_time"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_tristan_3_money"), true);
                                break;
                            }
                        case 2:
                            {

                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_krypto_2"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_krypto_2_talk"), true);
                                EditorGUILayout.PropertyField(serializedObject.FindProperty("c2_krypto_2_notalk"), true);
                                
                                break;
                            }

                    }

                    break;
                }


        }

        serializedObject.ApplyModifiedProperties();

    }


}
