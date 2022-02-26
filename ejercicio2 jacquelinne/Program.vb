Imports System

Module Program
	Sub Main()
		Console.Title = "Jacquelinne Hernandez"

		Dim valor, x, y, z As Decimal
		x = 0.05
		y = 0.1
		z = 0.15

		Console.WriteLine("Ingresa el valor de tu compra: ")
		valor = Console.ReadLine

		If (valor > 49 And valor < 101) Then
			Console.WriteLine("valor total de la compra: " & valor)
			Dim des1 As Decimal
			des1 = valor * x
			Console.WriteLine("Total en descuento: " & des1)
			Console.WriteLine("Total a pagar: " & valor - des1)

		ElseIf (valor > 101 And valor < 151) Then
			Console.WriteLine("Valor total de la compra: " & valor)
			Dim des2 As Decimal
			des2 = valor * y
			Console.WriteLine("Total en descuento: " & des2)
			Console.WriteLine("Total a pagar: " & valor - des2)

		ElseIf (valor > 151) Then
			Console.WriteLine("Valor total de la compra: " & valor)
			Dim des3 As Decimal
			des3 = valor * z
			Console.WriteLine("Total en descuento: " & des3)
			Console.WriteLine("Total a pagar: " & valor - des3)

		End If



	End Sub
End Module
