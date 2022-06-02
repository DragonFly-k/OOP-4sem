using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using L10.ViewModels.Base;
using L10.Infrastructure.Commands;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;
using Microsoft.Win32;
using System.IO;
using System.Windows.Media.Imaging;
using L10.Model;
using L10.db;
using L10.db.model;
using System.Text;

namespace L10.ViewModels
{
    //class MainWindowViewModel : ViewModel
    //{
    //    private UnitOfWork _dbWorker = new UnitOfWork();

    //    private string _pathIcon = null;

    //    #region Model

    //    #region Products
    //    private ObservableCollection<ProductInfo> _products;
    //    public ObservableCollection<ProductInfo> Products
    //    {
    //        get => _products;
    //        set => Set(ref _products, value);
    //    }
    //    #endregion

    //    #region Name
    //    private string _name;
    //    public string Name
    //    {
    //        get => _name;
    //        set => Set(ref _name, value);
    //    }
    //    #endregion

    //    #region Qty
    //    private int _qty;
    //    public int Qty
    //    {
    //        get => _qty;
    //        set => Set(ref _qty, value);
    //    }
    //    #endregion

    //    #region Weight
    //    private int _weight;
    //    public int Weight
    //    {
    //        get => _weight;
    //        set => Set(ref _weight, value);
    //    }
    //    #endregion

    //    #region SelectedProduct
    //    private ProductInfo _selectedProduct;
    //    public ProductInfo SelectedProduct
    //    {
    //        get => _selectedProduct;
    //        set => Set(ref _selectedProduct, value);
    //    }
    //    #endregion

    //    #endregion

    //    #region Команды

    //    #region LoadedCommand
    //    public ICommand LoadedCommand { get; }
    //    private bool CanLoadedCommandExecute(object p) => true;
    //    private void OnLoadedCommandExecuted(object p)
    //    {
    //        ObservableCollection<ProductInfo> products = new ObservableCollection<ProductInfo>();
    //        List<Product> sellers = _dbWorker.Products.GetAll().ToList();

    //        string sqlExpression = "sp_GetProductsInfo";
    //        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString))
    //        {
    //            connection.Open();

    //            SqlCommand command = new SqlCommand(sqlExpression, connection);
    //            command.CommandType = CommandType.StoredProcedure;
    //            using (SqlDataReader reader = command.ExecuteReader())
    //            {
    //                if (reader.HasRows)
    //                {
    //                    while (reader.Read())
    //                    {
    //                        byte[] photoByteArray = (byte[])reader.GetValue(5);
    //                        BitmapFrame bitmapImage;
    //                        using (var ms = new MemoryStream(photoByteArray))
    //                        {
    //                            bitmapImage = BitmapFrame.Create(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
    //                        }

    //                        ProductInfo product = new ProductInfo()
    //                        {
    //                            Id = reader.GetInt32(0),
    //                            Name = reader.GetString(1),
    //                            Weight = reader.GetInt32(2),
    //                            Qty = reader.GetInt32(3),
    //                            IconId = reader.GetInt32(4),
    //                            Photo = bitmapImage
    //                        };

    //                        products.Add(product);
    //                    }
    //                }
    //            }
    //        }

    //        Products = products;
    //    }
    //    #endregion

    //    #region ChoosePhotoCommand
    //    public ICommand ChoosePhotoCommand { get; }
    //    private bool CanChoosePhotoCommandExecute(object p) => true;
    //    private void OnChoosePhotoCommandExecuted(object p)
    //    {
    //        OpenFileDialog openFileDialog = new OpenFileDialog();
    //        openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
    //        openFileDialog.InitialDirectory = @"D:\универ\ооп\oop-4sem\L6-7\";

    //        if (openFileDialog.ShowDialog() == true)
    //        {
    //            _pathIcon = openFileDialog.FileName;
    //        }
    //    }
    //    #endregion
    //    #region AddProductCommand
    //    public ICommand AddProductCommand { get; }
    //    private bool CanAddProductCommandExecute(object p)
    //    {
    //        return Name?.Length != 0 && Qty != 0 && Weight != 0 && _pathIcon?.Length != null;
    //    }
    //    private void OnAddProductCommandExecuted(object p)
    //    {
    //        BitmapFrame bitmapImage = null;
    //        byte[] photoByteArray = null;
    //        if (_pathIcon != null)
    //        {
    //            photoByteArray = File.ReadAllBytes(_pathIcon);
    //            using (var ms = new MemoryStream(photoByteArray))
    //            {
    //                bitmapImage = BitmapFrame.Create(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
    //            }
    //        }

    //        Product product = new Product()
    //        {
    //            Name = Name,
    //            Qty = Qty,
    //            Weight = Weight
    //        };
    //        ProductService productService = new ProductService();
    //        int id = productService.Add(product);

    //        db.model.Icon icon = new db.model.Icon()
    //        {
    //            ProductId = id,
    //            Photo = photoByteArray
    //        };
    //        IconService iconService = new IconService();
    //        int iconId = iconService.Add(icon);

    //        ProductInfo productInfo = new ProductInfo()
    //        {
    //            Id = id,
    //            IconId = iconId,
    //            Name = Name,
    //            Qty = Qty,
    //            Weight = Weight,
    //            Photo = bitmapImage
    //        };
    //        Products.Add(productInfo);

    //        Name = "";
    //        Qty = 0;
    //        Weight = 0;
    //        _pathIcon = null;
    //    }
    //    #endregion
    //    #region RemoveProductCommand
    //    public ICommand RemoveProductCommand { get; }
    //    private bool CanRemoveProductCommandExecute(object p) => SelectedProduct != null;
    //    private void OnRemoveProductCommandExecuted(object p)
    //    {
    //        IconService iconService = new IconService();
    //        iconService.RemoveById(SelectedProduct.IconId);

    //        ProductService productService = new ProductService();
    //        productService.RemoveById(SelectedProduct.Id);

    //        Products.Remove(SelectedProduct);
    //    }
    //    #endregion

    //    #endregion

    //    public MainWindowViewModel()
    //    {
    //        #region Команды
    //        LoadedCommand = new LambdaCommand(OnLoadedCommandExecuted, CanLoadedCommandExecute);
    //        ChoosePhotoCommand = new LambdaCommand(OnChoosePhotoCommandExecuted, CanChoosePhotoCommandExecute);
    //        AddProductCommand = new LambdaCommand(OnAddProductCommandExecuted, CanAddProductCommandExecute);
    //        RemoveProductCommand = new LambdaCommand(OnRemoveProductCommandExecuted, CanRemoveProductCommandExecute);
    //        #endregion
    //    }
    //}


    class MainWindowViewModel : ViewModel
    {
        private UnitOfWork _dbWorker = new UnitOfWork();

        #region Models

        #region Asks
        private ObservableCollection<Ask> _asks;
        public ObservableCollection<Ask> Asks
        {
            get => _asks;
            set => Set(ref _asks, value);
        }
        #endregion

        #region NameSeller
        private string _nameSeller;
        public string NameSeller
        {
            get => _nameSeller;
            set => Set(ref _nameSeller, value);
        }
        #endregion

        #region NameProduct
        private string _nameProduct;
        public string NameProduct
        {
            get => _nameProduct;
            set => Set(ref _nameProduct, value);
        }
        #endregion

        #region Price
        private int _price;
        public int Price
        {
            get => _price;
            set => Set(ref _price, value);
        }
        #endregion

        #region Weight
        private int _weight;
        public int Weight
        {
            get => _weight;
            set => Set(ref _weight, value);
        }
        #endregion

        #region SelectedAsk
        private Ask _selectedAsk;
        public Ask SelectedAsk
        {
            get => _selectedAsk;
            set => Set(ref _selectedAsk, value);
        }
        #endregion

        #endregion

        #region Команды

        #region LoadedCommand
        public ICommand LoadedCommand { get; }
        private bool CanLoadedCommandExecute(object p) => true;
        private async void OnLoadedCommandExecutedAsync(object p)
        {
            ObservableCollection<Ask> asks = new ObservableCollection<Ask>();

            List<Seller> sellers = _dbWorker.Sellers.GetAll().ToList();
            foreach (var seller in sellers)
            {
                Ask ask = new Ask()
                {
                    IdSeller = seller.Id,
                    IdProduct = seller.Products.First().Id,
                    NameSeller = seller.Name,
                    NameProduct = seller.Products.First().Name,
                    Price = seller.Products.First().Price,
                    Weight = seller.Products.First().Weight
                };
                asks.Add(ask);
            }

            Asks = asks;

            await _dbWorker.Sellers.PrintAllAsync();
        }
        #endregion

        #region AddAskCommand
        public ICommand AddAskCommand { get; }
        private bool CanAddAskCommandExecute(object p)
        {
            return NameSeller?.Length != 0 && NameProduct?.Length != 0 && Price != 0 && Weight != 0;
        }
        private void OnAddAskCommandExecuted(object p)
        {
            using (var transaction = _dbWorker.BeginTransaction())
            {
                try
                {
                    Seller seller = new Seller()
                    {
                        Name = NameSeller,
                    };
                    _dbWorker.Sellers.Insert(seller);
                    _dbWorker.Save();

                    Product product = new Product()
                    {
                        Name = NameProduct,
                        Weight = Weight,
                        Price = Price,
                        SellerId = seller.Id
                    };
                    _dbWorker.Products.Insert(product);
                    _dbWorker.Save();

                    Ask ask = new Ask()
                    {
                        IdSeller = seller.Id,
                        IdProduct = product.Id,
                        NameSeller = seller.Name,
                        NameProduct = product.Name,
                        Weight = product.Weight,
                        Price = product.Price
                    };
                    transaction.Commit();
                    Asks.Add(ask);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }
        #endregion
        #region RemoveAskCommand
        public ICommand RemoveAskCommand { get; }
        private bool CanRemoveAskCommandExecute(object p) => SelectedAsk != null;
        private void OnRemoveAskCommandExecuted(object p)
        {
            _dbWorker.Products.Delete(SelectedAsk.IdProduct);
            _dbWorker.Save();
            _dbWorker.Sellers.Delete(SelectedAsk.IdSeller);
            _dbWorker.Save();

            Asks.Remove(SelectedAsk);
        }
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            LoadedCommand = new LambdaCommand(OnLoadedCommandExecutedAsync, CanLoadedCommandExecute);

            AddAskCommand = new LambdaCommand(OnAddAskCommandExecuted, CanAddAskCommandExecute);
            RemoveAskCommand = new LambdaCommand(OnRemoveAskCommandExecuted, CanRemoveAskCommandExecute);
            #endregion
        }
    }
}
