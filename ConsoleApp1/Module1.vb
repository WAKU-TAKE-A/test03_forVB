Imports Wrapper

Namespace test03

    Module Module1

        Sub Main()

            Dim wr As New WrapperClass
            Dim src = New Integer() {1, 2, 3, 4, 5, 6, 5, 4, 3, 2}
            Dim num As Integer = 10
            Dim mx As Integer = 0
            Dim mxIndex As Integer = 0

            wr.Max(src, num, mx, mxIndex)

            For i = 0 To UBound(src)
                Console.Write(src(i).ToString() + ",")
            Next

            Console.WriteLine("")
            Console.WriteLine("max = " + mx.ToString())
            Console.WriteLine("max index = " + mxIndex.ToString())

        End Sub

    End Module

End Namespace

