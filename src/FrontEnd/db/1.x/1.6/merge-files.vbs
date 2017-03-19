On Error Resume Next
Dim destinationPath, file1, file2
Dim objStream1, objStream2, strData1, strData2
Dim writer

destinationPath = Wscript.Arguments(0)
file1 = Wscript.Arguments(1)
file2 = Wscript.Arguments(2)


Set objStream1 = CreateObject("ADODB.Stream")
objStream1.CharSet = "utf-8"
objStream1.Open
objStream1.LoadFromFile(file1)
strData1 = objStream1.ReadText()

If Err.Number <> 0 Then
  WScript.Echo "Step0: " & Err.Description & " " & file1
  Err.Clear
End If

Set objStream2 = CreateObject("ADODB.Stream")
objStream2.CharSet = "utf-8"
objStream2.Open
objStream2.LoadFromFile(file2)
strData2 = objStream2.ReadText()

If Err.Number <> 0 Then
  WScript.Echo "Step1: " & Err.Description & " " & file2
  Err.Clear
End If

Set writer = CreateObject("ADODB.Stream")
writer.CharSet = "utf-8"
writer.Open
writer.WriteText strData1 & strData2
writer.SaveToFile destinationPath, 2