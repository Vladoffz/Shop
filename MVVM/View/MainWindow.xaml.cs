using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
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
using BLL.Impl;
using Entities;
using Models;
using MVVM.ViewModel;

namespace MVVM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Base();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {

            GoodDTO good = new GoodDTO
            {
                Height = Int32.Parse(HeightTextBox.Text), Weight = Int32.Parse(WeightTextBox.Text),
                Width = Int32.Parse(WidthTextBox.Text), Name = NameTextBox.Text
            };
            GoodService goodService = new GoodService();
            goodService.Create(good);

            MessageBox.Show("Order added");
        }

        public class JsonSerialization<T>
        {
            public string path { get; set; }
            public T obj { get; set; }
            DataContractJsonSerializer jsonFormatter;

            public JsonSerialization(string path, T obj)
            {
                this.path = path;
                this.obj = obj;

                jsonFormatter = new DataContractJsonSerializer(typeof(T));
            }

            public bool Serialize()
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, obj);
                    return true;
                }
            }

            public T Deserialize()
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    T newObject = (T) jsonFormatter.ReadObject(fs);
                    return newObject;
                }
            }
        }
    }
}

