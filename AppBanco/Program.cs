using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBanco.Models;
using AppBanco.Services;

namespace AppBanco
{

    /// <summary>
    /// Punto de entrada. Aquí “cargamos” una cuenta inicial y lanzamos el cajero.
    /// Luego podremos cambiar a múltiples cuentas/usuarios.
    /// </summary>
    internal class Program
    {
        // OJO: No declares ningún método o propiedad llamado "Program" aquí

        private static void Main(string[] args)
        {
            // Prueba con Débito:
            // var cuenta = new CuentaDebito(
            //     id: 1, saldo: 1500m, numeroCuenta: 1111,
            //     numeroCliente: "C001", nombreCliente: "Angélica Torres",
            //     fechaApertura: "10/01/2025", montoMinimo: 0m
            // );

            // Prueba con Crédito:
            var cuenta = new CuentaCredito(
                id: 2, saldo: 0m, numeroCuenta: 2222,
                numeroCliente: "C002", nombreCliente: "Angélica Torres",
                fechaApertura: "01/02/2025",
                fechaCorte: "28/10/2025", tasa: 0.035m, limite: 10000m
            );

            var cajero = new Cajero(cuenta, "1234", 3);
            cajero.Iniciar();
        }
    }
}
      
          
