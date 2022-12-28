/*
 * Nicolas Calafiore
 * 
 * Demonstration of the Strategy Design pattern for object-orientated programming.
 * 
 * Scenario: a weather forecasting app that allows users to view the current weather conditions and forecast for their location. The app 
 * includes a feature that suggests a clothing recommendation for the current weather based on the temperature, humidity, and other relevant factors.
 * 
 * 
 * 
 * 
 */



using Strategy_Design_for_OOP;
using Strategy_Design_for_OOP.PaymentStrategy;


class StrategyDemoClass
{
 
    static IPaymentStrategy _strategy;                      // Interface for all types of Payment Processes (Process using Gift Card, Process using Credit Card, Process using PayPal)
    static IPaymentMethodStrategy _payment;                 // Interface for all objects representing forms of payment (Gift Card, Credit Card, PayPal)
    static Random rnd = new Random();                      
      

    static void Main(string[] args)
    {
        int total = rnd.Next(0, 500);                       // Calculating random arbitrary cost
        Console.Write("Total: $" + total);
        int menuOption = Int32.Parse(menuOptions());        // Outputs menu options (1-Credit 2-PayPal 3-Gift)
        processPayment(menuOption, total);                  
    }


    static String menuOptions()
    {
        Console.WriteLine("Choose Payment Method");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. PayPal");
        Console.WriteLine("3. Gift Card");
        String input = Console.ReadLine();
        return input;
    }
    static void processPayment(int option, int total)
    {
        switch (option)                                     //Depending on what was chosen at Menu Selection (1-Credit 2-PayPal 3-Gift)
        {
            case 1: _strategy = new PayWithCreditStrategy(); _payment = new PaymentTypes.CreditCardDetails(); break;    //Assigns Payment Process interfance to CreditCard
            case 2: _strategy = new PayWithPayPal(); _payment = new PaymentTypes.PayPalDetails(); break;                //Assigns Payment Process interfance to PayPal
            case 3: _strategy = new PayWithGiftCard(); _payment = new PaymentTypes.GiftCardDetails(); break;            //Assigns Payment Process interfance to Gift
        }
        _payment.GetPaymentDetails();                       //Depending on assigned concrete class from abstract class IPaymentMethodStrategy the .GetPaymentDetails() method is called to collect the proper information based on type
        _strategy.Pay(total, _payment);                     //Depending on assigned concrete class from abstract class IPaymentStrategy the .Pay() method is called which calls the proper method to process the charge depending on the type of payment
    }





}



