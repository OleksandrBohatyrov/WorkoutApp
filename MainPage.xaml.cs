using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using WorkoutApp.Models;

namespace WorkoutApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<WorkoutProgram> RecommendedPrograms { get; set; }
        public int WorkoutsThisWeek { get; set; }
        public int CaloriesBurned { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Инициализация данных
            RecommendedPrograms = new ObservableCollection<WorkoutProgram>
            {
                new WorkoutProgram { Name = "Full Body Workout", Description = "A complete workout for your whole body.", Image = "fullbody.png" },
                new WorkoutProgram { Name = "Cardio Blast", Description = "High-intensity cardio workout.", Image = "cardio.png" },
                // Добавьте другие программы
            };

            WorkoutsThisWeek = 5; // Пример данных
            CaloriesBurned = 1500; // Пример данных

            // Установка BindingContext для привязки данных
            this.BindingContext = this;
        }

        // Обработчики событий для навигации
        private async void OnHomeClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Navigation", "Home clicked", "OK");
        }

        private async void OnProgramsClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Navigation", "Programs clicked", "OK");
        }

        private async void OnProgressClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Navigation", "Progress clicked", "OK");
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Navigation", "Settings clicked", "OK");
        }

        private async void OnStartWorkoutClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Workout", "Start Workout clicked", "OK");
        }
    }
}
