namespace EspacioCalculadora;

class Calculadora
{
    private float dato;

    public Calculadora(float num)
    {
        dato = num;
    }

    public float Resultado
    {
        get => dato;
    }

    public void Sumar(float termino)
    {
        dato += termino;
    }
    public void Restar(float termino)
    {
        dato -= termino;
    }
    public void Multiplicar(float termino)
    {
        dato *= termino;
    }
    public void Dividir(float termino)
    {
        dato /= termino;
    }
    public void Limpiar()
    {
        dato = 0;
    }



}