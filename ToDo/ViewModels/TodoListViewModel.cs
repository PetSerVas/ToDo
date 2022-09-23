using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;
using ToDo.Models;

namespace ToDo.ViewModels
{
	public class TodoListViewModel : ViewModelBase
	{
		public TodoListViewModel(IEnumerable<TodoItem> items)
		{
			Items = new ObservableCollection<TodoItem>(items);
		}

		public ObservableCollection<TodoItem> Items { get; }
	}
}