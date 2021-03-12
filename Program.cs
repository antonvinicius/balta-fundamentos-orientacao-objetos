using System;
using System.Collections.Generic;
using System.Linq;
using PogBalta.ContentContext;
using PogBalta.SubscriptionContext;

namespace PogBalta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo Sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo Sobre C#", "csharp"));
            articles.Add(new Article("Artigo Sobre .NET", "dot-net"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var courseOop = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOop);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem3 = new CareerItem(3, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem2 = new CareerItem(2, "Aprenda .NET", "", courseAspNet);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }
    }
}
