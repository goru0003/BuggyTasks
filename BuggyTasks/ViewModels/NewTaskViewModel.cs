using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace BuggyTasks.ViewModels;

public partial class NewTaskViewModel : ObservableObject
{
    public ObservableCollection<string> Tasks { get; } = new();
    [ObservableProperty] 
    string newTaskTitle;
    [RelayCommand]
    private void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(NewTaskTitle))
        {
            Tasks.Add(NewTaskTitle);
            Console.WriteLine($"New Task: {NewTaskTitle}");
            NewTaskTitle = string.Empty;
        }
    }
}