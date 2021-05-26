Imports System

Public Module Module1
	Public Sub Main()
		Dim Number1 As Decimal
		Dim Number2 As Decimal
		Dim Number3 As Decimal
		Dim _function As String
		Dim _functionSign As String
		Console.WriteLine("Welcome to my calculator!")
		Console.WriteLine("What function do you need the most?")
		_function = Console.ReadLine()
		If _function = "addition" Then
			Console.Clear()
			_functionSign = "+"
			Console.WriteLine("Enter your first input and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Console.WriteLine("Enter your second input and press enter!")
			Number2 = Console.ReadLine()
			Console.Clear()
			Number3 = Number1 + Number2
			Console.WriteLine("The answer to your question " & Number1 & _functionSign & Number2 & " is " & Number3)
		ElseIf _function = "subtraction" Then
			Console.Clear()
			_functionSign = "-"
			Console.WriteLine("Enter your first input and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Console.WriteLine("Enter your second input and press enter!")
			Number2 = Console.ReadLine()
			Console.Clear()
			Number3 = Number1 - Number2
			Console.WriteLine("The answer to your question " & Number1 & _functionSign & Number2 & " is " & Number3)
		ElseIf _function = "multiplication" Then
			Console.Clear()
			_functionSign = "x"
			Console.WriteLine("Enter your first input and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Console.WriteLine("Enter your second input and press enter!")
			Number2 = Console.ReadLine()
			Console.Clear()
			Number3 = Number1 * Number2
			Console.WriteLine("The answer to your question " & Number1 & _functionSign & Number2 & " is " & Number3)
		ElseIf _function = "division" Then
			Console.Clear()
			_functionSign = "/"
			Console.WriteLine("Enter your first input and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Console.WriteLine("Enter your second input and press enter!")
			Number2 = Console.ReadLine()
			Console.Clear()
			Number3 = Number1 / Number2
			Console.WriteLine("The answer to your question " & Number1 & _functionSign & Number2 & " is " & Number3)
		ElseIf _function = "percentage" Then
			Dim fullPercentage As Decimal
			Console.Clear()
			_functionSign = "%"
			Console.WriteLine("Enter your original value and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Console.WriteLine("Enter your percentage's value and press enter!")
			Number2 = Console.ReadLine()
			fullPercentage = Number2
			Number2 = Number2 / 100
			Console.Clear()
			Number3 = Number1 * Number2
			Console.WriteLine("The answer to your question " & fullPercentage & "% of " & Number1 & " is " & Number3)
		Else
			Console.Clear()
			Console.Beep()
			Console.Write("The function '" & _function & "' does not exist. Please enter a valid mathematical function!")
		End If
	End Sub
End Module
