Module Module1

    Sub Main()
        Dim nElems = 0
        Console.Clear()
        Console.WriteLine("Input a count of elements")
        Int32.TryParse(Console.ReadLine(), nElems)
        Dim iArray(nElems) As Short
        Dim oRnd = New Random()
        For i = 0 To nElems - 1
            Dim nItem = oRnd.Next(1, 10)
            iArray(i) = nItem
        Next
        Dim nProduct = 1L
        For i = 0 To nElems - 1
            nProduct *= iArray(i)
            Console.Write(Str(iArray(i)) + " ")
        Next
        Console.WriteLine(vbCrLf + $"The Product of {nElems} elements of the array is:{nProduct}")
        Console.Read()
    End Sub

End Module
