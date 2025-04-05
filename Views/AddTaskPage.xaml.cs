using KSKhromushinV2.Models;
using KSKhromushinV2.Services;

namespace KSKhromushinV2.Views;

public partial class AddTaskPage : ContentPage
{
    public AddTaskPage()
    {
        InitializeComponent();
        PriorityPicker.SelectedIndex = 1;
    }

    async void OnSave(object sender, EventArgs e)
    {
        var task = new TaskItem
        {
            Title = TitleEntry.Text,
            Description = DescriptionEditor.Text,
            DueDate = DueDatePicker.Date,
            Priority = PriorityPicker.SelectedIndex + 1
        };

        var tasks = await TaskStorage.LoadTasksAsync();
        tasks.Add(task);
        await TaskStorage.SaveTasksAsync(tasks);

        await DisplayAlert("Успешно", "Задача добавлена", "OK");
        await Navigation.PopAsync();
    }
}