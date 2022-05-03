using Notepad_Plus_Plus.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Notepad_Plus_Plus.Models
{
    public class FormatModel : ObservableObject
    {
        private FontStyle style;
        public FontStyle Style
        {
            get { return style; }
            set { style = value; OnPropertyChanged(nameof(Style)); }
        }

        private FontWeight weight;
        public FontWeight Weight
        {
            get { return weight; }
            set { weight = value; OnPropertyChanged(nameof(Weight)); }
        }

        private FontFamily family;
        public FontFamily Family
        {
            get { return family; }
            set { family = value; OnPropertyChanged(nameof(Family)); }
        }

        private TextWrapping wrap;
        public TextWrapping Wrap
        {
            get { return wrap; }
            set { wrap = value; OnPropertyChanged(nameof(Wrap)); }
        }

        private bool isWrapped;
        public bool IsWrapped
        {
            get { return isWrapped; }
            set { isWrapped = value; OnPropertyChanged(nameof(IsWrapped)); }
        }

        private double size;
        public double Size
        {
            get { return size; }
            set { size = value; OnPropertyChanged(nameof(Size)); }
        }
    }
}
