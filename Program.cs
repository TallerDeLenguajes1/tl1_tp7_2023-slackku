using EmpleadoSpace;


// INSTANCIAS DE EMPLEADO
Empleado empleado1 = new Empleado("Jorge", "Onemp", new DateTime(2001, 1, 1), 'C', 'M', new DateTime(2008, 8, 8), 10000, Cargo.Ingeniero);
Empleado empleado2 = new Empleado("Jorge", "Twopper", new DateTime(2002, 2, 2), 'S', 'M', new DateTime(2009, 9, 9), 20000, Cargo.Especialista);
Empleado empleado3 = new Empleado("Jorge", "Threesther", new DateTime(2003, 3, 3), 'C', 'M', new DateTime(2010, 10, 10), 30000, Cargo.Administrativo);

// LISTA DE OBJETOS EMPLEADO
List<Empleado> listaEmpleados = new List<Empleado>();
listaEmpleados.Add(empleado1);
listaEmpleados.Add(empleado2);
listaEmpleados.Add(empleado3);

// SALARIO TOTAL ENTRE LOS 3 EMPLEADOS
double salariosTotal = 0;
listaEmpleados.ForEach(emp => { salariosTotal += emp.salario(); });
Console.WriteLine($"===== MONTO TOTAL EN CONCEPTO DE SALARIOS: {salariosTotal} =====");
int x = 100;
Empleado outputEmpleado = new Empleado();

int less = listaEmpleados.Min(empl => empl.faltaParaJubilar());
listaEmpleados.ForEach(emp =>
{
    if (emp.faltaParaJubilar() < x)
    {
        x = emp.faltaParaJubilar();
        outputEmpleado = emp;
    }
});

Console.WriteLine("======== EMPLEADO MÁS CERCANO A JUBILARSE ========");
Console.WriteLine($"El empleado tiene {outputEmpleado.antiguedad()} años trabajando en la empresa");
Console.WriteLine($"El empleado tiene {outputEmpleado.edad()} años");
Console.WriteLine($"El empleado tiene como salario ${outputEmpleado.salario()}");


