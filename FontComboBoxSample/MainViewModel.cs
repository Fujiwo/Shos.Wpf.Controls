#nullable enable

using Prism.Mvvm;

namespace FontComboBoxSample
{
    class MainViewModel : BindableBase
    {
        string selectedFontFamilyName;

        public string SelectedFontFamilyName {
            get => selectedFontFamilyName;
            set => SetProperty(ref selectedFontFamilyName, value);
        }

        string selectedLocalFontFamilyName;

        public string SelectedLocalFontFamilyName {
            get => selectedLocalFontFamilyName;
            set => SetProperty(ref selectedLocalFontFamilyName, value);
        }

        public MainViewModel()
            => selectedFontFamilyName = selectedLocalFontFamilyName = "Arial";
    }
}
