using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class DesignPatterns
    {
        static void Main(string[] args)
        {
            int designPattern = 90;
            while (designPattern != 0)
            {
                Console.WriteLine("Digite o numero do pattern desejado");
                designPattern = Convert.ToInt32(Console.ReadLine());
                switch (designPattern)
                {
                    case 1: DesignPattern1(); break;
                    case 2: DesignPattern2(); break;
                    case 3: DesignPattern3(); break;
                    case 4: DesignPattern4(); break;
                    case 5: DesignPattern5(); break;
                    case 6: DesignPattern6(); break;
                    case 7: DesignPattern7(); break;
                    case 8: DesignPattern8(); break;
                    case 9: DesignPattern9(); break;
                    case 10: DesignPattern10(); break;
                    case 11: DesignPattern11(); break;
                    case 12: DesignPattern12(); break;
                    case 13: DesignPattern13(); break;
                    case 14: DesignPattern14(); break;
                    case 15: DesignPattern15(); break;
                    case 16: DesignPattern16(); break;
                    case 17: DesignPattern17(); break;
                    case 18: DesignPattern18(); break;
                    case 19: DesignPattern19(); break;
                    case 20: DesignPattern20(); break;
                    case 21: DesignPattern21(); break;
                    case 22: DesignPattern22(); break;
                    case 23: DesignPattern23(); break;
                    default: break;
                }
                Console.Clear();
            }
        }

        static void DesignPattern1()
        {
            Console.WriteLine("Singleton");
            var singleton = Singleton.Instancia;
            singleton.Mensagem = "Olá mundo!";
            Console.WriteLine(singleton.Mensagem);
            var anotherSingleton = Singleton.Instancia;
            Console.WriteLine(anotherSingleton.Mensagem);
            Console.WriteLine("Variáveis Singleton são iguais? " + singleton.Equals(anotherSingleton));
            Console.ReadLine();
        }

        static void DesignPattern2()
        {
            Console.WriteLine("Facade");
            var facade = new Facade();
            facade.MetodoGeral();
            var facade2 = new Facade();
            facade2.MetodoGeral();
            Console.WriteLine("Variáveis Facade são iguais? " + facade.Equals(facade2));
            Console.ReadLine();
        }

        static void DesignPattern3()
        {
            Console.WriteLine("Factory");
            string numeroFabrica;
            IFactory fabrica = new Factory();
            Console.WriteLine("Digite o numero da factory:");
            numeroFabrica = Console.ReadLine();
            switch (numeroFabrica)
            {
                case "1":
                    fabrica = new Factory();
                    break;
                case "2":
                    fabrica = new Factory2();
                    break;
                case "3":
                    fabrica = new Factory3();
                    break;
                default:
                    break;
            }
            fabrica.CriaFabrica();
            Console.ReadLine();
        }

        static void DesignPattern4()
        {
            Console.WriteLine("Strategy");
            var estrategia = new Strategy();
            estrategia.SetPrint(new FileTxt());
            estrategia.ExecutePrint();
            estrategia.SetPrint(new FilePDF());
            estrategia.ExecutePrint();
            Console.ReadLine();
        }

        static void DesignPattern5()
        {
            Console.WriteLine("Composite");
            IComposite arq1 = new FileComposite("composite.png");
            IComposite arq2 = new FileComposite("foto.jpg");
            IComposite arq3 = new FileComposite("cv.txt");

            IComposite pastaPrincipal = new FolderComposite("arquivos");
            IComposite pasta1 = new FolderComposite("imagens");
            IComposite pasta2 = new FolderComposite("office");

            pastaPrincipal.Add(pasta1);
            pastaPrincipal.Add(pasta2);

            pasta1.Add(arq1);
            pasta1.Add(arq2);

            pasta2.Add(arq3);
            pasta2.Add(new FileComposite("composite.pdf"));

            Console.WriteLine(pastaPrincipal);
            Console.WriteLine("________________________________");
            Console.WriteLine(pasta1);
            Console.WriteLine("________________________________");
            Console.WriteLine(pasta2);
            Console.WriteLine("________________________________");

            Console.WriteLine(arq1);
            Console.WriteLine("________________________________");
            Console.WriteLine(arq2);
            Console.WriteLine("________________________________");
            Console.WriteLine(arq3);

            Console.ReadKey();
        }

        static void DesignPattern6()
        {
            Console.WriteLine("Adapter");
            IAdapter a = new Adapter();
            Console.WriteLine(a.On());
            Console.WriteLine(a.Off());
            Console.WriteLine();
            a = new Adapter2();
            Console.WriteLine(a.On());
            Console.ReadKey();
        }

        static void DesignPattern7()
        {
            Console.WriteLine("Observer");
            IObserverSupport controleZap = new ObserverSupport();

            var observerA = new ObserverA();
            var observerB = new ObserverB();
            var observerC = new ObserverC();

            controleZap.Register(observerA);
            controleZap.Register(observerB);
            controleZap.Register(observerC);

            Console.WriteLine("Os observers A, B e C cadastraram-se para receber as mensagens.");
            controleZap.SendMessage();

            Console.WriteLine("O observer A resolveu cancelar a assinatura e não irá receber mais mensagens.");
            controleZap.Delete(observerA);

            Console.WriteLine("Enviando mensagens para os observers assinados.");
            controleZap.SendMessage();

            Console.ReadKey();
        }

        static void DesignPattern8()
        {
            Console.WriteLine("Decorator");
            DecoratorBase db = new DecoratorBase();
            Console.WriteLine("Decorator:");
            Console.WriteLine("{0:c}", db.Preco);
            Console.WriteLine("_________________");

            DecoratorSprinkles ds;
            ds = new DecoratorSprinkles(db);
            Console.WriteLine("Decorator com granulado:");
            Console.WriteLine("{0:c}", ds.Preco);
            Console.WriteLine("_________________");

            DecoratorCandy dc;
            dc = new DecoratorCandy(db);
            Console.WriteLine("Decorator com doce:");
            Console.WriteLine("{0:c}", dc.Preco);
            Console.WriteLine("_________________");

            ds = new DecoratorSprinkles(dc);
            Console.WriteLine("Decorator com granulado e doce:");
            Console.WriteLine("{0:c}", ds.Preco);

            Console.ReadKey();
        }

        static void DesignPattern9()
        {
            Console.WriteLine("Builder");
            BuilderObject fruit = new Builder()
                            .setComplexProperty("maçã")
                            .setComplexProperty2("vermelha")
                            .setComplexProperty3("lisa")
                            .Build();
            Console.WriteLine(fruit.ToString());
            Console.ReadKey();
        }

        static void DesignPattern10()
        {
            Console.WriteLine("Prototype");
            List<Prototype> listaPrototipos = new List<Prototype>();
            Prototype prototipo = new Prototype(10, 20);
            listaPrototipos.Add(prototipo);
            var outroPrototipo = prototipo.clone();
            listaPrototipos.Add(outroPrototipo);

            Console.WriteLine(listaPrototipos.Count);
            Console.WriteLine(prototipo.ToString());
            Console.WriteLine(outroPrototipo.ToString());
            Console.WriteLine("Ambos são iguais? " + prototipo.Equals(outroPrototipo).ToString());

            Console.ReadKey();
        }

        static void DesignPattern11()
        {
            Console.WriteLine("Bridge");
            Client client = new Client();

            Bridge bridge;
            bridge = new Bridge(new OperationBridgeA());
            client.ClientCode(bridge);

            Console.WriteLine("______________");

            bridge = new BridgeAdvance(new OperationBridgeB());
            client.ClientCode(bridge);

            Console.ReadKey();
        }

        static void DesignPattern12()
        {
            Console.WriteLine("Flyweight");
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "rosa" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "preto" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "vermelho" },
                new Car { Company = "BMW", Model = "M5", Color = "vermelho" },
                new Car { Company = "BMW", Model = "X6", Color = "branco" }
            );
            factory.listFlyweights();

            void addCarToDatabase(FlyweightFactory flyweightFactory, Car car)
            {
                Console.WriteLine("\nCliente: Adicionando carro ao banco.");

                var flyweight = flyweightFactory.GetFlyweight(new Car
                {
                    Color = car.Color,
                    Model = car.Model,
                    Company = car.Company
                });

                flyweight.Operation(car);
            }

            addCarToDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "Joãozinho",
                Company = "BMW",
                Model = "M5",
                Color = "vermelho"
            });

            addCarToDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "Pedrinho",
                Company = "BMW",
                Model = "X1",
                Color = "vermelho"
            });

            factory.listFlyweights();

            Console.ReadKey();
        }

        static void DesignPattern13()
        {
            Console.WriteLine("Proxy");
            ClientProxy client = new ClientProxy();

            Console.WriteLine("Client: Executando código com o objeto real:");
            Subject subject = new Subject();
            client.ClientCode(subject);

            Console.WriteLine();

            Console.WriteLine("Client: Executando mesmo código com o proxy:");
            Proxy proxy = new Proxy(subject);
            client.ClientCode(proxy);

            Console.ReadKey();
        }

        static void DesignPattern14()
        {
            Console.WriteLine("Chain of Responsibility");
            var programador = new ProgrammerHandler();
            var design = new DesignHandler();
            var ops = new OpsHandler();


            programador.Next(design).Next(ops);

            Console.WriteLine("Chain: Programador > Design > Ops\n");
            ClientChain.ClientCode(programador);
            Console.WriteLine();

            Console.WriteLine("Subchain: Design > Ops\n");
            ClientChain.ClientCode(design);

            Console.ReadKey();
        }

        static void DesignPattern15()
        {
            Console.ReadKey();
        }

        static void DesignPattern16()
        {
            Console.ReadKey();
        }

        static void DesignPattern17()
        {
            Console.ReadKey();
        }

        static void DesignPattern18()
        {
            Console.ReadKey();
        }

        static void DesignPattern19()
        {
            Console.ReadKey();
        }

        static void DesignPattern20()
        {
            Console.ReadKey();
        }

        static void DesignPattern21()
        {
            Console.ReadKey();
        }

        static void DesignPattern22()
        {
            Console.ReadKey();
        }

        static void DesignPattern23()
        {
            Console.ReadKey();
        }
    }
}
