using System;
class URI {

    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */

        int employeeNumber = int.Parse(Console.ReadLine());
        int workedHours = int.Parse(Console.ReadLine());
        float amount_hours = float.Parse(Console.ReadLine()); //5.50
        
        float salary = workedHours * amount_hours;

        Console.WriteLine($"NUMBER = {employeeNumber}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");
    }

}