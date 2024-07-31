namespace LaundryService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bernice' Laundry Services");
          
         
          
            Console.WriteLine("Please select how you would like to be assisted:");
            Console.WriteLine("1. Laundry");
            Console.WriteLine("2. Dry clean");
            Console.WriteLine("3. Shoe wash/revamp");
            Console.WriteLine("4. Bedding & rugs");
            Console.WriteLine("5. House Call");
            int products;
            products = Convert.ToInt32(Console.ReadLine());

            switch (products) 
            { 
              case 1:
                      Console.WriteLine("Please select the size of your laundry basket below. \n NOTE that sizing is according to our criteria for more info check our terms and conditions.");
                      Console.WriteLine("1. Small basket R70.00");
                      Console.WriteLine("2. Medium basket R120.00");
                      Console.WriteLine("3. Large basket R180.00");
                      Console.WriteLine("4. Exra large basket R240.00");
                      int? basket = Convert.ToInt32(Console.ReadLine());


                      Console.WriteLine("Enter you Payment details below:");
                      Console.WriteLine("Card Number:");
                      int CardNumber = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Name on card:");
                      string? username = Console.ReadLine();
                      Console.WriteLine("CVV:");
                      int Cvv = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Expiry date:");
                      int? ExpiryDate = Convert.ToInt32(Console.ReadLine());
                    
                      Console.WriteLine("Enter your email below to get your order confirmation");
                      string? email = Console.ReadLine();
                      
                      Console.WriteLine("Order has been placed successfully you will receive confirmation from {0}", email);
                      Console.WriteLine("We appriciate the support, our agent will be in contact \n Enjoy the rest of your day.");
                    break;

              case 2:
                      Console.WriteLine("Select the item for dry clean. Note that at the moment we only do quotes for dry clean in-store");
                      Console.WriteLine("1. Formal attire e.g suits");
                      Console.WriteLine("2. Bedding");
                      Console.WriteLine("3. Laundry");
                      int DryClean = Convert.ToInt32(Console.ReadLine());

                      Console.WriteLine("1. Pick-up and Delivery(R80)");
                      Console.WriteLine("2. Drop-off and Collection(Free)");
                      int DeliveryMethod = Convert.ToInt32(Console.ReadLine());

                      if (DeliveryMethod == 1)
                      {
                          Console.WriteLine("Enter you Payment details below:");
                          Console.WriteLine("Card Number:");
                          CardNumber = Convert.ToInt32(Console.ReadLine());
                          Console.WriteLine("Name on card:");
                          username = Console.ReadLine();
                          Console.WriteLine("CVV:");
                          Cvv = Convert.ToInt32(Console.ReadLine());
                          Console.WriteLine("Expiry date:");
                          ExpiryDate = Convert.ToInt32(Console.ReadLine());

                          Console.WriteLine("Please enter your email below to get order cornfirmation");
                          email = Console.ReadLine();
                          Console.WriteLine("Please enter your delivery address and also note that delivery will incur charges.");
                          string? DeliveryAddress = Console.ReadLine();
                          Console.WriteLine("Order has been placed successfully you will receive confirmation from {0}", email);
                    }
                      else if (DeliveryMethod == 2)
                      {
                          Console.WriteLine("Enter your email address below to get order confirmation");
                          email = Console.ReadLine();
                          Console.WriteLine("Order has been placed successfully you will receive confirmation from {0}", email);
                    }
                      else
                      {
                          Console.WriteLine(" 404 error! You have entered an invalid input.");
                      }
                    break;
              case 3:
                      Console.WriteLine("Shoe wash or shoe revamp?");
                      Console.WriteLine("Select what you would like us to do with your shoes");
                      Console.WriteLine("1. Shoe Wash(R100)");
                      Console.WriteLine("2.Shoe revamp/customization (R250)");
                      int Shoe = Convert.ToInt32(Console.ReadLine());

                     
                      Console.WriteLine("1. Pick-up and Delivery(R80)");
                      Console.WriteLine("2. Drop-off and Collection(Free)");
                      DeliveryMethod = Convert.ToInt32(Console.ReadLine());

                      if (DeliveryMethod == 1)
                      {
                          Console.WriteLine("Enter you Payment details below:");
                          Console.WriteLine("Card Number:");
                          CardNumber = Convert.ToInt32(Console.ReadLine());
                          Console.WriteLine("Name on card:");
                          username = Console.ReadLine();
                          Console.WriteLine("CVV:");
                          Cvv = Convert.ToInt32(Console.ReadLine());
                          Console.WriteLine("Expiry date:");
                          ExpiryDate = Convert.ToInt32(Console.ReadLine());

                          Console.WriteLine("Please enter your email below to get order cornfirmation");
                          email = Console.ReadLine();
                          Console.WriteLine("Please enter your delivery address and also note that delivery will incur charges.");
                          string? DeliveryAddress = Console.ReadLine();
                          Console.WriteLine("Order has been placed successfully you will receive confirmation from {0}", email);
                    }
                      else if(DeliveryMethod == 2)
                      {
                        Console.WriteLine("Please enter your email below to get order cornfirmation");
                        email = Console.ReadLine();
                        Console.WriteLine("Order has been placed successfully you will receive confirmation from {0}", email);
                    }
                      else
                      {
                        Console.WriteLine(" 404 error! You have entered an invalid input.");
                      }

                    break;
              case 4: 
                      Console.WriteLine("Bedding or rugs?");
                      Console.WriteLine("1. Bedding");
                      Console.WriteLine("2. Rugs");
                      int Bedding = Convert.ToInt32(Console.ReadLine());

                      if(Bedding == 1)
                      {
                        Console.WriteLine("1.Comforter set Single R60");
                        Console.WriteLine("2.Comforter set Three-quarter R90");
                        Console.WriteLine("3.Comforter set Double R120");
                        Console.WriteLine("4.Comforter set King R150");
                        Console.WriteLine("5.Comforter set Queen R170");
                        Console.WriteLine("6. Duvet set Single R55");
                        Console.WriteLine("7. Duvet set Three-quarter R85");
                        Console.WriteLine("8. Duvet set Double R110");
                        Console.WriteLine("9. Duvet set King R135");
                        Console.WriteLine("10. Duvet set Queen R160");
                        Console.WriteLine("11. Blanket Single R70");
                        Console.WriteLine("12. Blanket Three quarter R90");
                        Console.WriteLine("13. Blanket Double R120");
                        Console.WriteLine("14. Throw Single R60");
                        Console.WriteLine("15. Throw Double R80");
                        Console.WriteLine("16. Throw Queen R100");
                        int Sets = Convert.ToInt32(Console.ReadLine());
                      }
                      else if(Bedding== 2)
                      {
                        Console.WriteLine("!. Small R30");
                        Console.WriteLine("2. Medium R50");
                        Console.WriteLine("3. Large R80");
                        int Bed = Convert.ToInt32(Console.ReadLine());
                      }
                      else
                      {
                        Console.WriteLine("404 error! You have entered an invalid input");
                      }

                      Console.WriteLine("Please enter your email below to get order cornfirmation");
                      email = Console.ReadLine();
                      Console.WriteLine("Enter you Payment details below:");
                      Console.WriteLine("Card Number:");
                      CardNumber = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Name on card:");
                      username = Console.ReadLine();
                      Console.WriteLine("CVV:");
                      Cvv = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Expiry date:");
                      ExpiryDate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Order has been placed successfully you will receive confirmation from {0}", email);
                    break;
              case 5:
                      Console.WriteLine("House call");
                      Console.WriteLine("How do you want us to help you?");

                      Console.WriteLine("1.Spring clean R200");
                      Console.WriteLine("2.Laundry R100(Depending on the size)");
                      Console.WriteLine("3.Bedding R120(Depending on the size)");
                      int HouseCall = Convert.ToInt32(Console.ReadLine());

                      Console.WriteLine("Enter you Payment details below:");
                      Console.WriteLine("Card Number:");
                      CardNumber = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Name on card:");
                      username = Console.ReadLine();
                      Console.WriteLine("CVV:");
                      Cvv = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Expiry date:");
                      ExpiryDate = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("Please provide us with your email address and our agent will be in contact with you.");
                      email = Console.ReadLine();
                      Console.WriteLine("Order has been placed successfully you will receive confirmation from {0}", email);
                      Console.WriteLine("Thank you!");
                    break;
               default:
                      Console.WriteLine("You have entered an invalid input, please enter one of the given options");
                    break;

            }

        }
    }
}
