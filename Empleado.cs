namespace EmpleadoSpace;

class Empleado
{
    private string? Nombre;
    private string? Apellido;
    private DateTime FechaDeNacimiento;
    private char EstadoCivil;
    private char Genero;
    private DateTime FechaJoinOrg;
    private double SueldoBasico;
    private Cargo? CargoEmpleado;

    public Empleado()
    {

    }

    public Empleado(string name, string sname, DateTime fecNac, char estCivil, char gen, DateTime fecJoin, double bSueldo, Cargo carg)
    {
        Nombre = name;
        Apellido = sname;
        FechaDeNacimiento = fecNac;
        EstadoCivil = estCivil;
        Genero = gen;
        FechaJoinOrg = fecJoin;
        SueldoBasico = bSueldo;
        CargoEmpleado = carg;
    }

    public int antiguedad()
    {
        DateTime Today = DateTime.Now;
        return (Today.Subtract(FechaJoinOrg).Days / 365);
    }

    public int edad()
    {
        DateTime Today = DateTime.Now;
        return (Today.Subtract(FechaDeNacimiento).Days / 365);
    }

    public int faltaParaJubilar()
    {
        int e = edad();
        int tiempo = Genero == 'M' ? (65 - e) : (60 - e);
        return tiempo;
    }

    public double salario()
    {
        int antiq = antiguedad();
        double adicional;
        if (antiq < 20)
        {
            adicional = SueldoBasico * (0.01 * antiq);
        }
        else
        {
            adicional = SueldoBasico * 0.25;
        }
        if (CargoEmpleado == Cargo.Especialista || CargoEmpleado == Cargo.Ingeniero)
        {
            adicional += adicional * 0.5;
        }
        if (EstadoCivil == 'C')
        {
            adicional += 15000;
        }

        return SueldoBasico + adicional;
    }

}

public enum Cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}