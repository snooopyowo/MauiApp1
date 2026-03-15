namespace MauiApp1
{
    using System.Collections.ObjectModel;

    public partial class MainPage : ContentPage
    {

        ObservableCollection<Produto> Produtos;
        ObservableCollection<Produto> ProdutosFiltrados;

        public MainPage()
        {
            InitializeComponent();

            Produtos = new ObservableCollection<Produto>()
        {
            new Produto { Nome="Mouse", Preco=50 },
            new Produto { Nome="Teclado", Preco=120 },
            new Produto { Nome="Monitor", Preco=900 },
            new Produto { Nome="Headset", Preco=200 }
        };

            ProdutosFiltrados = new ObservableCollection<Produto>(Produtos);

            ListaProdutos.ItemsSource = ProdutosFiltrados;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = e.NewTextValue.ToLower();

            ProdutosFiltrados.Clear();

            foreach (var produto in Produtos)
            {
                if (produto.Nome.ToLower().Contains(texto))
                {
                    ProdutosFiltrados.Add(produto);
                }
            }
        }
    }
}