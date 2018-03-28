Module Module1

    Sub Main()
        Using info As MediaInfo.DotNetWrapper.MediaInfo = New MediaInfo.DotNetWrapper.MediaInfo()
            Console.WriteLine(info.Option("Info_Version"))

            Console.WriteLine("Press Enter to quit!")
            Console.ReadLine()
        End Using
    End Sub

End Module
