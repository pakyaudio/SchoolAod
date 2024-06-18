
Imports System.IO
Imports Microsoft.Win32

Public Class MainFrm
#Region "code"


    Private Sub EnableAndDisableControl(ByVal edna As Integer)
        If edna = 1 Then
            Me.cbTime1.Enabled = True
            Me.cbTime2.Enabled = True
            Me.cbTime3.Enabled = True
            Me.cbTime4.Enabled = True
            Me.cbTime5.Enabled = True
            Me.cbTime6.Enabled = True
            Me.cbTime7.Enabled = True
            Me.cbTime8.Enabled = True
            Me.cbTime9.Enabled = True
            Me.cbTime10.Enabled = True
            Me.cbTime11.Enabled = True
            Me.cbTime12.Enabled = True
            Me.cbTime13.Enabled = True
            Me.cbTime14.Enabled = True
            Me.cbTime15.Enabled = True
            Me.cbTime16.Enabled = True
            Me.cbTime17.Enabled = True
            Me.cbTime18.Enabled = True
            Me.cbTime19.Enabled = True
            Me.cbTime20.Enabled = True

            Me.cbStime1.Enabled = True
            Me.cbStime2.Enabled = True
            Me.cbStime3.Enabled = True
            Me.cbStime4.Enabled = True
            Me.cbStime5.Enabled = True
            Me.cbStime6.Enabled = True
            Me.cbStime7.Enabled = True
            Me.cbStime8.Enabled = True
            Me.cbStime9.Enabled = True
            Me.cbStime10.Enabled = True
            Me.cbStime11.Enabled = True
            Me.cbStime12.Enabled = True
            Me.cbStime13.Enabled = True
            Me.cbStime14.Enabled = True
            Me.cbStime15.Enabled = True
            Me.cbStime16.Enabled = True
            Me.cbStime17.Enabled = True
            Me.cbStime18.Enabled = True
            Me.cbStime19.Enabled = True
            Me.cbStime20.Enabled = True

            Me.cbHH1.Enabled = True
            Me.cbHH2.Enabled = True
            Me.cbHH3.Enabled = True
            Me.cbHH4.Enabled = True
            Me.cbHH5.Enabled = True
            Me.cbHH6.Enabled = True
            Me.cbHH7.Enabled = True
            Me.cbHH8.Enabled = True
            Me.cbHH9.Enabled = True
            Me.cbHH10.Enabled = True
            Me.cbHH11.Enabled = True
            Me.cbHH12.Enabled = True
            Me.cbHH13.Enabled = True
            Me.cbHH14.Enabled = True
            Me.cbHH15.Enabled = True
            Me.cbHH16.Enabled = True
            Me.cbHH17.Enabled = True
            Me.cbHH18.Enabled = True
            Me.cbHH19.Enabled = True
            Me.cbHH20.Enabled = True

            Me.cbmm1.Enabled = True
            Me.cbmm2.Enabled = True
            Me.cbmm3.Enabled = True
            Me.cbmm4.Enabled = True
            Me.cbmm5.Enabled = True
            Me.cbmm6.Enabled = True
            Me.cbmm7.Enabled = True
            Me.cbmm8.Enabled = True
            Me.cbmm9.Enabled = True
            Me.cbmm10.Enabled = True
            Me.cbmm11.Enabled = True
            Me.cbmm12.Enabled = True
            Me.cbmm13.Enabled = True
            Me.cbmm14.Enabled = True
            Me.cbmm15.Enabled = True
            Me.cbmm16.Enabled = True
            Me.cbmm17.Enabled = True
            Me.cbmm18.Enabled = True
            Me.cbmm19.Enabled = True
            Me.cbmm20.Enabled = True

            Me.txtPathWAV1.Enabled = True
            Me.txtPathWAV2.Enabled = True
            Me.txtPathWAV3.Enabled = True
            Me.txtPathWAV4.Enabled = True
            Me.txtPathWAV5.Enabled = True
            Me.txtPathWAV6.Enabled = True
            Me.txtPathWAV7.Enabled = True
            Me.txtPathWAV8.Enabled = True
            Me.txtPathWAV9.Enabled = True
            Me.txtPathWAV10.Enabled = True
            Me.txtPathWAV11.Enabled = True
            Me.txtPathWAV12.Enabled = True
            Me.txtPathWAV13.Enabled = True
            Me.txtPathWAV14.Enabled = True
            Me.txtPathWAV15.Enabled = True
            Me.txtPathWAV16.Enabled = True
            Me.txtPathWAV17.Enabled = True
            Me.txtPathWAV18.Enabled = True
            Me.txtPathWAV19.Enabled = True
            Me.txtPathWAV20.Enabled = True

            Me.btnSelectWAV1.Enabled = True
            Me.btnSelectWAV2.Enabled = True
            Me.btnSelectWAV3.Enabled = True
            Me.btnSelectWAV4.Enabled = True
            Me.btnSelectWAV5.Enabled = True
            Me.btnSelectWAV6.Enabled = True
            Me.btnSelectWAV7.Enabled = True
            Me.btnSelectWAV8.Enabled = True
            Me.btnSelectWAV9.Enabled = True
            Me.btnSelectWAV10.Enabled = True
            Me.btnSelectWAV11.Enabled = True
            Me.btnSelectWAV12.Enabled = True
            Me.btnSelectWAV13.Enabled = True
            Me.btnSelectWAV14.Enabled = True
            Me.btnSelectWAV15.Enabled = True
            Me.btnSelectWAV16.Enabled = True
            Me.btnSelectWAV17.Enabled = True
            Me.btnSelectWAV18.Enabled = True
            Me.btnSelectWAV19.Enabled = True
            Me.btnSelectWAV20.Enabled = True

            Me.btnPlay1.Enabled = True
            Me.btnPlay2.Enabled = True
            Me.btnPlay3.Enabled = True
            Me.btnPlay4.Enabled = True
            Me.btnPlay5.Enabled = True
            Me.btnPlay6.Enabled = True
            Me.btnPlay7.Enabled = True
            Me.btnPlay8.Enabled = True
            Me.btnPlay9.Enabled = True
            Me.btnPlay10.Enabled = True
            Me.btnPlay11.Enabled = True
            Me.btnPlay12.Enabled = True
            Me.btnPlay13.Enabled = True
            Me.btnPlay14.Enabled = True
            Me.btnPlay15.Enabled = True
            Me.btnPlay16.Enabled = True
            Me.btnPlay17.Enabled = True
            Me.btnPlay18.Enabled = True
            Me.btnPlay19.Enabled = True
            Me.btnPlay20.Enabled = True

            Me.txtPathWAV1_1.Enabled = True
            Me.txtPathWAV2_2.Enabled = True
            Me.txtPathWAV3_3.Enabled = True
            Me.txtPathWAV4_4.Enabled = True
            Me.txtPathWAV5_5.Enabled = True
            Me.txtPathWAV6_6.Enabled = True
            Me.txtPathWAV7_7.Enabled = True
            Me.txtPathWAV8_8.Enabled = True
            Me.txtPathWAV9_9.Enabled = True
            Me.txtPathWAV10_10.Enabled = True
            Me.txtPathWAV11_11.Enabled = True
            Me.txtPathWAV12_12.Enabled = True
            Me.txtPathWAV13_13.Enabled = True
            Me.txtPathWAV14_14.Enabled = True
            Me.txtPathWAV15_15.Enabled = True
            Me.txtPathWAV16_16.Enabled = True
            Me.txtPathWAV17_17.Enabled = True
            Me.txtPathWAV18_18.Enabled = True
            Me.txtPathWAV19_19.Enabled = True
            Me.txtPathWAV20_20.Enabled = True

            Me.btnSelectWAV1_1.Enabled = True
            Me.btnSelectWAV2_2.Enabled = True
            Me.btnSelectWAV3_3.Enabled = True
            Me.btnSelectWAV4_4.Enabled = True
            Me.btnSelectWAV5_5.Enabled = True
            Me.btnSelectWAV6_6.Enabled = True
            Me.btnSelectWAV7_7.Enabled = True
            Me.btnSelectWAV8_8.Enabled = True
            Me.btnSelectWAV9_9.Enabled = True
            Me.btnSelectWAV10_10.Enabled = True
            Me.btnSelectWAV11_11.Enabled = True
            Me.btnSelectWAV12_12.Enabled = True
            Me.btnSelectWAV13_13.Enabled = True
            Me.btnSelectWAV14_14.Enabled = True
            Me.btnSelectWAV15_15.Enabled = True
            Me.btnSelectWAV16_16.Enabled = True
            Me.btnSelectWAV17_17.Enabled = True
            Me.btnSelectWAV18_18.Enabled = True
            Me.btnSelectWAV19_19.Enabled = True
            Me.btnSelectWAV20_20.Enabled = True

            Me.cbbSound.Enabled = True
            Me.cbStartProWithCom.Enabled = True
            Me.btnPlayTimeNow.Enabled = True

            Me.cbShutdown.Enabled = True
            Me.cbHH_Shutdown.Enabled = True
            Me.cbmm_Shutdown.Enabled = True

            Me.cbFirst.Enabled = True
            Me.cbLast.Enabled = True
        End If

        If edna = 0 Then
            Me.cbTime1.Enabled = False
            Me.cbTime2.Enabled = False
            Me.cbTime3.Enabled = False
            Me.cbTime4.Enabled = False
            Me.cbTime5.Enabled = False
            Me.cbTime6.Enabled = False
            Me.cbTime7.Enabled = False
            Me.cbTime8.Enabled = False
            Me.cbTime9.Enabled = False
            Me.cbTime10.Enabled = False
            Me.cbTime11.Enabled = False
            Me.cbTime12.Enabled = False
            Me.cbTime13.Enabled = False
            Me.cbTime14.Enabled = False
            Me.cbTime15.Enabled = False
            Me.cbTime16.Enabled = False
            Me.cbTime17.Enabled = False
            Me.cbTime18.Enabled = False
            Me.cbTime19.Enabled = False
            Me.cbTime20.Enabled = False

            Me.cbStime1.Enabled = False
            Me.cbStime2.Enabled = False
            Me.cbStime3.Enabled = False
            Me.cbStime4.Enabled = False
            Me.cbStime5.Enabled = False
            Me.cbStime6.Enabled = False
            Me.cbStime7.Enabled = False
            Me.cbStime8.Enabled = False
            Me.cbStime9.Enabled = False
            Me.cbStime10.Enabled = False
            Me.cbStime11.Enabled = False
            Me.cbStime12.Enabled = False
            Me.cbStime13.Enabled = False
            Me.cbStime14.Enabled = False
            Me.cbStime15.Enabled = False
            Me.cbStime16.Enabled = False
            Me.cbStime17.Enabled = False
            Me.cbStime18.Enabled = False
            Me.cbStime19.Enabled = False
            Me.cbStime20.Enabled = False

            Me.cbHH1.Enabled = False
            Me.cbHH2.Enabled = False
            Me.cbHH3.Enabled = False
            Me.cbHH4.Enabled = False
            Me.cbHH5.Enabled = False
            Me.cbHH6.Enabled = False
            Me.cbHH7.Enabled = False
            Me.cbHH8.Enabled = False
            Me.cbHH9.Enabled = False
            Me.cbHH10.Enabled = False
            Me.cbHH11.Enabled = False
            Me.cbHH12.Enabled = False
            Me.cbHH13.Enabled = False
            Me.cbHH14.Enabled = False
            Me.cbHH15.Enabled = False
            Me.cbHH16.Enabled = False
            Me.cbHH17.Enabled = False
            Me.cbHH18.Enabled = False
            Me.cbHH19.Enabled = False
            Me.cbHH20.Enabled = False

            Me.cbmm1.Enabled = False
            Me.cbmm2.Enabled = False
            Me.cbmm3.Enabled = False
            Me.cbmm4.Enabled = False
            Me.cbmm5.Enabled = False
            Me.cbmm6.Enabled = False
            Me.cbmm7.Enabled = False
            Me.cbmm8.Enabled = False
            Me.cbmm9.Enabled = False
            Me.cbmm10.Enabled = False
            Me.cbmm11.Enabled = False
            Me.cbmm12.Enabled = False
            Me.cbmm13.Enabled = False
            Me.cbmm14.Enabled = False
            Me.cbmm15.Enabled = False
            Me.cbmm16.Enabled = False
            Me.cbmm17.Enabled = False
            Me.cbmm18.Enabled = False
            Me.cbmm19.Enabled = False
            Me.cbmm20.Enabled = False

            Me.txtPathWAV1.Enabled = False
            Me.txtPathWAV2.Enabled = False
            Me.txtPathWAV3.Enabled = False
            Me.txtPathWAV4.Enabled = False
            Me.txtPathWAV5.Enabled = False
            Me.txtPathWAV6.Enabled = False
            Me.txtPathWAV7.Enabled = False
            Me.txtPathWAV8.Enabled = False
            Me.txtPathWAV9.Enabled = False
            Me.txtPathWAV10.Enabled = False
            Me.txtPathWAV11.Enabled = False
            Me.txtPathWAV12.Enabled = False
            Me.txtPathWAV13.Enabled = False
            Me.txtPathWAV14.Enabled = False
            Me.txtPathWAV15.Enabled = False
            Me.txtPathWAV16.Enabled = False
            Me.txtPathWAV17.Enabled = False
            Me.txtPathWAV18.Enabled = False
            Me.txtPathWAV19.Enabled = False
            Me.txtPathWAV20.Enabled = False

            Me.btnSelectWAV1.Enabled = False
            Me.btnSelectWAV2.Enabled = False
            Me.btnSelectWAV3.Enabled = False
            Me.btnSelectWAV4.Enabled = False
            Me.btnSelectWAV5.Enabled = False
            Me.btnSelectWAV6.Enabled = False
            Me.btnSelectWAV7.Enabled = False
            Me.btnSelectWAV8.Enabled = False
            Me.btnSelectWAV9.Enabled = False
            Me.btnSelectWAV10.Enabled = False
            Me.btnSelectWAV11.Enabled = False
            Me.btnSelectWAV12.Enabled = False
            Me.btnSelectWAV13.Enabled = False
            Me.btnSelectWAV14.Enabled = False
            Me.btnSelectWAV15.Enabled = False
            Me.btnSelectWAV16.Enabled = False
            Me.btnSelectWAV17.Enabled = False
            Me.btnSelectWAV18.Enabled = False
            Me.btnSelectWAV19.Enabled = False
            Me.btnSelectWAV20.Enabled = False

            Me.btnPlay1.Enabled = False
            Me.btnPlay2.Enabled = False
            Me.btnPlay3.Enabled = False
            Me.btnPlay4.Enabled = False
            Me.btnPlay5.Enabled = False
            Me.btnPlay6.Enabled = False
            Me.btnPlay7.Enabled = False
            Me.btnPlay8.Enabled = False
            Me.btnPlay9.Enabled = False
            Me.btnPlay10.Enabled = False
            Me.btnPlay11.Enabled = False
            Me.btnPlay12.Enabled = False
            Me.btnPlay13.Enabled = False
            Me.btnPlay14.Enabled = False
            Me.btnPlay15.Enabled = False
            Me.btnPlay16.Enabled = False
            Me.btnPlay17.Enabled = False
            Me.btnPlay18.Enabled = False
            Me.btnPlay19.Enabled = False
            Me.btnPlay20.Enabled = False

            Me.txtPathWAV1_1.Enabled = False
            Me.txtPathWAV2_2.Enabled = False
            Me.txtPathWAV3_3.Enabled = False
            Me.txtPathWAV4_4.Enabled = False
            Me.txtPathWAV5_5.Enabled = False
            Me.txtPathWAV6_6.Enabled = False
            Me.txtPathWAV7_7.Enabled = False
            Me.txtPathWAV8_8.Enabled = False
            Me.txtPathWAV9_9.Enabled = False
            Me.txtPathWAV10_10.Enabled = False
            Me.txtPathWAV11_11.Enabled = False
            Me.txtPathWAV12_12.Enabled = False
            Me.txtPathWAV13_13.Enabled = False
            Me.txtPathWAV14_14.Enabled = False
            Me.txtPathWAV15_15.Enabled = False
            Me.txtPathWAV16_16.Enabled = False
            Me.txtPathWAV17_17.Enabled = False
            Me.txtPathWAV18_18.Enabled = False
            Me.txtPathWAV19_19.Enabled = False
            Me.txtPathWAV20_20.Enabled = False

            Me.btnSelectWAV1_1.Enabled = False
            Me.btnSelectWAV2_2.Enabled = False
            Me.btnSelectWAV3_3.Enabled = False
            Me.btnSelectWAV4_4.Enabled = False
            Me.btnSelectWAV5_5.Enabled = False
            Me.btnSelectWAV6_6.Enabled = False
            Me.btnSelectWAV7_7.Enabled = False
            Me.btnSelectWAV8_8.Enabled = False
            Me.btnSelectWAV9_9.Enabled = False
            Me.btnSelectWAV10_10.Enabled = False
            Me.btnSelectWAV11_11.Enabled = False
            Me.btnSelectWAV12_12.Enabled = False
            Me.btnSelectWAV13_13.Enabled = False
            Me.btnSelectWAV14_14.Enabled = False
            Me.btnSelectWAV15_15.Enabled = False
            Me.btnSelectWAV16_16.Enabled = False
            Me.btnSelectWAV17_17.Enabled = False
            Me.btnSelectWAV18_18.Enabled = False
            Me.btnSelectWAV19_19.Enabled = False
            Me.btnSelectWAV20_20.Enabled = False


            Me.cbbSound.Enabled = False
            Me.cbStartProWithCom.Enabled = False
            Me.btnPlayTimeNow.Enabled = False

            Me.cbShutdown.Enabled = False
            Me.cbHH_Shutdown.Enabled = False
            Me.cbmm_Shutdown.Enabled = False

            Me.cbFirst.Enabled = False
            Me.cbLast.Enabled = False
        End If
    End Sub
    Private Sub RINI()
        'เปิดโปรแกรมเวลาเปิดคอม
        If ReadIni(FileConfigINI_mcode, "start_with_con", "stariwithcom", "") = 1 Then
            Me.cbStartProWithCom.CheckState = CheckState.Checked
        Else
            Me.cbStartProWithCom.CheckState = CheckState.Unchecked
        End If

        Me.cbbSound.SelectedIndex = Me.cbbSound.FindStringExact(ReadIni(FileConfigINI_mcode, "bell", "s", ""))
        'shoutdown
        If ReadIni(FileConfigINI_mcode, "shout_down", "SH", "") = 1 Then
            Me.cbShutdown.CheckState = CheckState.Checked
        Else
            Me.cbShutdown.CheckState = CheckState.Unchecked
        End If

        Me.cbHH_Shutdown.SelectedItem = ReadIni(FileConfigINI_mcode, "shout_down", "time_HH", "")
        Me.cbmm_Shutdown.SelectedItem = ReadIni(FileConfigINI_mcode, "shout_down", "time_mm", "")

        'Play First Last .wav
        If ReadIni(FileConfigINI_mcode, "Play_FL", "F", "") = 1 Then
            Me.cbFirst.CheckState = CheckState.Checked
        Else
            Me.cbFirst.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "Play_FL", "L", "") = 1 Then
            Me.cbLast.CheckState = CheckState.Checked
        Else
            Me.cbLast.CheckState = CheckState.Unchecked
        End If

        'เวลาที่ 1
        If ReadIni(FileConfigINI_mcode, "param1", "work", "") = 1 Then
            Me.cbTime1.CheckState = CheckState.Checked
        Else
            Me.cbTime1.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param1", "palay_time", "") = 1 Then
            Me.cbStime1.CheckState = CheckState.Checked
        Else
            Me.cbStime1.CheckState = CheckState.Unchecked
        End If

        Me.cbHH1.SelectedItem = ReadIni(FileConfigINI_mcode, "param1", "time_HH", "")
        Me.cbmm1.SelectedItem = ReadIni(FileConfigINI_mcode, "param1", "time_mm", "")
        Me.txtPathWAV1.Text = ReadIni(FileConfigINI_mcode, "param1", "path", "")
        Me.txtPathWAV1_1.Text = ReadIni(FileConfigINI_mcode, "param1", "path1", "")

        'เวลาที่2
        If ReadIni(FileConfigINI_mcode, "param2", "work", "") = 1 Then
            Me.cbTime2.CheckState = CheckState.Checked
        Else
            Me.cbTime2.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param2", "palay_time", "") = 1 Then
            Me.cbStime2.CheckState = CheckState.Checked
        Else
            Me.cbStime2.CheckState = CheckState.Unchecked
        End If

        Me.cbHH2.SelectedItem = ReadIni(FileConfigINI_mcode, "param2", "time_HH", "")
        Me.cbmm2.SelectedItem = ReadIni(FileConfigINI_mcode, "param2", "time_mm", "")
        Me.txtPathWAV2.Text = ReadIni(FileConfigINI_mcode, "param2", "path", "")
        Me.txtPathWAV2_2.Text = ReadIni(FileConfigINI_mcode, "param2", "path1", "")

        'เวลาที่3
        If ReadIni(FileConfigINI_mcode, "param3", "work", "") = 1 Then
            Me.cbTime3.CheckState = CheckState.Checked
        Else
            Me.cbTime3.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param3", "palay_time", "") = 1 Then
            Me.cbStime3.CheckState = CheckState.Checked
        Else
            Me.cbStime3.CheckState = CheckState.Unchecked
        End If

        Me.cbHH3.SelectedItem = ReadIni(FileConfigINI_mcode, "param3", "time_HH", "")
        Me.cbmm3.SelectedItem = ReadIni(FileConfigINI_mcode, "param3", "time_mm", "")
        Me.txtPathWAV3.Text = ReadIni(FileConfigINI_mcode, "param3", "path", "")
        Me.txtPathWAV3_3.Text = ReadIni(FileConfigINI_mcode, "param3", "path1", "")

        'เวลาที่4
        If ReadIni(FileConfigINI_mcode, "param4", "work", "") = 1 Then
            Me.cbTime4.CheckState = CheckState.Checked
        Else
            Me.cbTime4.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param4", "palay_time", "") = 1 Then
            Me.cbStime4.CheckState = CheckState.Checked
        Else
            Me.cbStime4.CheckState = CheckState.Unchecked
        End If

        Me.cbHH4.SelectedItem = ReadIni(FileConfigINI_mcode, "param4", "time_HH", "")
        Me.cbmm4.SelectedItem = ReadIni(FileConfigINI_mcode, "param4", "time_mm", "")
        Me.txtPathWAV4.Text = ReadIni(FileConfigINI_mcode, "param4", "path", "")
        Me.txtPathWAV4_4.Text = ReadIni(FileConfigINI_mcode, "param4", "path1", "")

        'เวลาที่5
        If ReadIni(FileConfigINI_mcode, "param5", "work", "") = 1 Then
            Me.cbTime5.CheckState = CheckState.Checked
        Else
            Me.cbTime5.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param5", "palay_time", "") = 1 Then
            Me.cbStime5.CheckState = CheckState.Checked
        Else
            Me.cbStime5.CheckState = CheckState.Unchecked
        End If

        Me.cbHH5.SelectedItem = ReadIni(FileConfigINI_mcode, "param5", "time_HH", "")
        Me.cbmm5.SelectedItem = ReadIni(FileConfigINI_mcode, "param5", "time_mm", "")
        Me.txtPathWAV5.Text = ReadIni(FileConfigINI_mcode, "param5", "path", "")
        Me.txtPathWAV5_5.Text = ReadIni(FileConfigINI_mcode, "param5", "path1", "")

        'เวลาที่6
        If ReadIni(FileConfigINI_mcode, "param6", "work", "") = 1 Then
            Me.cbTime6.CheckState = CheckState.Checked
        Else
            Me.cbTime6.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param6", "palay_time", "") = 1 Then
            Me.cbStime6.CheckState = CheckState.Checked
        Else
            Me.cbStime6.CheckState = CheckState.Unchecked
        End If

        Me.cbHH6.SelectedItem = ReadIni(FileConfigINI_mcode, "param6", "time_HH", "")
        Me.cbmm6.SelectedItem = ReadIni(FileConfigINI_mcode, "param6", "time_mm", "")
        Me.txtPathWAV6.Text = ReadIni(FileConfigINI_mcode, "param6", "path", "")
        Me.txtPathWAV6_6.Text = ReadIni(FileConfigINI_mcode, "param6", "path1", "")

        'เวลาที่7
        If ReadIni(FileConfigINI_mcode, "param7", "work", "") = 1 Then
            Me.cbTime7.CheckState = CheckState.Checked
        Else
            Me.cbTime7.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param7", "palay_time", "") = 1 Then
            Me.cbStime7.CheckState = CheckState.Checked
        Else
            Me.cbStime7.CheckState = CheckState.Unchecked
        End If

        Me.cbHH7.SelectedItem = ReadIni(FileConfigINI_mcode, "param7", "time_HH", "")
        Me.cbmm7.SelectedItem = ReadIni(FileConfigINI_mcode, "param7", "time_mm", "")
        Me.txtPathWAV7.Text = ReadIni(FileConfigINI_mcode, "param7", "path", "")
        Me.txtPathWAV7_7.Text = ReadIni(FileConfigINI_mcode, "param7", "path1", "")

        'เวลาที่8
        If ReadIni(FileConfigINI_mcode, "param8", "work", "") = 1 Then
            Me.cbTime8.CheckState = CheckState.Checked
        Else
            Me.cbTime8.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param8", "palay_time", "") = 1 Then
            Me.cbStime8.CheckState = CheckState.Checked
        Else
            Me.cbStime8.CheckState = CheckState.Unchecked
        End If

        Me.cbHH8.SelectedItem = ReadIni(FileConfigINI_mcode, "param8", "time_HH", "")
        Me.cbmm8.SelectedItem = ReadIni(FileConfigINI_mcode, "param8", "time_mm", "")
        Me.txtPathWAV8.Text = ReadIni(FileConfigINI_mcode, "param8", "path", "")
        Me.txtPathWAV8_8.Text = ReadIni(FileConfigINI_mcode, "param8", "path1", "")

        'เวลาที่9
        If ReadIni(FileConfigINI_mcode, "param9", "work", "") = 1 Then
            Me.cbTime9.CheckState = CheckState.Checked
        Else
            Me.cbTime9.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param9", "palay_time", "") = 1 Then
            Me.cbStime9.CheckState = CheckState.Checked
        Else
            Me.cbStime9.CheckState = CheckState.Unchecked
        End If

        Me.cbHH9.SelectedItem = ReadIni(FileConfigINI_mcode, "param9", "time_HH", "")
        Me.cbmm9.SelectedItem = ReadIni(FileConfigINI_mcode, "param9", "time_mm", "")
        Me.txtPathWAV9.Text = ReadIni(FileConfigINI_mcode, "param9", "path", "")
        Me.txtPathWAV9_9.Text = ReadIni(FileConfigINI_mcode, "param9", "path1", "")

        'เวลาที่10
        If ReadIni(FileConfigINI_mcode, "param10", "work", "") = 1 Then
            Me.cbTime10.CheckState = CheckState.Checked
        Else
            Me.cbTime10.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param10", "palay_time", "") = 1 Then
            Me.cbStime10.CheckState = CheckState.Checked
        Else
            Me.cbStime10.CheckState = CheckState.Unchecked
        End If

        Me.cbHH10.SelectedItem = ReadIni(FileConfigINI_mcode, "param10", "time_HH", "")
        Me.cbmm10.SelectedItem = ReadIni(FileConfigINI_mcode, "param10", "time_mm", "")
        Me.txtPathWAV10.Text = ReadIni(FileConfigINI_mcode, "param10", "path", "")
        Me.txtPathWAV10_10.Text = ReadIni(FileConfigINI_mcode, "param10", "path1", "")

        'เวลาที่11
        If ReadIni(FileConfigINI_mcode, "param11", "work", "") = 1 Then
            Me.cbTime11.CheckState = CheckState.Checked
        Else
            Me.cbTime11.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param11", "palay_time", "") = 1 Then
            Me.cbStime11.CheckState = CheckState.Checked
        Else
            Me.cbStime11.CheckState = CheckState.Unchecked
        End If

        Me.cbHH11.SelectedItem = ReadIni(FileConfigINI_mcode, "param11", "time_HH", "")
        Me.cbmm11.SelectedItem = ReadIni(FileConfigINI_mcode, "param11", "time_mm", "")
        Me.txtPathWAV11.Text = ReadIni(FileConfigINI_mcode, "param11", "path", "")
        Me.txtPathWAV11_11.Text = ReadIni(FileConfigINI_mcode, "param11", "path1", "")

        'เวลาที่12
        If ReadIni(FileConfigINI_mcode, "param12", "work", "") = 1 Then
            Me.cbTime12.CheckState = CheckState.Checked
        Else
            Me.cbTime12.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param12", "palay_time", "") = 1 Then
            Me.cbStime12.CheckState = CheckState.Checked
        Else
            Me.cbStime12.CheckState = CheckState.Unchecked
        End If

        Me.cbHH12.SelectedItem = ReadIni(FileConfigINI_mcode, "param12", "time_HH", "")
        Me.cbmm12.SelectedItem = ReadIni(FileConfigINI_mcode, "param12", "time_mm", "")
        Me.txtPathWAV12.Text = ReadIni(FileConfigINI_mcode, "param12", "path", "")
        Me.txtPathWAV12_12.Text = ReadIni(FileConfigINI_mcode, "param12", "path1", "")

        'เวลาที่13
        If ReadIni(FileConfigINI_mcode, "param13", "work", "") = 1 Then
            Me.cbTime13.CheckState = CheckState.Checked
        Else
            Me.cbTime13.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param13", "palay_time", "") = 1 Then
            Me.cbStime13.CheckState = CheckState.Checked
        Else
            Me.cbStime13.CheckState = CheckState.Unchecked
        End If

        Me.cbHH13.SelectedItem = ReadIni(FileConfigINI_mcode, "param13", "time_HH", "")
        Me.cbmm13.SelectedItem = ReadIni(FileConfigINI_mcode, "param13", "time_mm", "")
        Me.txtPathWAV13.Text = ReadIni(FileConfigINI_mcode, "param13", "path", "")
        Me.txtPathWAV13_13.Text = ReadIni(FileConfigINI_mcode, "param13", "path1", "")

        'เวลาที่14
        If ReadIni(FileConfigINI_mcode, "param14", "work", "") = 1 Then
            Me.cbTime14.CheckState = CheckState.Checked
        Else
            Me.cbTime14.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param14", "palay_time", "") = 1 Then
            Me.cbStime14.CheckState = CheckState.Checked
        Else
            Me.cbStime14.CheckState = CheckState.Unchecked
        End If

        Me.cbHH14.SelectedItem = ReadIni(FileConfigINI_mcode, "param14", "time_HH", "")
        Me.cbmm14.SelectedItem = ReadIni(FileConfigINI_mcode, "param14", "time_mm", "")
        Me.txtPathWAV14.Text = ReadIni(FileConfigINI_mcode, "param14", "path", "")
        Me.txtPathWAV14_14.Text = ReadIni(FileConfigINI_mcode, "param14", "path1", "")

        'เวลาที่15
        If ReadIni(FileConfigINI_mcode, "param15", "work", "") = 1 Then
            Me.cbTime15.CheckState = CheckState.Checked
        Else
            Me.cbTime15.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param15", "palay_time", "") = 1 Then
            Me.cbStime15.CheckState = CheckState.Checked
        Else
            Me.cbStime15.CheckState = CheckState.Unchecked
        End If

        Me.cbHH15.SelectedItem = ReadIni(FileConfigINI_mcode, "param15", "time_HH", "")
        Me.cbmm15.SelectedItem = ReadIni(FileConfigINI_mcode, "param15", "time_mm", "")
        Me.txtPathWAV15.Text = ReadIni(FileConfigINI_mcode, "param15", "path", "")
        Me.txtPathWAV15_15.Text = ReadIni(FileConfigINI_mcode, "param15", "path1", "")

        'เวลาที่16
        If ReadIni(FileConfigINI_mcode, "param16", "work", "") = 1 Then
            Me.cbTime16.CheckState = CheckState.Checked
        Else
            Me.cbTime16.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param16", "palay_time", "") = 1 Then
            Me.cbStime16.CheckState = CheckState.Checked
        Else
            Me.cbStime16.CheckState = CheckState.Unchecked
        End If

        Me.cbHH16.SelectedItem = ReadIni(FileConfigINI_mcode, "param16", "time_HH", "")
        Me.cbmm16.SelectedItem = ReadIni(FileConfigINI_mcode, "param16", "time_mm", "")
        Me.txtPathWAV16.Text = ReadIni(FileConfigINI_mcode, "param16", "path", "")
        Me.txtPathWAV16_16.Text = ReadIni(FileConfigINI_mcode, "param16", "path1", "")

        'เวลาที่17
        If ReadIni(FileConfigINI_mcode, "param17", "work", "") = 1 Then
            Me.cbTime17.CheckState = CheckState.Checked
        Else
            Me.cbTime17.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param17", "palay_time", "") = 1 Then
            Me.cbStime17.CheckState = CheckState.Checked
        Else
            Me.cbStime17.CheckState = CheckState.Unchecked
        End If

        Me.cbHH17.SelectedItem = ReadIni(FileConfigINI_mcode, "param17", "time_HH", "")
        Me.cbmm17.SelectedItem = ReadIni(FileConfigINI_mcode, "param17", "time_mm", "")
        Me.txtPathWAV17.Text = ReadIni(FileConfigINI_mcode, "param17", "path", "")
        Me.txtPathWAV17_17.Text = ReadIni(FileConfigINI_mcode, "param17", "path1", "")

        'เวลาที่18
        If ReadIni(FileConfigINI_mcode, "param18", "work", "") = 1 Then
            Me.cbTime18.CheckState = CheckState.Checked
        Else
            Me.cbTime18.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param18", "palay_time", "") = 1 Then
            Me.cbStime18.CheckState = CheckState.Checked
        Else
            Me.cbStime18.CheckState = CheckState.Unchecked
        End If

        Me.cbHH18.SelectedItem = ReadIni(FileConfigINI_mcode, "param18", "time_HH", "")
        Me.cbmm18.SelectedItem = ReadIni(FileConfigINI_mcode, "param18", "time_mm", "")
        Me.txtPathWAV18.Text = ReadIni(FileConfigINI_mcode, "param18", "path", "")
        Me.txtPathWAV18_18.Text = ReadIni(FileConfigINI_mcode, "param18", "path1", "")

        'เวลาที่19
        If ReadIni(FileConfigINI_mcode, "param19", "work", "") = 1 Then
            Me.cbTime19.CheckState = CheckState.Checked
        Else
            Me.cbTime19.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param19", "palay_time", "") = 1 Then
            Me.cbStime19.CheckState = CheckState.Checked
        Else
            Me.cbStime19.CheckState = CheckState.Unchecked
        End If

        Me.cbHH19.SelectedItem = ReadIni(FileConfigINI_mcode, "param19", "time_HH", "")
        Me.cbmm19.SelectedItem = ReadIni(FileConfigINI_mcode, "param19", "time_mm", "")
        Me.txtPathWAV19.Text = ReadIni(FileConfigINI_mcode, "param19", "path", "")
        Me.txtPathWAV19_19.Text = ReadIni(FileConfigINI_mcode, "param19", "path1", "")

        'เวลาที่20
        If ReadIni(FileConfigINI_mcode, "param20", "work", "") = 1 Then
            Me.cbTime20.CheckState = CheckState.Checked
        Else
            Me.cbTime20.CheckState = CheckState.Unchecked
        End If

        If ReadIni(FileConfigINI_mcode, "param20", "palay_time", "") = 1 Then
            Me.cbStime20.CheckState = CheckState.Checked
        Else
            Me.cbStime20.CheckState = CheckState.Unchecked
        End If

        Me.cbHH20.SelectedItem = ReadIni(FileConfigINI_mcode, "param20", "time_HH", "")
        Me.cbmm20.SelectedItem = ReadIni(FileConfigINI_mcode, "param20", "time_mm", "")
        Me.txtPathWAV20.Text = ReadIni(FileConfigINI_mcode, "param20", "path", "")
        Me.txtPathWAV20_20.Text = ReadIni(FileConfigINI_mcode, "param20", "path1", "")
    End Sub

    Private Sub SINI()
        'เปิดโปรแกรมเวลาเปิดคอม
        If Me.cbStartProWithCom.Checked = True Then
            writeIni(FileConfigINI_mcode, "start_with_con", "stariwithcom", "1")
        Else
            writeIni(FileConfigINI_mcode, "start_with_con", "stariwithcom", "0")
        End If

        If Me.cbStartProWithCom.Checked = True Then
            Try
                Dim CU As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
                With CU
                    .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                    .SetValue("SchoolAod", Application.StartupPath & "\SchoolAod.exe")
                End With

            Catch ex As Exception

            End Try
        End If
        If Me.cbStartProWithCom.Checked = False Then
            Try
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", True).DeleteValue("SchoolAod")

            Catch ex As Exception

            End Try
        End If

        writeIni(FileConfigINI_mcode, "bell", "s", Me.cbbSound.Text)
        'shoutdown
        If Me.cbShutdown.Checked = True Then
            writeIni(FileConfigINI_mcode, "shout_down", "SH", "1")
        Else
            writeIni(FileConfigINI_mcode, "shout_down", "SH", "0")
        End If

        writeIni(FileConfigINI_mcode, "shout_down", "time_HH", Me.cbHH_Shutdown.Text)
        writeIni(FileConfigINI_mcode, "shout_down", "time_mm", Me.cbmm_Shutdown.Text)

        'Play First Last .wav
        If Me.cbFirst.Checked = True Then
            writeIni(FileConfigINI_mcode, "Play_FL", "F", "1")
        Else
            writeIni(FileConfigINI_mcode, "Play_FL", "F", "0")
        End If

        If Me.cbLast.Checked = True Then
            writeIni(FileConfigINI_mcode, "Play_FL", "L", "1")
        Else
            writeIni(FileConfigINI_mcode, "Play_FL", "L", "0")
        End If
        'เวลาที่ 1
        If Me.cbTime1.Checked = True Then
            writeIni(FileConfigINI_mcode, "param1", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param1", "work", "0")
        End If

        If Me.cbStime1.Checked = True Then
            writeIni(FileConfigINI_mcode, "param1", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param1", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param1", "time_HH", Me.cbHH1.Text)
        writeIni(FileConfigINI_mcode, "param1", "time_mm", Me.cbmm1.Text)
        writeIni(FileConfigINI_mcode, "param1", "path", Me.txtPathWAV1.Text)
        writeIni(FileConfigINI_mcode, "param1", "path1", Me.txtPathWAV1_1.Text)

        'เวลาที่ 2
        If Me.cbTime2.Checked = True Then
            writeIni(FileConfigINI_mcode, "param2", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param2", "work", "0")
        End If

        If Me.cbStime2.Checked = True Then
            writeIni(FileConfigINI_mcode, "param2", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param2", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param2", "time_HH", Me.cbHH2.Text)
        writeIni(FileConfigINI_mcode, "param2", "time_mm", Me.cbmm2.Text)
        writeIni(FileConfigINI_mcode, "param2", "path", Me.txtPathWAV2.Text)
        writeIni(FileConfigINI_mcode, "param2", "path1", Me.txtPathWAV2_2.Text)

        'เวลาที่ 3
        If Me.cbTime3.Checked = True Then
            writeIni(FileConfigINI_mcode, "param3", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param3", "work", "0")
        End If

        If Me.cbStime3.Checked = True Then
            writeIni(FileConfigINI_mcode, "param3", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param3", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param3", "time_HH", Me.cbHH3.Text)
        writeIni(FileConfigINI_mcode, "param3", "time_mm", Me.cbmm3.Text)
        writeIni(FileConfigINI_mcode, "param3", "path", Me.txtPathWAV3.Text)
        writeIni(FileConfigINI_mcode, "param3", "path1", Me.txtPathWAV3_3.Text)

        'เวลาที่ 4
        If Me.cbTime4.Checked = True Then
            writeIni(FileConfigINI_mcode, "param4", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param4", "work", "0")
        End If

        If Me.cbStime4.Checked = True Then
            writeIni(FileConfigINI_mcode, "param4", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param4", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param4", "time_HH", Me.cbHH4.Text)
        writeIni(FileConfigINI_mcode, "param4", "time_mm", Me.cbmm4.Text)
        writeIni(FileConfigINI_mcode, "param4", "path", Me.txtPathWAV4.Text)
        writeIni(FileConfigINI_mcode, "param4", "path1", Me.txtPathWAV4_4.Text)

        'เวลาที่ 5
        If Me.cbTime5.Checked = True Then
            writeIni(FileConfigINI_mcode, "param5", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param5", "work", "0")
        End If

        If Me.cbStime5.Checked = True Then
            writeIni(FileConfigINI_mcode, "param5", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param5", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param5", "time_HH", Me.cbHH5.Text)
        writeIni(FileConfigINI_mcode, "param5", "time_mm", Me.cbmm5.Text)
        writeIni(FileConfigINI_mcode, "param5", "path", Me.txtPathWAV5.Text)
        writeIni(FileConfigINI_mcode, "param5", "path1", Me.txtPathWAV5_5.Text)

        'เวลาที่ 6
        If Me.cbTime6.Checked = True Then
            writeIni(FileConfigINI_mcode, "param6", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param6", "work", "0")
        End If

        If Me.cbStime6.Checked = True Then
            writeIni(FileConfigINI_mcode, "param6", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param6", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param6", "time_HH", Me.cbHH6.Text)
        writeIni(FileConfigINI_mcode, "param6", "time_mm", Me.cbmm6.Text)
        writeIni(FileConfigINI_mcode, "param6", "path", Me.txtPathWAV6.Text)
        writeIni(FileConfigINI_mcode, "param6", "path1", Me.txtPathWAV6_6.Text)

        'เวลาที่ 7
        If Me.cbTime7.Checked = True Then
            writeIni(FileConfigINI_mcode, "param7", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param7", "work", "0")
        End If

        If Me.cbStime7.Checked = True Then
            writeIni(FileConfigINI_mcode, "param7", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param7", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param7", "time_HH", Me.cbHH7.Text)
        writeIni(FileConfigINI_mcode, "param7", "time_mm", Me.cbmm7.Text)
        writeIni(FileConfigINI_mcode, "param7", "path", Me.txtPathWAV7.Text)
        writeIni(FileConfigINI_mcode, "param7", "path1", Me.txtPathWAV7_7.Text)

        'เวลาที่ 8
        If Me.cbTime8.Checked = True Then
            writeIni(FileConfigINI_mcode, "param8", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param8", "work", "0")
        End If

        If Me.cbStime8.Checked = True Then
            writeIni(FileConfigINI_mcode, "param8", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param8", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param8", "time_HH", Me.cbHH8.Text)
        writeIni(FileConfigINI_mcode, "param8", "time_mm", Me.cbmm8.Text)
        writeIni(FileConfigINI_mcode, "param8", "path", Me.txtPathWAV8.Text)
        writeIni(FileConfigINI_mcode, "param8", "path1", Me.txtPathWAV8_8.Text)

        'เวลาที่ 9
        If Me.cbTime9.Checked = True Then
            writeIni(FileConfigINI_mcode, "param9", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param9", "work", "0")
        End If

        If Me.cbStime9.Checked = True Then
            writeIni(FileConfigINI_mcode, "param9", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param9", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param9", "time_HH", Me.cbHH9.Text)
        writeIni(FileConfigINI_mcode, "param9", "time_mm", Me.cbmm9.Text)
        writeIni(FileConfigINI_mcode, "param9", "path", Me.txtPathWAV9.Text)
        writeIni(FileConfigINI_mcode, "param9", "path1", Me.txtPathWAV9_9.Text)

        'เวลาที่ 10
        If Me.cbTime10.Checked = True Then
            writeIni(FileConfigINI_mcode, "param10", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param10", "work", "0")
        End If

        If Me.cbStime10.Checked = True Then
            writeIni(FileConfigINI_mcode, "param10", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param10", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param10", "time_HH", Me.cbHH10.Text)
        writeIni(FileConfigINI_mcode, "param10", "time_mm", Me.cbmm10.Text)
        writeIni(FileConfigINI_mcode, "param10", "path", Me.txtPathWAV10.Text)
        writeIni(FileConfigINI_mcode, "param10", "path1", Me.txtPathWAV10_10.Text)

        'เวลาที่ 11
        If Me.cbTime11.Checked = True Then
            writeIni(FileConfigINI_mcode, "param11", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param11", "work", "0")
        End If

        If Me.cbStime11.Checked = True Then
            writeIni(FileConfigINI_mcode, "param11", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param11", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param11", "time_HH", Me.cbHH11.Text)
        writeIni(FileConfigINI_mcode, "param11", "time_mm", Me.cbmm11.Text)
        writeIni(FileConfigINI_mcode, "param11", "path", Me.txtPathWAV11.Text)
        writeIni(FileConfigINI_mcode, "param11", "path1", Me.txtPathWAV11_11.Text)

        'เวลาที่ 12
        If Me.cbTime12.Checked = True Then
            writeIni(FileConfigINI_mcode, "param12", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param12", "work", "0")
        End If

        If Me.cbStime12.Checked = True Then
            writeIni(FileConfigINI_mcode, "param12", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param12", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param12", "time_HH", Me.cbHH12.Text)
        writeIni(FileConfigINI_mcode, "param12", "time_mm", Me.cbmm12.Text)
        writeIni(FileConfigINI_mcode, "param12", "path", Me.txtPathWAV12.Text)
        writeIni(FileConfigINI_mcode, "param12", "path1", Me.txtPathWAV12_12.Text)

        'เวลาที่ 13
        If Me.cbTime13.Checked = True Then
            writeIni(FileConfigINI_mcode, "param13", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param13", "work", "0")
        End If

        If Me.cbStime13.Checked = True Then
            writeIni(FileConfigINI_mcode, "param13", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param13", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param13", "time_HH", Me.cbHH13.Text)
        writeIni(FileConfigINI_mcode, "param13", "time_mm", Me.cbmm13.Text)
        writeIni(FileConfigINI_mcode, "param13", "path", Me.txtPathWAV13.Text)
        writeIni(FileConfigINI_mcode, "param13", "path1", Me.txtPathWAV13_13.Text)

        'เวลาที่ 14
        If Me.cbTime14.Checked = True Then
            writeIni(FileConfigINI_mcode, "param14", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param14", "work", "0")
        End If

        If Me.cbStime14.Checked = True Then
            writeIni(FileConfigINI_mcode, "param14", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param14", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param14", "time_HH", Me.cbHH14.Text)
        writeIni(FileConfigINI_mcode, "param14", "time_mm", Me.cbmm14.Text)
        writeIni(FileConfigINI_mcode, "param14", "path", Me.txtPathWAV14.Text)
        writeIni(FileConfigINI_mcode, "param14", "path1", Me.txtPathWAV14_14.Text)

        'เวลาที่ 15
        If Me.cbTime15.Checked = True Then
            writeIni(FileConfigINI_mcode, "param15", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param15", "work", "0")
        End If

        If Me.cbStime15.Checked = True Then
            writeIni(FileConfigINI_mcode, "param15", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param15", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param15", "time_HH", Me.cbHH15.Text)
        writeIni(FileConfigINI_mcode, "param15", "time_mm", Me.cbmm15.Text)
        writeIni(FileConfigINI_mcode, "param15", "path", Me.txtPathWAV15.Text)
        writeIni(FileConfigINI_mcode, "param15", "path1", Me.txtPathWAV15_15.Text)

        'เวลาที่ 16
        If Me.cbTime16.Checked = True Then
            writeIni(FileConfigINI_mcode, "param16", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param16", "work", "0")
        End If

        If Me.cbStime16.Checked = True Then
            writeIni(FileConfigINI_mcode, "param16", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param16", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param16", "time_HH", Me.cbHH16.Text)
        writeIni(FileConfigINI_mcode, "param16", "time_mm", Me.cbmm16.Text)
        writeIni(FileConfigINI_mcode, "param16", "path", Me.txtPathWAV16.Text)
        writeIni(FileConfigINI_mcode, "param16", "path1", Me.txtPathWAV16_16.Text)

        'เวลาที่ 17
        If Me.cbTime17.Checked = True Then
            writeIni(FileConfigINI_mcode, "param17", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param17", "work", "0")
        End If

        If Me.cbStime17.Checked = True Then
            writeIni(FileConfigINI_mcode, "param17", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param17", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param17", "time_HH", Me.cbHH17.Text)
        writeIni(FileConfigINI_mcode, "param17", "time_mm", Me.cbmm17.Text)
        writeIni(FileConfigINI_mcode, "param17", "path", Me.txtPathWAV17.Text)
        writeIni(FileConfigINI_mcode, "param17", "path1", Me.txtPathWAV17_17.Text)

        'เวลาที่ 18
        If Me.cbTime18.Checked = True Then
            writeIni(FileConfigINI_mcode, "param18", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param18", "work", "0")
        End If

        If Me.cbStime18.Checked = True Then
            writeIni(FileConfigINI_mcode, "param18", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param18", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param18", "time_HH", Me.cbHH18.Text)
        writeIni(FileConfigINI_mcode, "param18", "time_mm", Me.cbmm18.Text)
        writeIni(FileConfigINI_mcode, "param18", "path", Me.txtPathWAV18.Text)
        writeIni(FileConfigINI_mcode, "param18", "path1", Me.txtPathWAV18_18.Text)

        'เวลาที่ 19
        If Me.cbTime19.Checked = True Then
            writeIni(FileConfigINI_mcode, "param19", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param19", "work", "0")
        End If

        If Me.cbStime19.Checked = True Then
            writeIni(FileConfigINI_mcode, "param19", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param19", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param19", "time_HH", Me.cbHH19.Text)
        writeIni(FileConfigINI_mcode, "param19", "time_mm", Me.cbmm19.Text)
        writeIni(FileConfigINI_mcode, "param19", "path", Me.txtPathWAV19.Text)
        writeIni(FileConfigINI_mcode, "param19", "path1", Me.txtPathWAV19_19.Text)

        'เวลาที่ 20
        If Me.cbTime20.Checked = True Then
            writeIni(FileConfigINI_mcode, "param20", "work", "1")
        Else
            writeIni(FileConfigINI_mcode, "param20", "work", "0")
        End If

        If Me.cbStime20.Checked = True Then
            writeIni(FileConfigINI_mcode, "param20", "palay_time", "1")
        Else
            writeIni(FileConfigINI_mcode, "param20", "palay_time", "0")
        End If

        writeIni(FileConfigINI_mcode, "param20", "time_HH", Me.cbHH20.Text)
        writeIni(FileConfigINI_mcode, "param20", "time_mm", Me.cbmm20.Text)
        writeIni(FileConfigINI_mcode, "param20", "path", Me.txtPathWAV20.Text)
        writeIni(FileConfigINI_mcode, "param20", "path1", Me.txtPathWAV20_20.Text)
    End Sub

    ''' <summary>
    ''' PlayTime สำหรับเล่นไฟล์เสียงออกมา โดยมาพารามิเตอร์ ที่จำเป็นดังนี้
    ''' </summary>
    ''' <param name="spek_time">บอกเวลา ค่า 0=ไม่บอกเวลา 1=บอกเวลา ในรูปแบบสตริง</param>
    ''' <param name="hh">ค่าเวลา ชั่วโมงเป็นตัวเลข 0 - 24 ในรูปแบบสตริง</param>
    ''' <param name="mm">ค่าเวลา นาที เป็นตัวเลข 0 - 59 ในรูปแบบสตริง</param>
    ''' <param name="wavPath1">ไฟล์เสียงที่ต้องการให้เล่นในช่วงเวลานั้น นามสกุล wav เท่านั้น ในรูปแบบสตริง</param>
    '''  ''' <param name="wavPath2">ไฟล์เสียงที่ต้องการให้เล่นในช่วงเวลานั้น นามสกุล wav เท่านั้น ในรูปแบบสตริง</param>
    ''' <remarks></remarks>

    Function PlayTime(ByVal spek_time, ByVal hh, ByVal mm, ByVal wavPath1, ByVal wavPath2)
        If Me.cbFirst.Checked = True Then
            My.Computer.Audio.Play(Application.StartupPath & "\audio\bell\" & Me.cbbSound.Text & "\First.wav", AudioPlayMode.WaitToComplete)
        End If
        If spek_time = 1 Then
            Try
                My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\now.wav", AudioPlayMode.WaitToComplete)
                Select Case hh
                    Case "0" Or "00"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\00.wav", AudioPlayMode.WaitToComplete)
                    Case "01"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\01.wav", AudioPlayMode.WaitToComplete)
                    Case "02"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\02.wav", AudioPlayMode.WaitToComplete)
                    Case "03"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\03.wav", AudioPlayMode.WaitToComplete)
                    Case "04"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\04.wav", AudioPlayMode.WaitToComplete)
                    Case "05"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\05.wav", AudioPlayMode.WaitToComplete)
                    Case "06"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\06.wav", AudioPlayMode.WaitToComplete)
                    Case "07"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\07.wav", AudioPlayMode.WaitToComplete)
                    Case "08"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\08.wav", AudioPlayMode.WaitToComplete)
                    Case "09"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\09.wav", AudioPlayMode.WaitToComplete)
                    Case "10"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\10.wav", AudioPlayMode.WaitToComplete)
                    Case "11"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\11.wav", AudioPlayMode.WaitToComplete)
                    Case "12"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\12.wav", AudioPlayMode.WaitToComplete)
                    Case "13"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\13.wav", AudioPlayMode.WaitToComplete)
                    Case "14"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\14.wav", AudioPlayMode.WaitToComplete)
                    Case "15"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\15.wav", AudioPlayMode.WaitToComplete)
                    Case "16"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\16.wav", AudioPlayMode.WaitToComplete)
                    Case "17"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\17.wav", AudioPlayMode.WaitToComplete)
                    Case "18"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\18.wav", AudioPlayMode.WaitToComplete)
                    Case "19"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\19.wav", AudioPlayMode.WaitToComplete)
                    Case "20"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\20.wav", AudioPlayMode.WaitToComplete)
                    Case "21"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\21.wav", AudioPlayMode.WaitToComplete)
                    Case "22"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\22.wav", AudioPlayMode.WaitToComplete)
                    Case "23"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\23.wav", AudioPlayMode.WaitToComplete)
                    Case "24"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\24.wav", AudioPlayMode.WaitToComplete)
                End Select

                My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\oclock.wav", AudioPlayMode.WaitToComplete)
                Select Case mm
                    Case "0" Or "00"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\00.wav", AudioPlayMode.WaitToComplete)
                        GoTo endsero
                    Case "01"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\01.wav", AudioPlayMode.WaitToComplete)
                    Case "02"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\02.wav", AudioPlayMode.WaitToComplete)
                    Case "03"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\03.wav", AudioPlayMode.WaitToComplete)
                    Case "04"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\04.wav", AudioPlayMode.WaitToComplete)
                    Case "05"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\05.wav", AudioPlayMode.WaitToComplete)
                    Case "06"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\06.wav", AudioPlayMode.WaitToComplete)
                    Case "07"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\07.wav", AudioPlayMode.WaitToComplete)
                    Case "08"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\08.wav", AudioPlayMode.WaitToComplete)
                    Case "09"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\09.wav", AudioPlayMode.WaitToComplete)
                    Case "10"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\10.wav", AudioPlayMode.WaitToComplete)
                    Case "11"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\11.wav", AudioPlayMode.WaitToComplete)
                    Case "12"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\12.wav", AudioPlayMode.WaitToComplete)
                    Case "13"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\13.wav", AudioPlayMode.WaitToComplete)
                    Case "14"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\14.wav", AudioPlayMode.WaitToComplete)
                    Case "15"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\15.wav", AudioPlayMode.WaitToComplete)
                    Case "16"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\16.wav", AudioPlayMode.WaitToComplete)
                    Case "17"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\17.wav", AudioPlayMode.WaitToComplete)
                    Case "18"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\18.wav", AudioPlayMode.WaitToComplete)
                    Case "19"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\19.wav", AudioPlayMode.WaitToComplete)
                    Case "20"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\20.wav", AudioPlayMode.WaitToComplete)
                    Case "21"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\21.wav", AudioPlayMode.WaitToComplete)
                    Case "22"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\22.wav", AudioPlayMode.WaitToComplete)
                    Case "23"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\23.wav", AudioPlayMode.WaitToComplete)
                    Case "24"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\24.wav", AudioPlayMode.WaitToComplete)
                    Case "25"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\25.wav", AudioPlayMode.WaitToComplete)
                    Case "26"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\26.wav", AudioPlayMode.WaitToComplete)
                    Case "27"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\27.wav", AudioPlayMode.WaitToComplete)
                    Case "28"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\28.wav", AudioPlayMode.WaitToComplete)
                    Case "29"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\29.wav", AudioPlayMode.WaitToComplete)
                    Case "30"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\30.wav", AudioPlayMode.WaitToComplete)
                    Case "31"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\31.wav", AudioPlayMode.WaitToComplete)
                    Case "32"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\32.wav", AudioPlayMode.WaitToComplete)
                    Case "33"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\33.wav", AudioPlayMode.WaitToComplete)
                    Case "34"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\34.wav", AudioPlayMode.WaitToComplete)
                    Case "35"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\35.wav", AudioPlayMode.WaitToComplete)
                    Case "36"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\36.wav", AudioPlayMode.WaitToComplete)
                    Case "37"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\37.wav", AudioPlayMode.WaitToComplete)
                    Case "38"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\38.wav", AudioPlayMode.WaitToComplete)
                    Case "39"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\39.wav", AudioPlayMode.WaitToComplete)
                    Case "40"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\40.wav", AudioPlayMode.WaitToComplete)
                    Case "41"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\41.wav", AudioPlayMode.WaitToComplete)
                    Case "42"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\42.wav", AudioPlayMode.WaitToComplete)
                    Case "43"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\43.wav", AudioPlayMode.WaitToComplete)
                    Case "44"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\44.wav", AudioPlayMode.WaitToComplete)
                    Case "45"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\45.wav", AudioPlayMode.WaitToComplete)
                    Case "46"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\46.wav", AudioPlayMode.WaitToComplete)
                    Case "47"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\47.wav", AudioPlayMode.WaitToComplete)
                    Case "48"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\48.wav", AudioPlayMode.WaitToComplete)
                    Case "49"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\49.wav", AudioPlayMode.WaitToComplete)
                    Case "50"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\50.wav", AudioPlayMode.WaitToComplete)
                    Case "51"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\51.wav", AudioPlayMode.WaitToComplete)
                    Case "52"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\52.wav", AudioPlayMode.WaitToComplete)
                    Case "53"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\53.wav", AudioPlayMode.WaitToComplete)
                    Case "54"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\54.wav", AudioPlayMode.WaitToComplete)
                    Case "55"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\55.wav", AudioPlayMode.WaitToComplete)
                    Case "56"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\56.wav", AudioPlayMode.WaitToComplete)
                    Case "57"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\57.wav", AudioPlayMode.WaitToComplete)
                    Case "58"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\58.wav", AudioPlayMode.WaitToComplete)
                    Case "59"
                        My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\59.wav", AudioPlayMode.WaitToComplete)
                End Select
                My.Computer.Audio.Play(Application.StartupPath & "\audio\thai\time\min.wav", AudioPlayMode.WaitToComplete)
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
endsero:
        End If

        Try
            My.Computer.Audio.Play(wavPath1, AudioPlayMode.WaitToComplete)
        Catch ex As Exception

        End Try

        Try
            My.Computer.Audio.Play(wavPath2, AudioPlayMode.WaitToComplete)
        Catch ex As Exception

        End Try
        If Me.cbLast.Checked = True Then
            My.Computer.Audio.Play(Application.StartupPath & "\audio\bell\" & Me.cbbSound.Text & "\Last.wav", AudioPlayMode.WaitToComplete)
        End If
        Return Nothing
    End Function

    Private Sub runtime(ByVal hh, ByVal mm, ByVal ss)
        Select Case hh & mm & ss
            Case Me.cbHH1.Text & Me.cbmm1.Text & "00"
                If Me.cbTime1.Checked = True Then
                    If cbStime1.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV1.Text, Me.txtPathWAV1_1.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV1.Text, Me.txtPathWAV1_1.Text)
                    End If
                End If
            Case Me.cbHH2.Text & Me.cbmm2.Text & "00"
                If Me.cbTime2.Checked = True Then
                    If cbStime2.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV2.Text, Me.txtPathWAV2_2.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV2.Text, Me.txtPathWAV2_2.Text)
                    End If
                End If
            Case Me.cbHH3.Text & Me.cbmm3.Text & "00"
                If Me.cbTime3.Checked = True Then
                    If cbStime3.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV3.Text, Me.txtPathWAV3_3.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV3.Text, Me.txtPathWAV3_3.Text)
                    End If
                End If
            Case Me.cbHH4.Text & Me.cbmm4.Text & "00"
                If Me.cbTime4.Checked = True Then
                    If cbStime4.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV4.Text, Me.txtPathWAV4_4.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV4.Text, Me.txtPathWAV4_4.Text)
                    End If
                End If
            Case Me.cbHH5.Text & Me.cbmm5.Text & "00"
                If Me.cbTime5.Checked = True Then
                    If cbStime5.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV5.Text, Me.txtPathWAV5_5.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV5.Text, Me.txtPathWAV5_5.Text)
                    End If
                End If
            Case Me.cbHH6.Text & Me.cbmm6.Text & "00"
                If Me.cbTime6.Checked = True Then
                    If cbStime6.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV6.Text, Me.txtPathWAV6_6.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV6.Text, Me.txtPathWAV6_6.Text)
                    End If
                End If
            Case Me.cbHH7.Text & Me.cbmm7.Text & "00"
                If Me.cbTime7.Checked = True Then
                    If cbStime7.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV7.Text, Me.txtPathWAV7_7.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV7.Text, Me.txtPathWAV7_7.Text)
                    End If
                End If
            Case Me.cbHH8.Text & Me.cbmm8.Text & "00"
                If Me.cbTime8.Checked = True Then
                    If cbStime8.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV8.Text, Me.txtPathWAV8_8.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV8.Text, Me.txtPathWAV8_8.Text)
                    End If
                End If
            Case Me.cbHH9.Text & Me.cbmm9.Text & "00"
                If Me.cbTime9.Checked = True Then
                    If cbStime9.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV9.Text, Me.txtPathWAV9_9.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV9.Text, Me.txtPathWAV9_9.Text)
                    End If
                End If
            Case Me.cbHH10.Text & Me.cbmm10.Text & "00"
                If Me.cbTime10.Checked = True Then
                    If cbStime10.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV10.Text, Me.txtPathWAV10_10.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV10.Text, Me.txtPathWAV10_10.Text)
                    End If
                End If
            Case Me.cbHH11.Text & Me.cbmm11.Text & "00"
                If Me.cbTime11.Checked = True Then
                    If cbStime11.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV11.Text, Me.txtPathWAV11_11.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV11.Text, Me.txtPathWAV11_11.Text)
                    End If
                End If
            Case Me.cbHH12.Text & Me.cbmm12.Text & "00"
                If Me.cbTime12.Checked = True Then
                    If cbStime12.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV12.Text, Me.txtPathWAV12_12.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV12.Text, Me.txtPathWAV12_12.Text)
                    End If
                End If
            Case Me.cbHH13.Text & Me.cbmm13.Text & "00"
                If Me.cbTime13.Checked = True Then
                    If cbStime13.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV13.Text, Me.txtPathWAV13_13.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV13.Text, Me.txtPathWAV13_13.Text)
                    End If
                End If
            Case Me.cbHH14.Text & Me.cbmm14.Text & "00"
                If Me.cbTime14.Checked = True Then
                    If cbStime14.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV14.Text, Me.txtPathWAV14_14.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV14.Text, Me.txtPathWAV14_14.Text)
                    End If
                End If
            Case Me.cbHH15.Text & Me.cbmm15.Text & "00"
                If Me.cbTime15.Checked = True Then
                    If cbStime15.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV15.Text, Me.txtPathWAV15_15.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV15.Text, Me.txtPathWAV15_15.Text)
                    End If
                End If
            Case Me.cbHH16.Text & Me.cbmm16.Text & "00"
                If Me.cbTime16.Checked = True Then
                    If cbStime16.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV16.Text, Me.txtPathWAV16_16.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV16.Text, Me.txtPathWAV16_16.Text)
                    End If
                End If
            Case Me.cbHH17.Text & Me.cbmm17.Text & "00"
                If Me.cbTime17.Checked = True Then
                    If cbStime17.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV17.Text, Me.txtPathWAV17_17.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV17.Text, Me.txtPathWAV17_17.Text)
                    End If
                End If
            Case Me.cbHH18.Text & Me.cbmm18.Text & "00"
                If Me.cbTime18.Checked = True Then
                    If cbStime18.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV18.Text, Me.txtPathWAV18_18.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV18.Text, Me.txtPathWAV18_18.Text)
                    End If
                End If
            Case Me.cbHH19.Text & Me.cbmm19.Text & "00"
                If Me.cbTime19.Checked = True Then
                    If cbStime19.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV19.Text, Me.txtPathWAV19_19.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV19.Text, Me.txtPathWAV19_19.Text)
                    End If
                End If
            Case Me.cbHH20.Text & Me.cbmm20.Text & "00"
                If Me.cbTime20.Checked = True Then
                    If cbStime20.Checked = True Then
                        PlayTime(1, hh, mm, Me.txtPathWAV20.Text, Me.txtPathWAV20_20.Text)
                    Else
                        PlayTime(0, hh, mm, Me.txtPathWAV20.Text, Me.txtPathWAV20_20.Text)
                    End If
                End If
            Case Me.cbHH_Shutdown.Text & Me.cbmm_Shutdown.Text & "00"
                If Me.cbShutdown.Checked = True Then
                    System.Diagnostics.Process.Start("shutdown", "-s -f -t 00")
                End If
        End Select
    End Sub

#End Region
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.pngwing_com



        Dim clientsFolder = New DirectoryInfo(Application.StartupPath & "\audio\bell")
        Dim subFolders = clientsFolder.GetDirectories()

        Me.cbbSound.DisplayMember = NameOf(DirectoryInfo.Name)
        Me.cbbSound.ValueMember = NameOf(DirectoryInfo.FullName)
        Me.cbbSound.DataSource = subFolders

        Call RINI()

        Me.btnSave.Text = "แก้ไข"
        Me.TimerNow.Start()

        Call EnableAndDisableControl(0)
        Me.Timer2.Start()
    End Sub

    Private Sub TimerNow_Tick(sender As Object, e As EventArgs) Handles TimerNow.Tick
        Me.lblTimeNow.Text = Now.ToString("HH:mm:ss")
        Dim HH As String = Now.ToString("HH")
        Dim mm As String = Now.ToString("mm")
        Dim ss As String = Now.ToString("ss")
        Call runtime(HH, mm, ss)
    End Sub



    Private Sub cbmm1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbmm1.KeyPress, cbmm2.KeyPress, cbmm3.KeyPress, cbmm4.KeyPress, cbmm5.KeyPress,
        cbmm6.KeyPress, cbmm7.KeyPress, cbmm8.KeyPress, cbmm9.KeyPress, cbmm10.KeyPress, cbmm11.KeyPress, cbmm12.KeyPress, cbmm13.KeyPress, cbmm14.KeyPress,
        cbmm15.KeyPress, cbmm16.KeyPress, cbmm17.KeyPress, cbmm18.KeyPress, cbmm19.KeyPress, cbmm20.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbHH1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbHH1.KeyPress, cbHH2.KeyPress, cbHH3.KeyPress, cbHH4.KeyPress, cbHH5.KeyPress, cbHH6.KeyPress,
            cbHH7.KeyPress, cbHH8.KeyPress, cbHH9.KeyPress, cbHH10.KeyPress, cbHH11.KeyPress, cbHH12.KeyPress, cbHH13.KeyPress, cbHH14.KeyPress, cbHH15.KeyPress, cbHH16.KeyPress, cbHH17.KeyPress,
            cbHH18.KeyPress, cbHH19.KeyPress, cbHH20.KeyPress
        e.Handled = True
    End Sub


    Private Sub btnPlayTimeNow_Click(sender As Object, e As EventArgs) Handles btnPlayTimeNow.Click
        Dim HH As String = Now.ToString("HH")
        Dim mm As String = Now.ToString("mm")
        PlayTime("1", HH, mm, "", "")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.btnSave.Text = "แก้ไข" Then
            Call EnableAndDisableControl(1)
            Me.btnSave.Text = "บันทึก"
        ElseIf Me.btnSave.Text = "บันทึก" Then
            Call SINI()
            Call EnableAndDisableControl(0)
            Me.btnSave.Text = "แก้ไข"
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call EnableAndDisableControl(0)
        Me.btnSave.Text = "แก้ไข"
    End Sub

    Private Sub btnSelectWAV1_Click(sender As Object, e As EventArgs) Handles btnSelectWAV1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV1.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV2_Click(sender As Object, e As EventArgs) Handles btnSelectWAV2.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV2.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV3_Click(sender As Object, e As EventArgs) Handles btnSelectWAV3.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV3.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV4_Click(sender As Object, e As EventArgs) Handles btnSelectWAV4.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV4.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV5_Click(sender As Object, e As EventArgs) Handles btnSelectWAV5.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV5.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV6_Click(sender As Object, e As EventArgs) Handles btnSelectWAV6.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV6.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV7_Click(sender As Object, e As EventArgs) Handles btnSelectWAV7.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV7.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV8_Click(sender As Object, e As EventArgs) Handles btnSelectWAV8.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV8.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV9_Click(sender As Object, e As EventArgs) Handles btnSelectWAV9.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV9.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV10_Click(sender As Object, e As EventArgs) Handles btnSelectWAV10.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV10.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV11_Click(sender As Object, e As EventArgs) Handles btnSelectWAV11.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV11.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV12_Click(sender As Object, e As EventArgs) Handles btnSelectWAV12.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV12.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV13_Click(sender As Object, e As EventArgs) Handles btnSelectWAV13.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV13.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV14_Click(sender As Object, e As EventArgs) Handles btnSelectWAV14.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV14.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV15_Click(sender As Object, e As EventArgs) Handles btnSelectWAV15.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV15.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV16_Click(sender As Object, e As EventArgs) Handles btnSelectWAV16.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV16.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV17_Click(sender As Object, e As EventArgs) Handles btnSelectWAV17.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV17.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV18_Click(sender As Object, e As EventArgs) Handles btnSelectWAV18.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV18.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV19_Click(sender As Object, e As EventArgs) Handles btnSelectWAV19.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV19.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV20_Click(sender As Object, e As EventArgs) Handles btnSelectWAV20.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV20.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub MainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        NotifyIcon1.Visible = True
        Me.Hide()
        ShowInTaskbar = False
        Me.Timer2.Stop()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Show_ToolStripMenu_Click(sender As Object, e As EventArgs) Handles Show_ToolStripMenu.Click
        Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        NotifyIcon1.Visible = True
        Me.Hide()
        ShowInTaskbar = False
        Timer2.Stop()
    End Sub

    Private Sub ContextMenuStrip1_Leave(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Leave
        NotifyIcon1.ContextMenuStrip.Hide()
    End Sub

    Private Sub ContextMenuStrip1_LostFocus(sender As Object, e As EventArgs) Handles ContextMenuStrip1.LostFocus
        NotifyIcon1.ContextMenuStrip.Hide()
    End Sub

    Private Sub ContextMenuStrip1_MouseLeave(sender As Object, e As EventArgs) Handles ContextMenuStrip1.MouseLeave
        NotifyIcon1.ContextMenuStrip.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Right Then
            Me.ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub Exit_ToolStripMenu_Click(sender As Object, e As EventArgs) Handles Exit_ToolStripMenu.Click
        Application.ExitThread()
    End Sub

    Private Sub btnPlay1_Click(sender As Object, e As EventArgs) Handles btnPlay1.Click
        If Me.cbStime1.Checked = True Then
            PlayTime(1, Me.cbHH1.Text, Me.cbmm1.Text, Me.txtPathWAV1.Text, Me.txtPathWAV1_1.Text)
        Else
            PlayTime(0, Me.cbHH1.Text, Me.cbmm1.Text, Me.txtPathWAV1.Text, Me.txtPathWAV1_1.Text)
        End If
    End Sub

    Private Sub btnPlay2_Click(sender As Object, e As EventArgs) Handles btnPlay2.Click
        If Me.cbStime2.Checked = True Then
            PlayTime(1, Me.cbHH2.Text, Me.cbmm2.Text, Me.txtPathWAV2.Text, Me.txtPathWAV2_2.Text)
        Else
            PlayTime(0, Me.cbHH2.Text, Me.cbmm2.Text, Me.txtPathWAV2.Text, Me.txtPathWAV2_2.Text)
        End If
    End Sub

    Private Sub btnPlay3_Click(sender As Object, e As EventArgs) Handles btnPlay3.Click
        If Me.cbStime3.Checked = True Then
            PlayTime(1, Me.cbHH3.Text, Me.cbmm3.Text, Me.txtPathWAV3.Text, Me.txtPathWAV3_3.Text)
        Else
            PlayTime(0, Me.cbHH3.Text, Me.cbmm3.Text, Me.txtPathWAV3.Text, Me.txtPathWAV3_3.Text)
        End If
    End Sub

    Private Sub btnPlay4_Click(sender As Object, e As EventArgs) Handles btnPlay4.Click
        If Me.cbStime4.Checked = True Then
            PlayTime(1, Me.cbHH4.Text, Me.cbmm4.Text, Me.txtPathWAV4.Text, Me.txtPathWAV4_4.Text)
        Else
            PlayTime(0, Me.cbHH4.Text, Me.cbmm4.Text, Me.txtPathWAV4.Text, Me.txtPathWAV4_4.Text)
        End If
    End Sub

    Private Sub btnPlay5_Click(sender As Object, e As EventArgs) Handles btnPlay5.Click
        If Me.cbStime5.Checked = True Then
            PlayTime(1, Me.cbHH5.Text, Me.cbmm5.Text, Me.txtPathWAV5.Text, Me.txtPathWAV5_5.Text)
        Else
            PlayTime(0, Me.cbHH5.Text, Me.cbmm5.Text, Me.txtPathWAV5.Text, Me.txtPathWAV5_5.Text)
        End If
    End Sub

    Private Sub btnPlay6_Click(sender As Object, e As EventArgs) Handles btnPlay6.Click
        If Me.cbStime6.Checked = True Then
            PlayTime(1, Me.cbHH6.Text, Me.cbmm6.Text, Me.txtPathWAV6.Text, Me.txtPathWAV6_6.Text)
        Else
            PlayTime(0, Me.cbHH6.Text, Me.cbmm6.Text, Me.txtPathWAV6.Text, Me.txtPathWAV6_6.Text)
        End If
    End Sub

    Private Sub btnPlay7_Click(sender As Object, e As EventArgs) Handles btnPlay7.Click
        If Me.cbStime7.Checked = True Then
            PlayTime(1, Me.cbHH7.Text, Me.cbmm7.Text, Me.txtPathWAV7.Text, Me.txtPathWAV7_7.Text)
        Else
            PlayTime(0, Me.cbHH7.Text, Me.cbmm7.Text, Me.txtPathWAV7.Text, Me.txtPathWAV7_7.Text)
        End If
    End Sub

    Private Sub btnPlay8_Click(sender As Object, e As EventArgs) Handles btnPlay8.Click
        If Me.cbStime8.Checked = True Then
            PlayTime(1, Me.cbHH8.Text, Me.cbmm8.Text, Me.txtPathWAV8.Text, Me.txtPathWAV8_8.Text)
        Else
            PlayTime(0, Me.cbHH8.Text, Me.cbmm8.Text, Me.txtPathWAV8.Text, Me.txtPathWAV8_8.Text)
        End If
    End Sub

    Private Sub btnPlay9_Click(sender As Object, e As EventArgs) Handles btnPlay9.Click
        If Me.cbStime9.Checked = True Then
            PlayTime(1, Me.cbHH9.Text, Me.cbmm9.Text, Me.txtPathWAV9.Text, Me.txtPathWAV9_9.Text)
        Else
            PlayTime(0, Me.cbHH9.Text, Me.cbmm9.Text, Me.txtPathWAV9.Text, Me.txtPathWAV9_9.Text)
        End If
    End Sub

    Private Sub btnPlay10_Click(sender As Object, e As EventArgs) Handles btnPlay10.Click
        If Me.cbStime10.Checked = True Then
            PlayTime(1, Me.cbHH10.Text, Me.cbmm10.Text, Me.txtPathWAV10.Text, Me.txtPathWAV10_10.Text)
        Else
            PlayTime(0, Me.cbHH10.Text, Me.cbmm10.Text, Me.txtPathWAV10.Text, Me.txtPathWAV10_10.Text)
        End If
    End Sub

    Private Sub btnPlay11_Click(sender As Object, e As EventArgs) Handles btnPlay11.Click
        If Me.cbStime11.Checked = True Then
            PlayTime(1, Me.cbHH11.Text, Me.cbmm11.Text, Me.txtPathWAV11.Text, Me.txtPathWAV11_11.Text)
        Else
            PlayTime(0, Me.cbHH11.Text, Me.cbmm11.Text, Me.txtPathWAV11.Text, Me.txtPathWAV11_11.Text)
        End If
    End Sub

    Private Sub btnPlay12_Click(sender As Object, e As EventArgs) Handles btnPlay12.Click
        If Me.cbStime12.Checked = True Then
            PlayTime(1, Me.cbHH12.Text, Me.cbmm12.Text, Me.txtPathWAV12.Text, Me.txtPathWAV12_12.Text)
        Else
            PlayTime(0, Me.cbHH12.Text, Me.cbmm12.Text, Me.txtPathWAV12.Text, Me.txtPathWAV12_12.Text)
        End If
    End Sub

    Private Sub btnPlay13_Click(sender As Object, e As EventArgs) Handles btnPlay13.Click
        If Me.cbStime13.Checked = True Then
            PlayTime(1, Me.cbHH13.Text, Me.cbmm13.Text, Me.txtPathWAV13.Text, Me.txtPathWAV13_13.Text)
        Else
            PlayTime(0, Me.cbHH13.Text, Me.cbmm13.Text, Me.txtPathWAV13.Text, Me.txtPathWAV13_13.Text)
        End If
    End Sub

    Private Sub btnPlay14_Click(sender As Object, e As EventArgs) Handles btnPlay14.Click
        If Me.cbStime14.Checked = True Then
            PlayTime(1, Me.cbHH14.Text, Me.cbmm14.Text, Me.txtPathWAV14.Text, Me.txtPathWAV14_14.Text)
        Else
            PlayTime(0, Me.cbHH14.Text, Me.cbmm14.Text, Me.txtPathWAV14.Text, Me.txtPathWAV14_14.Text)
        End If
    End Sub

    Private Sub btnPlay15_Click(sender As Object, e As EventArgs) Handles btnPlay15.Click
        If Me.cbStime15.Checked = True Then
            PlayTime(1, Me.cbHH15.Text, Me.cbmm15.Text, Me.txtPathWAV15.Text, Me.txtPathWAV15_15.Text)
        Else
            PlayTime(0, Me.cbHH15.Text, Me.cbmm15.Text, Me.txtPathWAV15.Text, Me.txtPathWAV15_15.Text)
        End If
    End Sub

    Private Sub btnPlay16_Click(sender As Object, e As EventArgs) Handles btnPlay16.Click
        If Me.cbStime16.Checked = True Then
            PlayTime(1, Me.cbHH16.Text, Me.cbmm16.Text, Me.txtPathWAV16.Text, Me.txtPathWAV16_16.Text)
        Else
            PlayTime(0, Me.cbHH16.Text, Me.cbmm16.Text, Me.txtPathWAV16.Text, Me.txtPathWAV16_16.Text)
        End If
    End Sub

    Private Sub btnPlay17_Click(sender As Object, e As EventArgs) Handles btnPlay17.Click
        If Me.cbStime17.Checked = True Then
            PlayTime(1, Me.cbHH17.Text, Me.cbmm17.Text, Me.txtPathWAV17.Text, Me.txtPathWAV17_17.Text)
        Else
            PlayTime(0, Me.cbHH17.Text, Me.cbmm17.Text, Me.txtPathWAV17.Text, Me.txtPathWAV17_17.Text)
        End If
    End Sub

    Private Sub btnPlay18_Click(sender As Object, e As EventArgs) Handles btnPlay18.Click
        If Me.cbStime18.Checked = True Then
            PlayTime(1, Me.cbHH18.Text, Me.cbmm18.Text, Me.txtPathWAV18.Text, Me.txtPathWAV18_18.Text)
        Else
            PlayTime(0, Me.cbHH18.Text, Me.cbmm18.Text, Me.txtPathWAV18.Text, Me.txtPathWAV18_18.Text)
        End If
    End Sub

    Private Sub btnPlay19_Click(sender As Object, e As EventArgs) Handles btnPlay19.Click
        If Me.cbStime19.Checked = True Then
            PlayTime(1, Me.cbHH19.Text, Me.cbmm19.Text, Me.txtPathWAV19.Text, Me.txtPathWAV19_19.Text)
        Else
            PlayTime(0, Me.cbHH19.Text, Me.cbmm19.Text, Me.txtPathWAV19.Text, Me.txtPathWAV19_19.Text)
        End If
    End Sub

    Private Sub btnPlay20_Click(sender As Object, e As EventArgs) Handles btnPlay20.Click
        If Me.cbStime20.Checked = True Then
            PlayTime(1, Me.cbHH20.Text, Me.cbmm20.Text, Me.txtPathWAV20.Text, Me.txtPathWAV20_20.Text)
        Else
            PlayTime(0, Me.cbHH20.Text, Me.cbmm20.Text, Me.txtPathWAV20.Text, Me.txtPathWAV20_20.Text)
        End If
    End Sub

    Private Sub btnSelectWAV1_1_Click(sender As Object, e As EventArgs) Handles btnSelectWAV1_1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV1_1.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV2_2_Click(sender As Object, e As EventArgs) Handles btnSelectWAV2_2.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV2_2.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV3_3_Click(sender As Object, e As EventArgs) Handles btnSelectWAV3_3.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV3_3.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV4_4_Click(sender As Object, e As EventArgs) Handles btnSelectWAV4_4.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV4_4.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV5_5_Click(sender As Object, e As EventArgs) Handles btnSelectWAV5_5.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV5_5.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV6_6_Click(sender As Object, e As EventArgs) Handles btnSelectWAV6_6.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV6_6.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV7_7_Click(sender As Object, e As EventArgs) Handles btnSelectWAV7_7.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV7_7.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV8_8_Click(sender As Object, e As EventArgs) Handles btnSelectWAV8_8.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV8_8.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV9_9_Click(sender As Object, e As EventArgs) Handles btnSelectWAV9_9.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV9_9.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV10_10_Click(sender As Object, e As EventArgs) Handles btnSelectWAV10_10.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV10_10.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV11_11_Click(sender As Object, e As EventArgs) Handles btnSelectWAV11_11.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV11_11.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV12_12_Click(sender As Object, e As EventArgs) Handles btnSelectWAV12_12.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV12_12.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV13_13_Click(sender As Object, e As EventArgs) Handles btnSelectWAV13_13.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV13_13.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV14_14_Click(sender As Object, e As EventArgs) Handles btnSelectWAV14_14.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV14_14.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV15_15_Click(sender As Object, e As EventArgs) Handles btnSelectWAV15_15.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV15_15.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV16_16_Click(sender As Object, e As EventArgs) Handles btnSelectWAV16_16.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV16_16.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV17_17_Click(sender As Object, e As EventArgs) Handles btnSelectWAV17_17.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV17_17.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV18_18_Click(sender As Object, e As EventArgs) Handles btnSelectWAV18_18.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV18_18.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV19_19_Click(sender As Object, e As EventArgs) Handles btnSelectWAV19_19.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV19_19.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectWAV20_20_Click(sender As Object, e As EventArgs) Handles btnSelectWAV20_20.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            Me.txtPathWAV20_20.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        End If
    End Sub

End Class
