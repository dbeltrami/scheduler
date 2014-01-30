using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Agenda
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WeekGrid(49,8);
            MonthGrid(49, 8);
            //yearGrid();

        }

        private void WeekGrid(int rowNumber , int columnNumber)
        {
            Grid DynamicGrid = new Grid();
            DynamicGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            DynamicGrid.VerticalAlignment = VerticalAlignment.Stretch;
            DynamicGrid.ShowGridLines = true;
            DynamicGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);

            // Create Columns
            for (int i = 0; i < columnNumber; i++)
            {
                ColumnDefinition column = new ColumnDefinition();
                DynamicGrid.ColumnDefinitions.Add(column);
            }

            // Create Rows
            for (int i = 0; i < rowNumber; i++)
            {
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(1, GridUnitType.Auto);
                DynamicGrid.RowDefinitions.Add(row);            
            }

            // Add first column header
            TextBlock Monday = new TextBlock();
            Monday.Text = "Lundi";
            Monday.FontSize = 14;
            Monday.FontWeight = FontWeights.Bold;
            Monday.Foreground = new SolidColorBrush(Colors.Green);
            Monday.VerticalAlignment = VerticalAlignment.Top;
            Monday.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(Monday, 0);
            Grid.SetColumn(Monday, 0);

            // Add first column header
            TextBlock Tuesday = new TextBlock();
            Tuesday.Text = "Mardi";
            Tuesday.FontSize = 14;
            Tuesday.FontWeight = FontWeights.Bold;
            Tuesday.Foreground = new SolidColorBrush(Colors.Green);
            Tuesday.VerticalAlignment = VerticalAlignment.Top;
            Tuesday.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(Tuesday, 0);
            Grid.SetColumn(Tuesday, 1);

            // Add first column header
            TextBlock Wednesday = new TextBlock();
            Wednesday.Text = "Mercredi";
            Wednesday.FontSize = 14;
            Wednesday.FontWeight = FontWeights.Bold;
            Wednesday.Foreground = new SolidColorBrush(Colors.Green);
            Wednesday.VerticalAlignment = VerticalAlignment.Top;
            Wednesday.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(Wednesday, 0);
            Grid.SetColumn(Wednesday, 2);

            TextBlock Thurday = new TextBlock();            
            Thurday.Text = "Jeudi";
            Thurday.FontSize = 14;
            Thurday.FontWeight = FontWeights.Bold;
            Thurday.Foreground = new SolidColorBrush(Colors.Green);
            Thurday.VerticalAlignment = VerticalAlignment.Top;
            Thurday.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(Thurday, 0);
            Grid.SetColumn(Thurday, 3);

            TextBlock Friday = new TextBlock();
            Friday.Text = "Vendredi";
            Friday.FontSize = 14;
            Friday.FontWeight = FontWeights.Bold;
            Friday.Foreground = new SolidColorBrush(Colors.Green);
            Friday.VerticalAlignment = VerticalAlignment.Top;
            Friday.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(Friday, 0);
            Grid.SetColumn(Friday, 4);

            TextBlock Saturday = new TextBlock();
            Saturday.Text = "Samedi";
            Saturday.FontSize = 14;
            Saturday.FontWeight = FontWeights.Bold;
            Saturday.Foreground = new SolidColorBrush(Colors.Green);
            Saturday.VerticalAlignment = VerticalAlignment.Top;
            Saturday.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(Saturday, 0);
            Grid.SetColumn(Saturday, 5);

            TextBlock Sunday = new TextBlock();
            Sunday.Text = "Dimanche";
            Sunday.FontSize = 14;
            Sunday.FontWeight = FontWeights.Bold;
            Sunday.Foreground = new SolidColorBrush(Colors.Green);
            Sunday.VerticalAlignment = VerticalAlignment.Top;
            Sunday.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(Sunday, 0);
            Grid.SetColumn(Sunday, 6);

            //// Add column headers to the Grid
            DynamicGrid.Children.Add(Monday);
            DynamicGrid.Children.Add(Tuesday);
            DynamicGrid.Children.Add(Wednesday);
            DynamicGrid.Children.Add(Thurday);
            DynamicGrid.Children.Add(Friday);
            DynamicGrid.Children.Add(Saturday);
            DynamicGrid.Children.Add(Sunday);

            for (int j = 1; j < rowNumber; j++)
            {
                for (int i = 0; i < columnNumber; i++)
                {
                    TextBlock authorText = new TextBlock();
                    authorText.Text = "";
                    authorText.FontSize = 12;
                    authorText.FontWeight = FontWeights.Bold;
                    Grid.SetRow(authorText, j);
                    Grid.SetColumn(authorText, i);

                    DynamicGrid.Children.Add(authorText); 
                }
            }

            week.Content = DynamicGrid;
        }

        private void MonthGrid(int rowNumber, int columnNumber)
        {
            DataGrid monthGrid = new DataGrid();
            monthGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            monthGrid.VerticalAlignment = VerticalAlignment.Stretch;
            monthGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);
            
            DataGridTextColumn lundi = new DataGridTextColumn();
            lundi.Header = "Lundi";
            DataGridTextColumn mardi = new DataGridTextColumn();
            mardi.Header = "Mardi";
            DataGridTextColumn mercredi = new DataGridTextColumn();
            mercredi.Header = "Mercredi";
            DataGridTextColumn jeudi = new DataGridTextColumn();
            jeudi.Header = "Jeudi";
            DataGridTextColumn vendredi = new DataGridTextColumn();
            vendredi.Header = "Vendredi";
            DataGridTextColumn samedi = new DataGridTextColumn();
            samedi.Header = "Samedi";
            DataGridTextColumn dimanche = new DataGridTextColumn();
            dimanche.Header = "Dimanche";

            monthGrid.Columns.Add(lundi);
            monthGrid.Columns.Add(mardi);
            monthGrid.Columns.Add(mercredi);
            monthGrid.Columns.Add(jeudi);
            monthGrid.Columns.Add(vendredi);
            monthGrid.Columns.Add(samedi);
            monthGrid.Columns.Add(dimanche);


            month.Content = monthGrid;
            
        }
    }
}
