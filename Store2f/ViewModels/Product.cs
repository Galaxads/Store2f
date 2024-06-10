using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2f.ViewModels
{
    internal class Product
    {
        public int _Id;
        public string _Name;
        public string _Description;
        public string _Manufacturer;
        public int _Price;
        public string _Photo;
        public int _Stock;
        public string? _Color;
        public string? imageSource;

        public Product(int _Id, string _Name, string _Description, string _Manufacturer, int _Price, string _Photo, int _Stock)
        {
            this._Id = _Id;
            this._Name = _Name;
            this._Description = _Description;
            this._Manufacturer = _Manufacturer;
            this._Price = _Price;
            this.imageSource = _Photo;
            this._Stock = _Stock;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; }

        }
        public int Price
        { get { return _Price; } 
          set { _Price = value; }
        }
        public string Description
        { get { return _Description; }
          set { _Description = value; }
          
        }
        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }
        public String? photoPath
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
        public Bitmap? photo => photoPath != null ? new Bitmap($"Assets/{photoPath}") : new Bitmap($"Assets/placeholder.jpg");
    }
}
