using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dressFactory = new DressFactory();
            var shirtFactory = new ShirtFactory();

            // Создаем товары
            var dress = dressFactory.CreateProduct("Elegant Dress", 100);
            var shirt = shirtFactory.CreateProduct("Blue Shirt", 50);

            // Создаем корзину и добавляем товары
            var cart = new Cart();
            cart.AddProduct(dress);
            cart.AddProduct(shirt);
            cart.DisplayCart();

            // Создаем заказ
            var order = new Order();
            var user = new User("John Doe");

            // Создаем наблюдателя для уведомлений
            var notifier = new OrderNotifier();
            notifier.Subscribe(user);

            // Переводим заказ в активное состояние и уведомляем пользователя
            order.Handle();
            notifier.Notify(order);

            // Переводим заказ в состояние доставки+
            order.Handle();
            notifier.Notify(order);

            Console.ReadLine();
        }
    }
}
