using System;
using System.Diagnostics;

namespace Sharp.Reporting
{
	public static class ExceptionReport
	{
		private static class ExceptionParse
		{
			public const int Type = 0;
			public const int Message = 1;
			public const int Stack = 2;
			public const int Site = 3;
		}


		public static string GetMessage(this Exception exception)
		{
			if (exception == null)
				return "The exception is null.";
			else if (exception.InnerException == null)
				return exception.Message;
			else
				return exception.InnerException.Message;
		}


		public static string GetReport(this Exception exception)
		{
			const string div = "----------------------------------------------------------------";

			string outerMessage = string.Empty;
			string[] outer = Parse(exception);
			var message = string.Concat
			(
				string.Concat("Exception:"+ exception.GetType().Name, "\n", div, "\n"),
				string.Concat("--Type: ", outer[ExceptionParse.Type], "\n"),
				string.Concat("--Message: ", outer[ExceptionParse.Message], "\n"),
				string.Concat("--Site: ", outer[ExceptionParse.Site], "\n"),
				string.Concat("--Stack:\n", outer[ExceptionParse.Stack], "\n\n\n")
			);

			if (exception.InnerException != null)
			{
				string[] inner = Parse(exception.InnerException);
				string innerMessage = string.Concat
				(
					string.Concat("Inner Exception:"+ exception.InnerException.GetType().Name, "\n", div, "\n"),
					string.Concat("--Type: ", inner[ExceptionParse.Type], "\n"),
					string.Concat("--Message: ", inner[ExceptionParse.Message], "\n"),
					string.Concat("--Site: ", inner[ExceptionParse.Site], "\n"),
					string.Concat("--Stack: ", inner[ExceptionParse.Stack], "\n")
				);

				return string.Concat
				(
					string.Concat(outerMessage),
					string.Concat(innerMessage)

				);
			}
			else
			{
				return message;
			}
		}


		private static string[] Parse(this Exception exception)
		{
			if (exception == null)
			{
				return new string[4];
			}
			else
			{
				string[] format = new string[4];
				format[ExceptionParse.Type] = exception.GetType().Name;
				format[ExceptionParse.Message] = exception.Message;
				format[ExceptionParse.Stack] = exception.StackTrace;
				format[ExceptionParse.Site] = exception.TargetSite.DeclaringType.ToString();
				return format;
			}
		}


	}
}
