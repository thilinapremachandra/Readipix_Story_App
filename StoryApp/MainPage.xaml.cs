using System.Collections.ObjectModel;
using StoryApp.Models;

namespace StoryApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FairyTales> FairyTales1 { get; set; } = new();
        public ObservableCollection<FairyTales> FairyTales2 { get; set; } = new();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            ModifySearchBar();
            InitializeTales();
        }

        private void ModifySearchBar()
        {
            // Remove the search bar's default border
            if (searchBar != null)
            {
                searchBar.BackgroundColor = Colors.Transparent;
            }
        }

        private void InitializeTales()
        {
            FairyTales1.Clear();
            FairyTales1.Add(new FairyTales { Name = "Rapunzel", ReadTime = new TimeSpan(0, 30, 0), Image = "rapu.jpg" });
            FairyTales1.Add(new FairyTales { Name = "Gold Pirates", ReadTime = new TimeSpan(0, 25, 0), Image = "ship.jpg" });
            FairyTales1.Add(new FairyTales { Name = "Tall Tilly", ReadTime = new TimeSpan(0, 20, 0), Image = "tilly.jpg" });
            FairyTales1.Add(new FairyTales { Name = "Four French Witches", ReadTime = new TimeSpan(0, 30, 0), Image = "fre.jpg" });

            FairyTales2.Clear();
            FairyTales2.Add(new FairyTales { Name = "Abandoned City", ReadTime = new TimeSpan(0, 30, 0), Image = "city.jpg" });
            FairyTales2.Add(new FairyTales { Name = "Four French Witches", ReadTime = new TimeSpan(0, 30, 0), Image = "fre.jpg" });
            FairyTales2.Add(new FairyTales { Name = "King and the Cup", ReadTime = new TimeSpan(0, 20, 0), Image = "king.jpg" });
            FairyTales2.Add(new FairyTales { Name = "Moonlocks", ReadTime = new TimeSpan(0, 25, 0), Image = "moon.jpg" });
        }
    }
}