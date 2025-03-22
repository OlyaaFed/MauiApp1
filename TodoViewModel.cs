using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;

namespace MauiApp1
{
    public class TodoViewModel 
    {
        private const string StorageKey = "todos";
        public ObservableCollection<Todo> Todos { get; set; } = new();

        public TodoViewModel()
        {
            LoadTodos();
        }

        public void AddTodo(Todo todo)
        {
            Todos.Add(todo);
            SaveTodos();
        }

        public async void SaveTodos()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(Todos, new JsonSerializerOptions { WriteIndented = true });
            await SecureStorage.SetAsync(StorageKey, json);
        }

        public async void LoadTodos()
        {
            var json = await SecureStorage.GetAsync(StorageKey);
            if (!string.IsNullOrEmpty(json))
            {
                Todos = System.Text.Json.JsonSerializer.Deserialize<ObservableCollection<Todo>>(json) ?? new();
            }
        }
    }  
}

