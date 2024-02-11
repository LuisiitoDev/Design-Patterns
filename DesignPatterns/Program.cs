using DesignPatterns.BehaviorPattern.Observer;
using DesignPatterns.BehaviorPattern.Strategy;
using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Factory;
using DesignPatterns.CreationalPattern.Singleton;
using DesignPatterns.StructuralPattern.Facade;
using DesignPatterns.StructuralPattern.Proxy;
// CREATIONAL PATTERN

// SINGLETON

// ShoppingCart.GetInstance().Add(new ShoppingCartProduct("Sofa",2000));
// ShoppingCart.GetInstance().Add(new ShoppingCartProduct("Kitchen",2500));


// Console.WriteLine("Singleton");
// Console.WriteLine(ShoppingCart.GetInstance().ToString());


// Factory

// // Utilizando ConcreteFactoryA para crear ConcreteProductA
// IFactory factoryA = new ConcreteFactoryA();
// IProduct productA = factoryA.CreateProduct();
// productA.Operation();

// // Utilizando ConcreteFactoryB para crear ConcreteProductB
// IFactory factoryB = new ConcreteFactoryB();
// IProduct productB = factoryB.CreateProduct();
// productB.Operation();

// Builder


// // Crear un constructor
// ICarBuilder carBuilder = new CarBuilder();

// // Crear un director y asignarle el constructor
// CarDirector carDirector = new CarDirector(carBuilder);

// // Construir el automóvil paso a paso
// carDirector.ConstructCar();

// // Obtener el automóvil construido
// Car car = carBuilder.GetCar();

// // Mostrar la información del automóvil
// car.DisplayInfo();


// Utilizando el proxy para realizar la petición.
// Proxy proxy = new Proxy();
// proxy.Request();

// Console.ReadLine();

// Facade facade = new Facade();
// facade.Operation();

// Console.ReadLine();

// Crear un sujeto
// ConcreteSubject subject = new ConcreteSubject();

// // Crear observadores
// ConcreteObserver observer1 = new ConcreteObserver("Observador 1");
// ConcreteObserver observer2 = new ConcreteObserver("Observador 2");

// // Adjuntar observadores al sujeto
// subject.Attach(observer1);
// subject.Attach(observer2);

// // Notificar a los observadores
// subject.Notify("¡Se ha actualizado el estado!");

// Console.ReadLine();

// Crear un contexto con la estrategia A por defecto
Context context = new Context(new ConcreteStrategyA());

// Ejecutar la estrategia A
context.ExecuteStrategy();

// Cambiar a la estrategia B
context.ChangeStrategy(new ConcreteStrategyB());

// Ejecutar la estrategia B
context.ExecuteStrategy();

Console.ReadLine();