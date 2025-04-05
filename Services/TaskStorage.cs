using KSKhromushinV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KSKhromushinV2.Services
{
    public static class TaskStorage
    {
        private static string filePath = Path.Combine(FileSystem.AppDataDirectory, "tasks.json");

        public static async Task<List<TaskItem>> LoadTasksAsync()
        {
            if (!File.Exists(filePath)) return new List<TaskItem>();

            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new();
        }

        public static async Task SaveTasksAsync(List<TaskItem> tasks)
        {
            var json = JsonSerializer.Serialize(tasks);
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}
