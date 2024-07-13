using System;
using ToDoList.Domain.Enum;

public class CreateTaskVievModel
{
	public string Name { get; set; }

	public string Description { get; set; }

	public Priority Priority { get; set; }
}
