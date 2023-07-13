string [] palabras = new string [3];

    palabras[0] = "gston";
    palabras[1] = "heladera";
    palabras[2] = "sosdofdfdf";
    
int[] cantidades = {5,25,3,56,6};

    Console.WriteLine($" Cantidad de elementos {palabras.Length}");

    foreach(string palabra in palabras){
  
        if(palabra.StartsWith("h"))
        Console.WriteLine("HURRA");
        Console.WriteLine(palabra);
        Console.WriteLine( palabra.GetType());
    }
    foreach(int numero in cantidades){

        Console.WriteLine(numero);

    }








/*
Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

    Console.WriteLine($"expira en {daysUntilExpiration}");
    


if( daysUntilExpiration <= 10){
    if(daysUntilExpiration == 0)
        Console.WriteLine("Your subscritption has expired.");


    else if( daysUntilExpiration == 1){
        Console.WriteLine("Your subcription expires within a day!");
            discountPercentage = 20;

    }

    else if (daysUntilExpiration <= 5){
        Console.WriteLine($"Your subcription expire in {daysUntilExpiration +1}") ;      
        discountPercentage = 10;
        }


    else if (daysUntilExpiration >5 ){
        Console.WriteLine("Your subscription will expire soon. Renew now!");
        
        }
        
    if (discountPercentage > 0)
        Console.WriteLine($"Renew now and save {discountPercentage}%");

}




Random x = new Random();

int roll1 = x.Next(1, 7);
int roll2 = x.Next(1, 7);
int roll3 = x.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if (total > 10) 
Console.WriteLine("GANASTE");
else 
Console.WriteLine("PERDISTE");


string[] listaditoNmbres = {"pepe", "pipo", "telefono"};

    Console.WriteLine(listaditoNmbres[2]);


int tamaño = listaditoNmbres.Length;

    Console.WriteLine($" cantidad de objetos {tamaño} ");

string mensaje = " tres tigres comian trigo en un trigal ¿cuantos tigres tigraban trigo?";

bool resultado = mensaje.Contains("comian");

Console.WriteLine(resultado);

resultado = mensaje.Contains("estrella");
Console.WriteLine(resultado);

if (mensaje.Contains("cuatro")){


    Console.WriteLine("SI");
}
else { 

    
    Console.WriteLine("NO");

}
*/