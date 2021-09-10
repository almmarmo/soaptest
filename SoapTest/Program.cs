using System;

namespace SoapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.MigracaoSisComSoapClient a = new ServiceReference1.MigracaoSisComSoapClient(ServiceReference1.MigracaoSisComSoapClient.EndpointConfiguration.MigracaoSisComSoap, "http://jbhaafisr002.corp.tvglobo.com.br/migracaosiscom/migracaosiscom.asmx");
            var b = a.ObterInfoProgramasAsync("SP1", "2021090910").Result;

            Console.WriteLine("Hello World!");
        }
    }
}
