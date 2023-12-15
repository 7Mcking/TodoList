using System;
using System.Reactive;
using ReactiveUI;
using TodoList.DataModel;


namespace TodoList.ViewModels
{
    public class AddItemViewModel:ViewModelBase
    
    {
        private string _description = String.Empty;
        
        public ReactiveCommand<Unit, ToDoItem> OkCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }
        
        public AddItemViewModel()
        {
            var isValidObservable = this.WhenAnyValue(
                x => x.Description,
                x => !String.IsNullOrWhiteSpace(x));
            
            OkCommand = ReactiveCommand.Create(() => new ToDoItem {Description = Description}, isValidObservable);
            CancelCommand = ReactiveCommand.Create(() => { });
        }

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        } 
    }
}

