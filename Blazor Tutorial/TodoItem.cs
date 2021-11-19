using System;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Summary description for Class1
/// </summary>
public class TodoItem
{	
		[Required]
		[StringLength(10, ErrorMessage = "Name is too Long")]
		public string Title { get; set; }
		public bool IsDone { get; set; }
	
}
