using System;
using MundiAPI.Standard;
using MundiAPI.Standard.Models;

///
/// Programa demonstra como usar o sdk da Mundi Pagg
/// Este código está disponível em: https://docs.mundipagg.com/docs/criando-uma-cobran%C3%A7a
/// Este projeto foi criado com o Dotnet Core 5, Ubuntu e VsCode
///

namespace mundi
{
    class Program
    {
        static void Main(string[] args)
        {
            string basicAuthUserName = "sk_test_4AdjlqpseatnmgbW";
            string basicAuthPassword = "";

            var client = new MundiAPIClient(basicAuthUserName, basicAuthPassword);

            var request = new CreateChargeRequest() {
                Amount = 1490,
                CustomerId = "cus_aGvrM1lCvxUKW9N7",
                Payment = new CreatePaymentRequest() {
                    PaymentMethod = "credit_card",
                    CreditCard = new CreateCreditCardPaymentRequest(){
                        CardId = "card_qBkxRKtmEfgyv1Zd",
                        Card = new CreateCardRequest {
                            Cvv = "353",
                        }
                    }
                }
            };

            var response = client.Charges.CreateCharge(request);
            Console.WriteLine("Done!");
        }
    }
}
