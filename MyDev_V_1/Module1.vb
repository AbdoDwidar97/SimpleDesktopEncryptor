Imports System.IO
Module Module1
    Dim WW As New ProtectUs.EncryptMe
    Dim SS As New ProtectUs.MyFile
    Dim FF As New ProtectUs.Tools

    Sub Main()

        Console.BackgroundColor = ConsoleColor.DarkBlue
        Console.Clear()

        '-------------------------------------------------

        '-----------------------------------------------
        Console.Title = "MyDev V.1.0"

        '-----------------------------------------------
        MyPwd()
        Console.Clear()

        '-----------------------------------------------
        Console.ForegroundColor = ConsoleColor.Green
        '-----------------------------------------------

        '------------------------------------------------------------------------------------------------
        Console.WriteLine(" {MyDev Version 1.0 Advanced} All rights reserved. Th3ProfGhost Corporation ")
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.WriteLine("============================================================================")
        Console.WriteLine()
        '------------------------------------------------------------------------------------------------

        '------------------------------------------------------------------------------------------------
        Console.ForegroundColor = ConsoleColor.White
10:
        Console.Write(" Select Num. :  1- View List       2- Exit :_ ")

        Dim T As String

        T = Console.ReadLine
        '------------------------------------------------------------------------------------------------
        If T = "1" Then

            Console.WriteLine(" 1- Encryption Data ")
            Console.WriteLine(" 2- Decryption Data ")
            Console.WriteLine(" 3- Encryption / Decryption File ")
            Console.WriteLine(" 4- Exit ")
            Console.Write(" Select Number :_ ")

            Dim JJ As String

            JJ = Console.ReadLine

            If JJ = "1" Then

                EncryptData()

            End If
            '-----------------------------
            If JJ = "2" Then

                DecryptData()

            End If
            '-----------------------------
            If JJ = "3" Then

                CallEncDecFile()

            End If
            '-----------------------------
            If JJ = "4" Then

                End

            End If
            '------------------------------
            GoTo 10
            '------------------------------
        End If

        '-----------------------------------------------------------------------------------------------------

        If T = "2" Then
            End
        Else

            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Enter Correct Selection ! ")
            Console.ForegroundColor = ConsoleColor.White
            GoTo 10

        End If



        Console.ReadKey()


    End Sub


    Sub EncryptData()
        Console.WriteLine(" Enter Text You Would Encrypt It :_ ")

        Dim oo As String


        oo = WW.EncryptData(Console.ReadLine)
        Console.WriteLine(oo)

        Console.WriteLine(" Do You Want To Save Encrypted Data On A file ? ")
11:
        Console.Write(" Select (y) yes         (n) No :_ ")

        Dim BB As String
        BB = Console.ReadLine

        If BB = "y" Then
            Console.WriteLine(" Enter FileName You want to Save Encrypted Data In it :_ ")

            Console.WriteLine(SS.WriteMyFile(Console.ReadLine, oo))
            Console.ReadKey()

            Exit Sub

        End If

        If BB = "n" Then
            Exit Sub

        Else

            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Enter Correct Selection ! ")
            Console.ForegroundColor = ConsoleColor.White
            GoTo 11

        End If

        Console.ReadKey()


    End Sub

    Sub DecryptData()
25:

        Console.WriteLine(" Select : 1- Direct Decryption    2- Import From File ")
        Console.Write(" Select :_ ")
        Dim PO As String

        PO = Console.ReadLine

        If PO = "1" Then

            Console.WriteLine(" Enter Text You Want To Decrypt It :_ ")

            Console.WriteLine("==================================")
            Console.WriteLine(WW.DecryptData(Console.ReadLine))
            Console.WriteLine("==================================")

            Exit Sub

        End If

        If PO = "2" Then


            Dim UI As String
            Console.WriteLine(" Enter FileName You Want To Import From It :_ ")

            UI = SS.ReadMyFile(Console.ReadLine)

            Console.WriteLine("==================================")
            Console.WriteLine(UI)
            Console.WriteLine("==================================")


            Console.WriteLine("==================================")
            Console.WriteLine(WW.DecryptData(UI))
            Console.WriteLine("==================================")

        Else

            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Enter Correct Selection ! ")
            Console.ForegroundColor = ConsoleColor.White
            GoTo 25

        End If

    End Sub

    Sub CallEncDecFile()

        Console.WriteLine(" Enter FileName You like Encrypt / Decrypt It :_ ")

        Console.WriteLine(WW.Encryptfile(Console.ReadLine, 4))
        Console.ReadKey()


    End Sub

    Sub MyPwd()
30:
        Console.Write(" Enter Password :_ ")
        Dim QQQ As String

        QQQ = Console.ReadLine

        If QQQ = "myencrypt1001" Then

            Exit Sub

        Else

            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" Enter Correct Password ! ")
            Console.ForegroundColor = ConsoleColor.White
            GoTo 30

        End If

    End Sub
End Module
