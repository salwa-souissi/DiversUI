using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiversUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckboxesPage : ContentPage
    {
        private List<ImageGallery> DogImages;
        private List<ImageGallery> CatImages;
        private List<ImageGallery> BirdImages;
        private List<ImageGallery> ListImages;
        public CheckboxesPage()
        {
            InitializeComponent();

            BindingContext = this;
            DogImages = new List<ImageGallery>
            {
                new ImageGallery
                {
                    category = "Dogs",
                    source = "dog1.png"
                },
                new ImageGallery
                {
                    category = "Dogs",
                    source = "dog2.png"
                },
                new ImageGallery
                {
                    category = "Dogs",
                    source = "dog3.png"
                }
            };
            CatImages = new List<ImageGallery>
            {
                new ImageGallery
                {
                    category = "Cats",
                    source = "cat1.png"
                },
                new ImageGallery
                {
                    category = "Cats",
                    source = "cat2.png"
                },
                new ImageGallery
                {
                    category = "Cats",
                    source = "cat3.png"
                }
            };
            BirdImages = new List<ImageGallery>
            {
                new ImageGallery
                {
                    category = "Birds",
                    source = "bird1.png"
                },
                new ImageGallery
                {
                    category = "Birds",
                    source = "bird2.png"
                },
                new ImageGallery
                {
                    category = "Birds",
                    source = "bird3.png"
                }
            };
            ListImages = new List<ImageGallery>();
            foreach (var VARIABLE in DogImages)
            {
                ListImages.Add(VARIABLE);

            }
            foreach (var VARIABLE in CatImages)
            {
                ListImages.Add(VARIABLE);

            }
            foreach (var VARIABLE in BirdImages)
            {
                ListImages.Add(VARIABLE);

            }

            MainCarouselView.ItemsSource = ListImages;

        }




        private void Button_OnClicked(object sender, EventArgs e)
        {
            if (Cats.BackgroundColor == Color.Black)
            {

            }
            else if (Dogs.BackgroundColor == Color.Black)
            {

            }
            else if (Birds.BackgroundColor == Color.Black)
            {

            }

        }



        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
        bool tab1Checked = false;
        public bool Tab1Checked
        {
            get { return tab1Checked; }
            set { SetProperty(ref tab1Checked, value); }
        }


        bool tab2Checked = false;
        public bool Tab2Checked
        {
            get { return tab2Checked; }
            set { SetProperty(ref tab2Checked, value); }
        }


        bool tab3Checked = false;
        public bool Tab3Checked
        {
            get { return tab3Checked; }
            set { SetProperty(ref tab3Checked, value); }
        }

        public ICommand TabTappedCommand
        {
            get
            {
                return new Command((e) =>
                {
                    if (int.Parse(e.ToString()) == 1)
                    {
                        Tab1Checked = true;

                    }
                  if (int.Parse(e.ToString()) == 2)
                    {
                        Tab2Checked = true;

                    }
                   if (int.Parse(e.ToString()) == 3)
                    {
                        Tab3Checked = true;

                    }
                });
            }

        }

    }
}