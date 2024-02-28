### Elementos complementarios 
Documentacion adicional y mas detallada de cada patron de diseño [(Doc Word)](https://1drv.ms/w/s!AgoIQHtvH_IShbY4jst9pVloaKYgTg?e=oy0KvY).

Patrones de diseño implementados en ASP.NET [(Repositorio) ]()

# Patrones de diseño
#### ¿Que son los patrones de diseño?
Son técnicas para resolver problemas en común que han surgido a través de la historia de la programación, problemas que se han resuelto con esta técnica y que ya se a comprobado que esta técnica lo resuelve.

Aparte de resolver el problema te dará mantenimiento a ese problema, escalabilidad, legibilidad y un lenguaje abstracto para que si algún día un programador ve ese codigo y entienda ese patrón de diseño no puede entender más fácil .

## Patrones de diseño en repasados en este repositorio
> Haga 'clic' en el nombre del patron para acceder a los archivos en el repositorio
### [Singelton](https://github.com/JairMora21/PatronesDeDiseno/tree/master/Singelton) (Creacional)
Este patrón nos sirve para crear objetos, debe existir si o si un objeto en nuestra aplicación, porque quizá este objeto es muy complejo de crear, tiene problemas de performance o rendimiento .

Está diseñado para restringir la creación de objetos pertenecientes a una clase o el valor de un tipo a un único objeto. Su intención consiste en garantizar que una clase sólo tenga una instancia y proporcionar un punto de acceso global a ella.

**Pequeño ejemplo**
```csharp
var singleton1 = Singleton.Instance;
var singleton2 = Singleton.Instance;
Console.WriteLine(singleton1 == singleton2);
// OUTPUT: True
```

### [Factory Method](https://github.com/JairMora21/PatronesDeDiseno/tree/master/FactoryPattern) (Creacional)
Imagina que tienes una fabrica, esta fabrica hace productos, estos productos pueden ser de distinto tipo entonces tu puedes tener un conjunto de fábricas. Prácticamente es una fabrica creadora de objetos
Su objetivo principal es proporcionar una interfaz para crear instancias de una clase, pero permitiendo a las subclases alterar el tipo de instancias que se crearán.

**Pequeño ejemplo**
```csharp
SaleFactory storeSaleFactory = new StoreSaleFactory(10);
SaleFactory internetSaleFactory = new InternetSaleFactory(2);

ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(100);
//OUTPUT:  Total TIENDA: 110

ISale sale2 = internetSaleFactory.GetSale();
sale2.Sell(100);
//OUTPUT:  Total INTERNET: 98
```

### [Dependency Injection](https://github.com/JairMora21/PatronesDeDiseno/tree/master/DependencyInjection)
La inyección de dependencia trata de quitar la responsabilidad de una clase y de crear objetos a partir de otras clases 
Es decir, esta clase no debe saber como crear ciertos objetos, puede tener objetos hijos pero no tiene que saber como crearlos 
Estas generalmente se inyectan en el constructor de donde queramos utilizarlas.

**Pequeño ejemplo**
```csharp
public class Service
{
    private readonly ILogger logger;

    // Constructor con inyección de dependencia
    public Service(ILogger logger)
    {
        this.logger = logger;
    }

    public void DoSomething()
    {
        // Utiliza el logger para registrar un mensaje
        logger.Log("Doing something...");
    }
}
```
### [Repository](https://github.com/JairMora21/PatronesDeDiseno/tree/master/RepositoryPattern)
Imaginemos que tenemos varias fuentes de datos, estas fuentes pueden ser como lo que hicimos anteriormente con Entity Framework, o podría ser una API etc.

El patrón de diseño repository es un intermediario para esta información, nos da una manera de acceder a estos datos sin que la aplicación se preocupe de que es lo que esta pasando en repository 
Repository es un patrón de diseño estructura, nos ayudara a como manejar la estructura de todo esto.

**Pequeño ejemplo**
```csharp
using (var context = new DesingPatternsContext())
{
    //Creando el repositorio
    var beerRepository = new BeerRepository(context);
    //Insertando datos y guardando
    beerRepository.InsertBeer(new Beer { BeerId = 3, Name = "Victoria", Style = "Miche" });
    beerRepository.Save();

    //Obteniendo datos
    var beers = beerRepository.GetBeers();
    foreach (var beer in beers)
    {
        Console.WriteLine(beer.Name);
        //OUTPUT: Minerva, Corona, Victoria
    }

}
```

### [Unit of Work](https://github.com/JairMora21/PatronesDeDiseno/tree/master/UnitOfWorkPattern) (Comportamiento)
El patron unit of work lo que sugiere es que si tenemos un conjunto de peticiones en la base de datos podemos agruparlas y mandarlas juntas ahorrándonos solicitudes por cada interacción, esto es muy útil en proyectos reales .

**Pequeño ejemplo**
```csharp
using (var context = new DesingPatternsContext())
{
    //Creando el repositorio UnitOfWork
    var unitOfWork = new UnitOfWork(context);

    //Creamos un objeto de tipo cerveza y lo insertamos
    var beers = unitOfWork.Beers;
    var beer = new Beer { Name = "Fuller", Style = "Nose" };
    beers.Insert(beer);

    //Creamos un objeto de tipo marca y lo insertamos
    var brands = unitOfWork.Brands;
    var brand = new Brand { Name = "Ultra" };
    brands.Insert(brand);

    //Guardamos los cambios de ambas tablas
    //unitOfWork.Save();

}
```

### [Strategy](https://github.com/JairMora21/PatronesDeDiseno/tree/master/StrategyPattern) (Comportamiento)
Es un patron de diseño de comportamiento, es decir nos va a ayudar a realizar cierto comportamiento de nuestros objetos.

Un ejemplo podría ser cuando estamos haciendo un sistema tipo PhotoShop en el cual vamos a hacer figuras, el dibujar un cuadrado es una estrategia, dibujar un circulo es otra pero la acción dibujar tiene distinto comportamiento 

Con este patron lo que haremos que el manejo de este tipo de acciones que se pueden categorizar tengan una escabilidad y un manejo muy practico aparte este patron de diseño una ves creas el objeto tu puedes cambiar su comportamiento de una manera dinámica 
.
**Pequeño ejemplo**
```csharp
var context = new Context(new CarStrategy());
context.Run();
//OUTPUT: Car is running with 4 wheels
context.Strategy = new MotoStrategy();
context.Run();
//OUTPUT: Moto is running with 2 wheels
```

### [Builder](https://github.com/JairMora21/PatronesDeDiseno/tree/master/BuilderPattern) (Comportamiento)
Este es un patrón de diseño creacional que nos ayudara a crear objetos complejo, cuando estamos trabajando con objetos complejos, es decir, que su constructor es enorme nos viene bien este patrón de diseño, porque nos va a permitir un o distintos objetos del mismo tipo de clase de una manera muy sencilla.


**Pequeño ejemplo**
```csharp
var builder = new PreparedAlcholicDrinkConcreteBuilder();
var director = new BarmanDirector(builder);
director.MakeMargarita();

var preparedDrink = builder.GetPreparedDrink();
Console.WriteLine(preparedDrink.Result);
//OUTPUT: Mezclando 100ml de agua, 0ml de leche, 10ml de alcohol y Lemon, Salt, Tequila
```


### [State](https://github.com/JairMora21/PatronesDeDiseno/tree/master/StatePattern) (Comportamiento)
Este patron servirá para que nuestros objetos tengan cierto comportamiento dependiendo el contextp, este patrón se define básicamente por su nombre “State” que va a hacer una forma con la cual dependiendo el estado de un objeto el objeto va a actuar de alguna forma.

Por ejemplo; podemos tener un objeto que maneje una reproducción de un video y este objeto tiene distintos estados dependiendo su estado va a comportarse de una u otra forma como el estado cuando inicias una pagina el video se encuentra en pausa, cuando el video se esta reproduciendo ese es otro estado, cuando se ha terminado es otro estado y así sucesivamente, dependiendo el estado del objeto actuara de diferente forma 


**Pequeño ejemplo**
```csharp
var customerContext = new CustomerContext();
Console.WriteLine("Estado actual: " + customerContext.GetState());
//OUTPUT: Estado actual: DesignPatterns.StatePattern.NewState

customerContext.Request(100);
//OUTPUT: Se le pone dinero a su saldo 100

Console.WriteLine("Estado actual: " + customerContext.GetState());
//OUTPUT: Estado actual: DesignPatterns.StatePattern.NotDebtorState

customerContext.Request(50);
//OUTPUT: Solicitud permitida, gasta 50 y le queda saldo de 50

Console.WriteLine("Estado actual: " + customerContext.GetState());
//OUTPUT: Estado actual: DesignPatterns.StatePattern.NotDebtorState

customerContext.Request(60);
//OUTPUT: No tiene saldo suficiente, saldo actual 50
```

