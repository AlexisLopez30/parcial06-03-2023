using Parcial.Entidades;
using Parcial.Negocio;




using System;

Usuario usuario = new Usuario();
ClsUsuario clsUsuario = new ClsUsuario();
Venta venta = new Venta();
ClsVentas clsVentas = new ClsVentas();

Console.WriteLine("Ingrese su usuario");
usuario.usuario = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña");
usuario.password = Console.ReadLine();

bool Resultado = clsUsuario.Autenticacion(usuario);
if (Resultado == true)
{
    Console.WriteLine("Bienvenido ");
    
    Console.Write("\n identificador del producto: ");
    venta.IdProducto = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n nombre del producto: ");
    venta.NomProducto = Console.ReadLine();
    Console.Write("\n descripcion del producto: ");
    venta.DescripProducto = Console.ReadLine();
    Console.Write("\n el precio del producto:  ");
    venta.PreProducto = Convert.ToDouble(Console.ReadLine());
    Console.Write("\n cantidad del producto que lleva: ");
    venta.CantidadProducto = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($@"El ID del producto es: {venta.IdProducto}
El producto que lleva es: {venta.NomProducto}
El precio del producto es: {venta.PreProducto}
El total a pagar es: {clsVentas.Cobro(venta)}");
}
else
{
    Console.WriteLine("Tu contraseña o tu usuario son incorrectos");
}