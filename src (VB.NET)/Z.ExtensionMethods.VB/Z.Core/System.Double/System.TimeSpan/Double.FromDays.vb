
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_229

	''' <summary>
	'''     Returns a  that represents a specified number of days, where the specification is accurate to the nearest
	'''     millisecond.
	''' </summary>
	''' <param name="value">A number of days, accurate to the nearest millisecond.</param>
	''' <returns>An object that represents .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromDays(value As [Double]) As TimeSpan
		Return TimeSpan.FromDays(value)
	End Function
End Module


