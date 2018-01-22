using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamFormsApp
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
            var grid = new Grid
            {
                RowSpacing = 40,
                ColumnSpacing= 40,
                BackgroundColor = Color.Yellow
            };
            int lblCount = 0;
            for (int row=0; row < 2; row++){
                for (int col = 0; col < 2; col++)
                {
                    var label = new Label { Text = "Label " + (lblCount + 1), BackgroundColor = Color.Silver };
                    grid.Children.Add(label, col, row);
                    lblCount++;
                }
            }
            for (int rowcolDef = 0; rowcolDef < 2; rowcolDef++){
				grid.RowDefinitions.Add(new RowDefinition
				{
					Height = new GridLength(10, GridUnitType.Star) //Propotioanl Height, so use GridUnitType.Star
				});
                grid.ColumnDefinitions.Add(new ColumnDefinition{
                    Width = new GridLength(10, GridUnitType.Star) //Propotioanl Width, so use GridUnitType.Star
				});
            }
        }
    }
}
