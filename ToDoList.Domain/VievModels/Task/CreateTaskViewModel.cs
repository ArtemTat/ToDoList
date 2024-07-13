using System;
using ToDoList.Domain.Enum;

namespace ToDoList.Domain.VievModels.Task;
public class CreateTaskVievModel
{
	public string Name { get; set; }

	public string Description { get; set; }

	public Priority Priority { get; set; }
}
