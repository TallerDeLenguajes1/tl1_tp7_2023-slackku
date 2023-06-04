using EspacioCalculadora;

int keepOn = 1;

Console.WriteLine("====================");
Console.WriteLine("    CALCULADORA    ");
Console.WriteLine("====================");
while (keepOn == 1)
{
    Console.Write("Ingrese un numero: ");
    string? preNum = Console.ReadLine();
    if (Single.TryParse(preNum, out float n1))
    {
        float num = Single.Parse(preNum);
        Calculadora Calculadora = new Calculadora(num);
        Console.WriteLine("1: Sumar | 2: Restar | 3: Multiplicar | 4: Dividir | 5: Limpiar | 6: Terminar");
        Console.Write("Ingrese la opcion: ");
        string? preOp = Console.ReadLine();
        if (Single.TryParse(preOp, out float n2))
        {
            float optionF = Single.Parse(preOp);
            int option = (int)optionF;

            if (option > 0 && option < 6)
            {
                Console.Write($"Ingrese el número: ");
                string? preSNum = Console.ReadLine();
                if (Single.TryParse(preSNum, out float n3))
                {
                    float num2 = Single.Parse(preSNum);

                    if (num2 == 0 && option == 4)
                    {
                        Console.WriteLine("Error: La division por cero no esta definida");
                    }
                    else
                    {
                        switch (option)
                        {
                            case 1:
                                Calculadora.Sumar(num2);
                                break;
                            case 2:
                                Calculadora.Restar(num2);
                                break;
                            case 3:
                                Calculadora.Multiplicar(num2);
                                break;
                            case 4:
                                Calculadora.Dividir(num2);
                                break;
                            case 5:
                                Calculadora.Limpiar();
                                break;
                        }
                        Console.WriteLine($"Resultado {Calculadora.Resultado}");
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es valido.");
                }
            }
            else
            {
                if (option == 6)
                {
                    keepOn = 0;
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida.");
                }
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es valido.");
        }
    }

    else
    {
        Console.WriteLine("El valor ingresado no es valido.");
    }
}