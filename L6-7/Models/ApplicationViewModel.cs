using L6_7.Infrastructure.Commands;
using L6_7.Infrastructure.Files;
using L6_7.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using L6_7.Models;
using System.Windows;

namespace L6_7.Models
{
    public class ApplicationViewModel : ViewModelBase, INotifyPropertyChanged
    {
        Watch selectedWatch;
        IFileService fileService;
        IDialogService dialogService;
        public ObservableCollection<Watch> Watchs { get => watchs; 
            set { watchs = value; OnPropertyChanged("SearchedWatches"); } }

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.SaveFileDialog() == true)
                          {
                              fileService.Save(dialogService.FilePath, Watchs.ToList());
                              dialogService.ShowMessage("Файл сохранен");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.OpenFileDialog() == true)
                          {
                              var watchs = fileService.Open(dialogService.FilePath);
                              Watchs.Clear();
                              foreach (var p in watchs)
                                  Watchs.Add(p);
                              dialogService.ShowMessage("Файл открыт");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Watch watch = new Watch();
                      Watchs.Insert(0, watch);
                      SelectedWatch = watch;
                  }));
            }
        }

        private RelayCommand filterOfCost;
        public RelayCommand FilterOfCost
        {
            get
            {
                return filterOfCost ??
                  (filterOfCost = new RelayCommand(obj =>
                  {
                      searchedWatches = new ObservableCollection<Watch>(Watchs.Where(x => x.Price > 50000).ToList());
                      OnPropertyChanged("SearchedWatches");

                  }));
            }
        }

        public RelayCommand filterOfCountry;
        public RelayCommand FilterOfCountry
        {
            get
            {
                return filterOfCountry ??
                  (filterOfCountry = new RelayCommand(obj =>
                  {
                      searchedWatches = new ObservableCollection<Watch>(Watchs.Where(x => x.Country.Equals("Китай")).ToList());
                      OnPropertyChanged("SearchedWatches");
                  }));
            }
        }

        private string search;
        private ObservableCollection<Watch> searchedWatches;
        public string Search
        {
            get { return search; }
            set
            {
                search = value;
                searchedWatches = new ObservableCollection<Watch>(Watchs.Where(e => e.Name.ToLower().Contains(search.ToLower())));
                OnPropertyChanged("SearchedWatches");
            }
        }

        private RelayCommand removeCommand;
        private ObservableCollection<Watch> watchs;

        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Watch watch = obj as Watch;
                      if (watch != null)
                      {
                          Watchs.Remove(watch);
                      }
                  },
                 (obj) => Watchs.Count > 0));
            }
        }
        public Watch SelectedWatch
        {
            get { return selectedWatch; }
            set
            {
                selectedWatch = value;
                OnPropertyChanged("SelectedWatch");
            }
        }
        private string _title = "Магазин Часов";
        public string Title
        {
            get { return _title; }
            set
            {
                Set(ref _title, value);
            }
        }
        public ICommand CloseAppComm { get; }
        private void OnCloseAppCommExecute(object d)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseAppCommExecute(object d) => true;
        public ICommand ChangeLanguageCommand { get; }
        private void OnChangeLanguageCommandExecuted(object o)
        {
            string lang = o as string;
            switch (lang)
            {
                case "Анг":
                    Application.Current.Resources.MergedDictionaries[0].Source = new Uri("./Infrastructure/Resources/Eng.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "Рус":
                    Application.Current.Resources.MergedDictionaries[0].Source = new Uri("./Infrastructure/Resources/Rus.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    break;
            }
        }
        public ObservableCollection<Watch> SearchedWatches { get => searchedWatches; set => searchedWatches = value; }

        public ApplicationViewModel(IDialogService dialogService, IFileService fileService)
        {
            this.dialogService = dialogService;
            this.fileService = fileService;

            // данные по умлолчанию
            Watchs = new ObservableCollection<Watch>
            {new Watch {Name="Беларусь", Country="Китай", Price=56000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\1.jpg"},
                new Watch {Name="Офис", Country="Америка", Price =60000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\3.jpg" },
                new Watch {Name="Весна", Country="Испания", Price=76000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\4.jpg" },
                new Watch {Name="Циферки", Country="Китай", Price=36000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\2.jpg" },
                new Watch {Name="Капли", Country="Китай", Price=26000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\5.jpg" },
                new Watch {Name="Люди", Country="Америка", Price=58000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\9.webp" },
                new Watch {Name="Римские", Country="Италия", Price=46000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\7.jpg"},
                new Watch {Name="Уличные", Country="Россия", Price=96000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\8.jpg" },
                new Watch {Name="Антиквар", Country="Китай", Price=35000,DisplayedImage=@"D:\универ\ооп\oop-4sem\L6-7\6.jpg" }
            };
            searchedWatches = new ObservableCollection<Watch>(Watchs);
            CloseAppComm = new RelayCommand(OnCloseAppCommExecute, CanCloseAppCommExecute);
            ChangeLanguageCommand = new RelayCommand(OnChangeLanguageCommandExecuted);
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}