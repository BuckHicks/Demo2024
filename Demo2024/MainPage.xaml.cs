using Demo2024.Biz.Commons.Interfaces;

namespace Demo2024
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(IMainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
