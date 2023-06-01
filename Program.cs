using EmpleadoSpace;

Empleado empleado = new Empleado("Jorge", "", new DateTime(2002, 12, 19), 'S', 'M', new DateTime(2010, 6, 1), 100000, Cargo.Administrativo);

Console.WriteLine($"El empleado tiene {empleado.antiguedad()} años trabajando en la empresa");
Console.WriteLine($"El empleado tiene {empleado.edad()} años existiendo en este planeta");