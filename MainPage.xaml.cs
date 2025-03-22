namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private TodoViewModel viewModel = new TodoViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnAddTodoClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(todoName.Text) &&
                !string.IsNullOrWhiteSpace(todoFrequency.Text) &&
                !string.IsNullOrWhiteSpace(todoDescription.Text))
            {
                var newTodo = new Todo
                {
                    Name = todoName.Text,
                    Frequency = todoFrequency.Text,
                    Description = todoDescription.Text,
                    LastCompleted = DateTime.Now
                };

                viewModel.AddTodo(newTodo);

                
                todoName.Text = string.Empty;
                todoFrequency.Text = string.Empty;
                todoDescription.Text = string.Empty;
            }
        }

    }

}
