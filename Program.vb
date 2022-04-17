Imports System

Public Module Module1
	Public Sub Main()
		Dim Number1 As Decimal
		Dim Number2 As Decimal
		Dim Number3 As Decimal
		Dim _function As String
		Dim _functionSign As String
		Dim currentDate = DateTime.Now
		Console.WriteLine("This is an alpha version of this software. Some features may be faulted or not work at all.")
		Console.ReadKey()
		Console.Clear()
		Console.WriteLine($"{vbCrLf}Hello and welcome to My Calculator! You are using this application on {currentDate:d} at {currentDate:t}!")
		Console.Write(vbCrLf + "Press any key to continue... ")
		Console.ReadKey(True)
		Console.Clear()
		Console.WriteLine($"Choose a function out of this list: {vbCrLf} 'addition' {vbCrLf} 'subtraction' {vbCrLf} 'multiplication' {vbCrLf} 'division' {vbCrLf} 'percentage' {vbCrLf} 'square a number' {vbCrLf} 'cube a number' {vbCrLf} 'powers'")
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
		ElseIf _function = "square a number" Then
			Console.Clear()
			_functionSign = "²"
			Console.WriteLine("Enter your value and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Number3 = Number1 * Number1
			Console.WriteLine("The answer to your question " & Number1 & _functionSign & " is " & Number3)
		ElseIf _function = "cube a number" Then
			Console.Clear()
			_functionSign = "³"
			Console.WriteLine("Enter your value and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Number3 = Number1 * Number1 * Number1
			Console.WriteLine("The answer to your question " & Number1 & _functionSign & " is " & Number3)
		ElseIf _function = "powers" Then
			Console.Clear()
			_functionSign = "^"
			Console.WriteLine("Enter your value and press enter!")
			Number1 = Console.ReadLine()
			Console.Clear()
			Console.WriteLine("What do you want your power to be? Enter your value and press enter!")
			Number2 = Console.ReadLine()
			Number3 = Number1
			Console.Clear()
			Number1 = Number1 ^ Number2
			Console.WriteLine("The answer to your question " & Number3 & _functionSign & Number2 & " is " & Number1)
		Else
			Console.Clear()
			Console.Beep()
			Console.Write("The function '" & _function & "' does not exist. Please enter a valid mathematical function!")
			Console.ReadKey()

		End If
	End Sub
End Module