
public class Lista
{
    private Item _primeiroItem { get; set; }
    public void Addicionar(int valor){
        Item item = new Item();
        item.Valor = valor;

        if (_primeiroItem == null) 
        {
            _primeiroItem = item;    
            return;
        } 

        Item itemAtual = _primeiroItem;

        while (itemAtual.ProximoItem != null)
        {
            itemAtual = itemAtual.ProximoItem;
        }
        itemAtual.ProximoItem = item;
    }

    public void Mostrar()
    {
        Item itemAtual = _primeiroItem;
        
        while (itemAtual.ProximoItem != null)
        {
            Console.WriteLine(itemAtual.Valor);
            itemAtual = itemAtual.ProximoItem;
        }
        Console.WriteLine(itemAtual.Valor);
    }
}
