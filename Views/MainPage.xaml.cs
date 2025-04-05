using KSKhromushinV2.Models;
using KSKhromushinV2.Services;

namespace KSKhromushinV2.Views
{
    public partial class MainPage : ContentPage
    {
        private List<TaskItem> tasks = new();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            tasks = await TaskStorage.LoadTasksAsync();
            tasks = tasks.OrderBy(t => t.DueDate).ToList();
            TasksView.ItemsSource = tasks;
        }

        async void OnAddTask(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTaskPage());
        }
    }

}
